using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using MahaleSystem.ViewModel.Manahel;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Implementation
{
    public class ProductRepository : GenaricRepository<Product>,IProductRepository
    {
        private readonly ManahelContext context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductRepository(ManahelContext _context,IWebHostEnvironment webHostEnvironment) : base(_context)
        {
            context = _context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public void DeleteProductImages(int idProduct)
        {
            var imgs = context.ImagesProducts.Where(a => a.ProductId == idProduct).ToList();
            foreach (var item in imgs)
            {
                string imgName = item.ImagesString;
                context.ImagesProducts.Remove(item);
                context.SaveChanges();
                try
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), uploadsFolder, imgName);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
                catch { }
            }
        }
        public void AddProductSell(ProductSells sells)
        {
            context.ProductSells.Add(sells);
            context.SaveChanges();
        }
        public void AddProductPublish(ProductPublish publish)
        {
            context.ProductPublish.Add(publish);
            context.SaveChanges();
        }
        public List<Product> GetProductsWithImage(int idManhal)
        {
            var products = context.Products.Where(a => a.ManhalId == idManhal).ToList();
            foreach (var item in products)
            {
                var imgs = context.ImagesProducts.Where(a => a.ProductId == item.Id).ToList();
                item.ImageProducts = imgs;
            }
            return products;
        }
        public int AddImage(ImagesProduct item)
        {
            context.ImagesProducts.Add(item);
            return context.SaveChanges();
        }
        public void DeleteImage(int idImage)
        {
            ImagesProduct img = context.ImagesProducts.Where(a => a.Id == idImage).FirstOrDefault();
            try
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), uploadsFolder, img.ImagesString);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            catch { }
            context.ImagesProducts.Remove(img);
            context.SaveChanges();
        }
        public Manahel GetManahel(int idProduct)
        {
            var product = context.Products.Find(idProduct);
            if (product != null)
            {
                Manahel manahel = context.Manahels.Find(product.ManhalId);
                if (manahel != null)
                    return manahel;
            }
            return null;
        }
        public int GetShamaStatistic(int manhalId)
        {
            var products = context.Products.Where(a => a.ManhalId == manhalId)
                                     .Where(b => b.ProductName.Contains("شمع")).ToList();
            int quantity = 0;
            foreach (var item in products)
            {
                quantity += item.ProductAmount;
                //var productSells = context.ProductSells.Where(a => a.ProdcutID == item.Id).ToList();
                //foreach (var item2 in productSells)
                //{
                //    quantity += item2.ProductAmount;
                //}
            }
            return quantity;
        }
        public Tuple<int, int, int> GetAsalStatistic(int manhalId)
        {
            var products = context.Products.Where(a => a.ManhalId == manhalId)
                                     .Where(b => b.ProductName.Contains("عسل")).ToList();
            int Q1 = 0, Q2 = 0, Q3 = 0;
            foreach (var item in products)
            {
                if (item.Containter == "صفيحة")
                    Q1 += item.ProductAmount;
                if (item.Containter == "جركن")
                    Q2 += item.ProductAmount;
                else
                    Q3 += item.ProductAmount;
                //var productSells = context.ProductSells.Where(a => a.ProdcutID == item.Id).ToList();
                //foreach (var item2 in productSells)
                //{
                //    if(item.Containter=="صفيحة")
                //        Q1 += item2.ProductAmount;
                //    if (item.Containter == "جركن")
                //        Q2 += item2.ProductAmount;
                //    else
                //        Q3 += item2.ProductAmount;
                //}
            }
            Tuple<int, int, int> tuple = new Tuple<int, int, int>(Q1, Q2, Q3);
            return tuple;
        }
        public List<InfoVM> GetAllStatistic(int manahelId)
        {
            int Q4 = GetShamaStatistic(manahelId);
            Tuple<int, int, int> t = GetAsalStatistic(manahelId);
            Tuple<int, int, int, int> tuple2 = new Tuple<int, int, int, int>(t.Item1, t.Item2, t.Item3, Q4);
            List<InfoVM> infoVMs = new List<InfoVM>()
            {
                new InfoVM(){name="كمية العسل بالصفيحة",value=t.Item1},
                new InfoVM(){name="كمية العسل بالجركن",value=t.Item2},
                new InfoVM(){name="كمية العسل بجارة",value=t.Item3},
                new InfoVM(){name="كمية الشمع بالكيلو",value=Q4},
            };
            return infoVMs;
        }
        public void DeleteSellAndPublishData(int productId)
        {
            var sells = context.ProductSells.Where(a => a.ProdcutID == productId).ToList();
            foreach (var item in sells)
            {
                try
                {
                    context.ProductSells.Remove(item);
                    context.SaveChanges();
                }
                catch { }
            }
            var publishs = context.ProductPublish.Where(a => a.ProdcutID == productId).ToList();
            foreach (var item in publishs)
            {
                try
                {
                    context.ProductPublish.Remove(item);
                    context.SaveChanges();
                }
                catch { }
            }
        }
    }
}
