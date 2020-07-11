using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QN_Harpstore1.Models;
using QN_Harpstore1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        [Authorize]
        public IActionResult Index()
        {
            var role = roleManager.Roles;
            var model = new List<Role>();
            model = role.Select(r => new Role
            {
                RoleId = r.Id,
                RoleName = r.Name
            }).ToList();
            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Create(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await roleManager.CreateAsync(new IdentityRole()
                {
                    Name = model.RoleName
                });
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }
                foreach(var roleError in result.Errors)
                {
                    ModelState.AddModelError("", roleError.Description); 
                }
            }
            return View();
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var model = new EditRoleViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(EditRoleViewModel model)
        {
            return View();
        }
        public async Task<IActionResult> Remove(string id)
        {
            var delRole = await roleManager.FindByIdAsync(id);
            if (delRole != null)
            {
                var result = await roleManager.DeleteAsync(delRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }
                foreach (var roleError in result.Errors)
                {
                    ModelState.AddModelError("", roleError.Description);
                }
            }
            return View();
        }
    }
}
