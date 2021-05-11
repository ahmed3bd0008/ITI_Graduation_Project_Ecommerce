
﻿using MahaleSystem.Models;
using MahaleSystem.Models.Identity;
﻿using MahaleSystem.Models.Identity;
using MahaleSystem.ViewModel;
using MahaleSystem.ViewModel.Account;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using MahaleSystem.Models;
using MahaleSystem.Repository.Implementation;
using MahaleSystem.ViewModel.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MahaleSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<CustomIdentityuser> _userManager;
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly IUploadFile _uploadFile;
        private readonly SignInManager<CustomIdentityuser> _signInManager;

        public AccountController(UserManager<CustomIdentityuser> userManager,
            RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityuser> signInManager,
          IUploadFile uploadFile)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _uploadFile = uploadFile;
            _signInManager = signInManager;


        }
        public IActionResult login()
        {

          ViewBag.ReturnUrl=  Request.Query["ReturnUrl"].ToString();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LogInUserViewModel model, String ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RemmberMe, true);
                if (result.Succeeded)
                {
                    if (ReturnUrl != null)
                    {
                        return LocalRedirect(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "invaild");
            }
            return View();
        }
        public async Task<IActionResult> Register()
        {
            var users = _userManager.Users.ToList();
            String Role;
            DisplayUserViewModel model = new() { users = users };
            foreach (var item in users)
            {
                Role = (await _userManager.GetRolesAsync(item)).FirstOrDefault();
                model.Roles.Add(Role);
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Policy = "addUser")]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    CustomIdentityuser user = new()
                    {
                        Email = model.Name,
                        UserName = model.Name,
                        PhoneNumber = model.Phone
                    };
                    if (model.formFile != null)
                    {
                        user.Image = _uploadFile.ProcessorUploadFile(model);
                    }
                    else
                    {
                        user.Image = "index.png";
                    }
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        if (_signInManager.IsSignedIn(User))
                        {
                            return RedirectToAction("AddUser", "Account");
                        }
                        await _signInManager.SignInAsync(user, isPersistent: false);

                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);

                    }
                }
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            //used to sign out
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "Account");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
    
}

