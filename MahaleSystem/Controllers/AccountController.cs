using MahaleSystem.Models;
using MahaleSystem.Repository.Implementation;
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
        private readonly ManahelContext context;
        List<Tuple<string, string>> tuples;
        List<string> lst = new List<string>();
        public AccountController(ManahelContext context)
        {
            this.context = context;
            tuples = new List<Tuple<string, string>>();
            var res = context.Users;
            foreach (var item in res)
            {
                tuples.Add(new Tuple<string, string>(item.Id, item.UserName));//.Substring(0, item.UserName.Length - 10)
                lst.Add(item.UserName);
            }
            lst.Add("SuperAdmin");
        }
        //public AccountController()
        //{
          
        //}
        public IActionResult login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult login2()
        {
            ViewData["Users"] = new SelectList(lst);
            return View();
        }
        [HttpPost]
        public IActionResult login2(string UserName)
        {
            if (UserName == "SuperAdmin")
            {
                return RedirectToAction("SuperAdminIndex", "Manahels");
            }
            string Uid = tuples.Where(a => a.Item2 == UserName).First().Item1;
            return RedirectToAction("AdminIndex", "Manahels", new { user_ID = Uid });
        }
    }
}
