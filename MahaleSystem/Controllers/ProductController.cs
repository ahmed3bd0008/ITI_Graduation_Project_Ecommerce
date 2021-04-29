using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MahaleSystem.Repository.Interface;
using MahaleSystem.Models;

namespace MahaleSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly ManahelContext _context1;
        private readonly IProductRepository _context;
<<<<<<< HEAD
        public ProductController(IProductRepository context)
        {
            this._context = context;
=======

      
            public ProductController(IProductRepository context)
        {
            this._context = context;
           

>>>>>>> 99d22654a65ec16a4aa4ee98fc9bc6962da3dbc3
        }

        public IActionResult Index()
        {
            _context.GetAll();
            return View();
        }
        public IActionResult getbyid(int? id )
        {
            List<Product> productsID = _context.GetAllBy(a => a.Id == id);
            List<Product> products = new List<Product>();
            foreach (var item in productsID)
            {
                products.Add(_context.GetElement(item.Id));
            }
            
            return View(products);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context1.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ManhalId"] = new SelectList(_context1.Manahels, "Id", "Id", product.ManhalId);
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatePick,FlowerName,ProductName,ProductAmount,ManhalId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context1.Update(product);
                    await _context1.SaveChangesAsync();
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManhalId"] = new SelectList(_context1.Manahels, "Id", "Id", product.ManhalId);
            return View(product);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context1.Products
                .Include(p => p.Manhal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context1.Products.FindAsync(id);
            _context1.Products.Remove(product);
            await _context1.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool ProductExists(int id)
        {
            return _context1.Products.Any(e => e.Id == id);
        }
    }
}


