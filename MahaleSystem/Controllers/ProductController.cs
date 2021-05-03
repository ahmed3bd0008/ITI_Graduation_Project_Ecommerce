using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MahaleSystem.Repository.Interface;
using MahaleSystem.Models;
using MahaleSystem.ViewModel.Manahel;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MahaleSystem.Controllers
{
    public class ProductController : Controller
    {
        //private readonly ManahelContext _context1;
        private readonly IProductRepository context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductController(IProductRepository context,IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int manhalID)
        {
            ViewData["ManhalId"] = manhalID;
            //List<Product> product = context.GetAllBy(a => a.ManhalId == manhalID);

            return View(context.GetProductsWithImage(manhalID));
        }
        [HttpGet]
        public ActionResult Create(int manhalID)
        {
            ViewData["ManhalId"] = manhalID;
            return View(new Product());
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Add(product);
                context.Savechange();
                return RedirectToAction(nameof(Index), new { manhalID = product.ManhalId });
            }
            ViewData["ManhalId"] = product.ManhalId;
            return View(product);
        }
        public IActionResult getbyid(int? id )
        {
            List<Product> productsID = context.GetAllBy(a => a.Id == id);
            List<Product> products = new List<Product>();
            foreach (var item in productsID)
            {
                products.Add(context.GetElement(item.Id));
            }
            
            return View(products);
            //return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = context.GetElement(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
            //return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,DatePick,FlowerName,ProductName,ProductAmount,Containter,Description,ManhalId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Updata(product);
                    context.Savechange();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { manhalID = product.ManhalId });
            }
            return View(product);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = context.GetElement(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //var product = context.GetElement(id);
            context.DeleteProductImages(id);
            context.Delete(id);
            context.Savechange();
            return RedirectToAction(nameof(Index), new { manhalID = id });
        }

        [HttpGet]
        public ActionResult AddImage(int productID)
        {
            AddImageVM imageVM = new AddImageVM();
            imageVM.id = productID;
            return View(imageVM);
        }
        [HttpPost]
        public ActionResult AddImage(AddImageVM imageVM)
        {
            string uniqueFileName = null;

            if (imageVM.imageFile != null)
            {
                try
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + imageVM.imageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        imageVM.imageFile.CopyTo(fileStream);
                    }                    
                    ImagesProduct images = new ImagesProduct();
                    images.ImagesString = uniqueFileName;
                    images.ProductId = imageVM.id;
                    context.AddImage(images);

                    var idManhal = context.GetManahel(imageVM.id).Id;
                    return RedirectToAction(nameof(Index), "Product", new { manhalID = idManhal });
                }
                catch { }
            }
            return View(imageVM);
        }
        private bool ProductExists(int id)
        {
            return context.GetAll().Any(e => e.Id == id);
        }
    }
}


