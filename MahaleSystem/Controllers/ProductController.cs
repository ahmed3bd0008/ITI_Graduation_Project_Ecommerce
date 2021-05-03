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
using MahaleSystem.ViewModel.Product;

namespace MahaleSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly ManahelContext context1;
        private readonly IProductRepository context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductController(IProductRepository context,ManahelContext context1,IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
            this.context1 = context1;
        }
        public ActionResult Index(int manhalID)
        {
            ViewData["ManhalId"] = manhalID;

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
        public ActionResult Search(int id, string txtSearch)
        {
            var product = context1.Products.Where(a => a.ManhalId == id)
                                .Where(b => b.ProductName.Contains(txtSearch))
                                .Include(x => x.ImageProducts).ToList();
            return View(nameof(Index), product);
        }
        [HttpGet]
        public ActionResult Publish(int id)
        {
            ProductPublishVM publish = new ProductPublishVM();
            publish.datePublish = DateTime.Now;
            publish.ProductName = context.GetElement(id).ProductName;
            publish.ProdcutID = id;
            return View(publish);
        }
        [HttpPost]
        public ActionResult Publish(ProductPublishVM publish)
        {
            if (ModelState.IsValid)
            {
                ProductPublish productPublish = new ProductPublish();
                productPublish.ProdcutID = publish.ProdcutID;
                productPublish.ProductName = publish.ProductName;
                productPublish.ProductPrice = publish.ProductPrice;
                productPublish.Description = publish.Description;
                productPublish.datePublish = publish.datePublish;

                context.AddProductPublish(productPublish);
                var product = context.GetElement(publish.ProdcutID.Value);
                return RedirectToAction(nameof(Index), new { manhalID = product.ManhalId});
            }
            return View();
        }

        [HttpGet]
        public ActionResult Sell(int id)
        {
            ProductSellVM sells = new ProductSellVM();
            sells.ProdcutID = id;
            sells.PrioductName = context.GetElement(id).ProductName;
            sells.dateSell = DateTime.Now;
            return View(sells);
        }
        [HttpPost]
        public ActionResult Sell(ProductSellVM sellVM)
        {
            if (ModelState.IsValid)
            {
                var product = context.GetElement(sellVM.ProdcutID.Value);
                if (product != null)
                {
                    if (product.ProductAmount >= sellVM.ProductAmount)
                    {
                        ProductSells sells = new ProductSells();
                        sells.ProdcutID = sellVM.ProdcutID;
                        sells.PrioductName = sellVM.PrioductName;
                        sells.Price = sellVM.Price;
                        sells.Notes = sellVM.Notes;
                        sells.dateSell = sellVM.dateSell;
                        sells.ProductAmount = sellVM.ProductAmount;
                        context.AddProductSell(sells);

                        product.ProductAmount -= sellVM.ProductAmount;
                        context.Updata(product);
                        context.Savechange();
                        return RedirectToAction(nameof(Index), new { manhalID = product.ManhalId });
                    }
                }
            }
            return View(sellVM);
        }
        public ActionResult DisplaySells(int manhalId)
        {
            var products = context.GetAllBy(a => a.ManhalId == manhalId).ToList();
            List<ProductSells> productSells = new List<ProductSells>();
            foreach (var item in products)
            {
                var pS = context1.ProductSells.Where(a => a.ProdcutID == item.Id).ToList();
                if (pS != null) 
                    productSells.AddRange(pS);
            }
            return View(productSells);
        }
        public ActionResult DisplayPublishs(int manhalId)
        {
            var products = context.GetAllBy(a => a.ManhalId == manhalId).ToList();
            List<ProductPublish> productSells = new List<ProductPublish>();
            foreach (var item in products)
            {
                var pS = context1.ProductPublish.Where(a => a.ProdcutID == item.Id).ToList();
                if (pS != null)
                    productSells.AddRange(pS);
            }
            return View(productSells);
        }
        public ActionResult DeletePublish(int id)
        {
            var publish = context1.ProductPublish.Where(a => a.Id == id).FirstOrDefault();
            if (publish != null)
            {
                context1.ProductPublish.Remove(publish);
                context1.SaveChanges();
                var product = context.GetElement(publish.ProdcutID.Value);
                return RedirectToAction(nameof(DisplayPublishs), new { id = product.ManhalId });
            }
            return NotFound();
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
    public class DisplayProductStatisticsViewComponent : ViewComponent
    {
        private readonly IProductRepository context1;
        public DisplayProductStatisticsViewComponent(IProductRepository context)
        {
            this.context1 = context;
        }
        public IViewComponentResult Invoke(int id_Manahal)
        {
            return View("DisplayProductStatistics", context1.GetAllStatistic(id_Manahal));
        }
    }
}


