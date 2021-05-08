using MahaleSystem.Models;
using MahaleSystem.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ManahelContext context;
        public HomeController(ManahelContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<PublishClientVM> clientVM = new List<PublishClientVM>();
            var productPublished = context.ProductPublish.Include(x => x.product)
                                            .Include(a => a.product.ImageProducts)
                                            .Include(b => b.product.Manhal).ToList();
            foreach (var item in productPublished)
            {
                var userId = context.UsersManhals.Where(a => a.ManelId == item.product.ManhalId).FirstOrDefault().UserId;
                var user = context.Users.Where(a => a.Id == userId).FirstOrDefault();
                clientVM.Add(new PublishClientVM()
                {
                    admin = user,
                    product = item.product,
                    productPublished = item
                });
            }
            return View(clientVM);
            //return View();
        }

        public ActionResult Details(int id)
        {
            PublishClientVM clientVM = new PublishClientVM();
            var productPublished = context.ProductPublish.Where(a => a.Id == id)
                                            .Include(x => x.product)
                                            .Include(a => a.product.ImageProducts)
                                            .Include(b => b.product.Manhal).FirstOrDefault();
            if (productPublished != null)
            {
                var userId = context.UsersManhals.Where(a => a.ManelId == productPublished.product.ManhalId).FirstOrDefault().UserId;
                var user = context.Users.Where(a => a.Id == userId).FirstOrDefault();
                clientVM = new PublishClientVM()
                {
                    admin = user,
                    product = productPublished.product,
                    productPublished = productPublished
                };
            return View(clientVM);
            }
            return NotFound();
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
