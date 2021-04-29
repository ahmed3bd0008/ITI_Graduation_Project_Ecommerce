using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Implementation
{
    public class ProductRepository : GenaricRepository<Product>,IProductRepository
    {
        private readonly ManahelContext context;
        public ProductRepository(ManahelContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
