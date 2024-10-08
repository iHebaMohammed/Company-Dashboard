﻿using AutoMapper;
using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly IMapper _mapper;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public AccountController(IMapper mapper , UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signInManager)
        {
			_mapper = mapper;
			_userManager = userManager;
			_signInManager=signInManager;
		}

        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid) // Server side validation
            {
                var user = new ApplicationUser()
                {
                    UserName = model.Email.Split('@')[0],
                    Email = model.Email,
                    IsAgree = model.IsAgree,
                };
                //var user = _mapper.Map<RegisterViewModel, ApplicationUser>(model);
                var result = await _userManager.CreateAsync(user , model.Password);
                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if(user != null)
                {
                    bool flag = await _userManager.CheckPasswordAsync(user, model.Password);
                    if (flag)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user , model.Password , model.RememberMe , false);
                        if (result.Succeeded)
                            return RedirectToAction("Index" , "Home");
                    }
                    ModelState.AddModelError(string.Empty, "Password is not correct");
                }
                ModelState.AddModelError(string.Empty, "Email is not exist");
            }
            return View(model);
        }

        #endregion

        #region Signout

        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        #endregion

        #region Forget Password

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> SendEmail(ForgetPasswordViewModel model)
		{
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user); //Token is valid for only one time for this user
                                                     //ActionName   //ControllerName     //QueryString        //Protocole    //Host      //Fregmant     
                    var resetPasswordLink = Url.Action("ResetPassword", "Account" , new { Email = model.Email, Token = token }, Request.Scheme , "");
                    var email = new Email()
                    {
                        Subject = "Reset your password",
                        To = model.Email,
                        Body = $"Reset Password Link \n{resetPasswordLink}"
                    };

                    await EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckYourInbox));
                }
                ModelState.AddModelError(string.Empty, "This email is not existed");
            }

			return View(model);
		}

        public IActionResult CheckYourInbox()
        {
            return View();
        }

        public IActionResult ResetPassword(string Email , string Token)
        {
            TempData["Email"] = Email;
            TempData["Token"] = Token;
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
		{

            if (ModelState.IsValid)
            {
                string email = TempData["Email"] as string;
                var user = await _userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    string token = TempData["Token"] as string;
					var result = await _userManager.ResetPasswordAsync(user , token , model.Password);
                    if (result.Succeeded)
                    {
						return RedirectToAction(nameof(Login));
					}foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
				}
			}

			return View();
		}

		#endregion
	}
}
