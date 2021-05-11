using DocumentFormat.OpenXml.InkML;
using MahaleSystem.Models.Identity;
using MahaleSystem.ViewModel.Administration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MahaleSystem.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly UserManager<CustomIdentityuser> _userManager;

        public AdministrationController(RoleManager<CustomIdentityRole> roleManager, UserManager<CustomIdentityuser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> ShowMangeUser(string Id)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(Id);
                if (user == null) { return View(); }
                var Role = await _userManager.GetRolesAsync(user);
                var claims = await _userManager.GetClaimsAsync(user);
                UserMangment model = new()
                {
                    Id = Id,
                    UserName = user.UserName,
                    Roles = Role.FirstOrDefault(),
                    Claims = claims.Select(e => e.Value).ToList()
                };
                return View(model);
            }
            return View();
        }
        public async Task<IActionResult> GetAllClaims(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return RedirectToAction("ShowMangeUser", "Administration");
            var ExistringClaims = ConfigClaims.GetAllClaims();
            var ClaimOfUser = await _userManager.GetClaimsAsync(user);
            ClaimsUserViewModel Claims = new();
            Claims.UserId = id;
            foreach (var item in ExistringClaims)
            {
                CusrtomClaims cusrtomClaims = new CusrtomClaims();
                if (ClaimOfUser.Any(c => c.Type == item.Type))
                {
                    cusrtomClaims.IsSelected = true;
                }
                cusrtomClaims.ClaimsType = item.Type;
                cusrtomClaims.ClaimsValue = item.Value;
                Claims.Claimsuser.Add(cusrtomClaims);
            }
            return View(Claims);
        }
        [HttpPost]
        public async Task<IActionResult> GetAllClaims(ClaimsUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null) return View();
            var userclaims = await _userManager.GetClaimsAsync(user);
            var RemoveClaims = await _userManager.RemoveClaimsAsync(user, userclaims);
            if (RemoveClaims.Succeeded)
            {
                foreach (var item in model.Claimsuser)
                {
                    if (item.IsSelected)
                    {
                        await _userManager.AddClaimAsync(user, new Claim(item.ClaimsType, item.ClaimsValue));
                    }

                }
            }
            return RedirectToAction("ShowMangeUser", new { Id = model.UserId });
        }
        [HttpGet]
        public async Task<IActionResult> ChangeuserName(String Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return View("Error");
            ChangePasswordViewModel model = new ChangePasswordViewModel { UserName = user.UserName, UserId = Id };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeuserName(ChangePasswordViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            user.UserName = model.UserName;
            if (user == null) return View("Error");
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded == true) return RedirectToAction("ShowMangeUser", new { Id = model.UserId });
            return View("Error");
        }
        [HttpGet]
        public async Task<IActionResult> ChangeUserPassword(String Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null) return View("Error");
            ChangePasswordViewModel model = new ChangePasswordViewModel { UserName = user.PasswordHash, UserId = Id };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeUserPassword(ChangePasswordViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, code, model.UserName);
            if (result.Succeeded)
            {
                return RedirectToAction("ShowMangeUser", new { Id = model.UserId });
            }
            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(String id)
        {
            if (id == null) return View("Error");
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return View("Error");
            var res = await _userManager.DeleteAsync(user);
            if (res.Succeeded) return RedirectToAction("Register", "Account");
            return View("Error");
        }
        [HttpGet]
        public async Task< IActionResult> EditUserProfile(String username)
        {
            if (User == null) return View("Error");
            var user = await _userManager.FindByNameAsync(username);
            if (user == null) return View("Error");
            UserProfileviewmodel model = new UserProfileviewmodel()
            {
                Id = user.Id,
                UserName = user.UserName,
            };
              var claims =await _userManager.GetClaimsAsync(user);
            model.UserClaims = claims.Select(e => e.Value).ToList();
            return View(model);
        }
        [HttpPost]
        public async Task< IActionResult> userChangeUserName([Bind(include: "Id,UserName,Password")]UserChangeUserNameViewModel model)
        {
            if (model.Id == null) return View("Error");
            if (model.Password == null) return RedirectToAction("EditUserProfile",new { username =model.UserName});
            if (model.UserName == null) return RedirectToAction("EditUserProfile",new { username = model.UserName });
            //var existinguUser = _userManager.FindByNameAsync(model.UserName);
            //if (existinguUser != null) return RedirectPreserveMethod("EditUserProfile");
            var user =await _userManager.FindByIdAsync(model.Id);
            user.UserName = model.UserName;
            if (user== null) return RedirectToAction("EditUserProfile", new { username = model.UserName });
            var res =await _userManager.UpdateAsync(user);
            return RedirectToAction("EditUserProfile", new { username = model.UserName });
        }
        [HttpPost]
        public async Task<IActionResult> UserChangePassword([Bind(include: "Id,OldPassword,NewPassword,ConfarmnewPassword")] userChangePasswordviewmodel model)
        {
            if (model.Id == null) return View("Error");
            var user = await _userManager.FindByIdAsync(model.Id);
            if (model.OldPassword == null) return RedirectToAction("EditUserProfile", new { username = user.UserName });
            if (model.NewPassword == null) return RedirectToAction("EditUserProfile", new { username = user.UserName });
            if (user == null) return RedirectToAction("EditUserProfile", new { username = user.UserName });
            var res =await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (res.Succeeded) return RedirectToAction("EditUserProfile", new { username = user.UserName });
            return RedirectToAction("EditUserProfile", new { username = user.UserName });

        }
    }
}
