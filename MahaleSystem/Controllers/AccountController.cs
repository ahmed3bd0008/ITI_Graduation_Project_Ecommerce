using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Controllers
{
    public class AccountController : Controller
    {
       
        public AccountController()
        {
          
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult Register()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
