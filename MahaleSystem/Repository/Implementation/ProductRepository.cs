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
       
    }
}
