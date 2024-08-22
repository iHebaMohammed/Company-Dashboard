using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Demo.PL.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager=roleManager;
        }

        public async Task<IActionResult> Index(string SearchValue)
        {
            var roles = Enumerable.Empty<IdentityRole>().ToList(); // Empty Sequence 
            if (string.IsNullOrEmpty(SearchValue))
            {
                roles.AddRange(_roleManager.Roles);
            }
            else
            {
                roles.Add(await _roleManager.FindByNameAsync(SearchValue));
            }
            return View(roles);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (ModelState.IsValid) // Server side validation
            {
                await _roleManager.CreateAsync(role);
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }


        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            return View(ViewName, role);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] string id, IdentityRole updatedRole)
        {
            if (id != updatedRole.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var role = await _roleManager.FindByIdAsync(updatedRole.Id);
                    role.Name = updatedRole.Name;

                    //user.Email = updatedUser.Email;
                    //user.SecurityStamp = updatedUser.SecurityStamp; // Random value must change when the email or password has updated

                    var result = await _roleManager.UpdateAsync(role); // Will throw exception
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
                }
            }
            return View(updatedRole);
        }



        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(IdentityRole deletedRole, string id)
        {
            if (id != deletedRole.Id)
                return BadRequest();
            try
            {
                var role = await _roleManager.FindByIdAsync(deletedRole.Id);
                var result = await _roleManager.DeleteAsync(role); // Will throw exception
                if (result.Succeeded)
                    return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                // 1. Log exception in database
                // 2. Friendly message
                ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
            }
            return View(deletedRole);
        }
    }
}
