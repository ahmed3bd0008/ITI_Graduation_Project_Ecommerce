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
        
        public AccountController(ManahelContext context)
        {
            this.context = context;
            
        }
        //public AccountController()
        //{
          
        //}
        public IActionResult login()
        {
            return View();
        }
        
    }
}
