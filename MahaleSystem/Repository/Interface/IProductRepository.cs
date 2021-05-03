using MahaleSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Interface
{
    public interface IProductRepository : IGenaricRepository<Product>
    {
        public int AddImage(ImagesProduct item);
        public Manahel GetManahel(int idProduct);
        public List<Product> GetProductsWithImage(int idManhal);
        public void DeleteProductImages(int idProduct);
    }
}
