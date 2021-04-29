using MahaleSystem.Models;
using MahaleSystem.Models.Identity;
using MahaleSystem.Repository.Implementation;
using MahaleSystem.ViewModel.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    return RedirectToAction("Register", "Account");
                }
                ModelState.AddModelError(string.Empty, "invaild");
            }
            return View();
        }
    }
}
