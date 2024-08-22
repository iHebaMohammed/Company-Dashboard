using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Demo.PL.Controllers
{
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;

		public UserController(UserManager<ApplicationUser> userManager)
        {
			_userManager=userManager;
		}


		public async Task<IActionResult> Index(string SearchValue)
		{
			var users = Enumerable.Empty<ApplicationUser>().ToList(); // Empty Sequence 
			if (string.IsNullOrEmpty(SearchValue))
			{
				users.AddRange(_userManager.Users);
			}
			else
			{
				users.Add(await _userManager.FindByEmailAsync(SearchValue));
			}
			return View(users);
		}


		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(RegisterViewModel model)
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
				var result = await _userManager.CreateAsync(user, model.Password);
				if (result.Succeeded)
					return RedirectToAction(nameof(Index));
				foreach (var error in result.Errors)
					ModelState.AddModelError(string.Empty, error.Description);
			}
			return View(model);
		}


		public async Task<IActionResult> Details(string id, string ViewName = "Details")
		{
			if (id == null)
				return NotFound();
			var user = await _userManager.FindByIdAsync(id);
			if (user == null)
				return NotFound();

			return View(ViewName, user);
		}


		[HttpGet]
		public async Task<IActionResult> Edit(string id)
		{
			return await Details(id, "Edit");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit([FromRoute] string id, ApplicationUser updatedUser)
		{
			if (id != updatedUser.Id)
				return BadRequest();
			if (ModelState.IsValid)
			{
				try
				{
					var user = await _userManager.FindByIdAsync(updatedUser.Id);
					user.UserName = updatedUser.UserName;
					user.PhoneNumber = updatedUser.PhoneNumber;

					//user.Email = updatedUser.Email;
					//user.SecurityStamp = updatedUser.SecurityStamp; // Random value must change when the email or password has updated
					
					var result = await _userManager.UpdateAsync(user); // Will throw exception
					return RedirectToAction(nameof(Index));
				}
				catch (Exception ex)
				{
					ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
				}
			}
			return View(updatedUser);
		}



		[HttpGet]
		public async Task<IActionResult> Delete(string id)
		{
			return await Details(id, "Delete");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteAsync(ApplicationUser deletedUser, string id)
		{
			if (id != deletedUser.Id)
				return BadRequest();
			try
			{
				var user = await _userManager.FindByIdAsync(deletedUser.Id);
				var result = await _userManager.DeleteAsync(user); // Will throw exception
				if (result.Succeeded)
					return RedirectToAction(nameof(Index));

			}
			catch (Exception ex)
			{
				// 1. Log exception in database
				// 2. Friendly message
				ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
			}
			return View(deletedUser);
		}
	}
}
