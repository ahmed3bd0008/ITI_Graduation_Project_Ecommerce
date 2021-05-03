using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
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
    }
}
