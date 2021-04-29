using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly ManahelContext _context1;
        private readonly IProductRepository _context;


        public IActionResult Index()
        {
            _context.GetAll();
            return View();
        }
    }
}
