using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MahaleSystem.Models;
using MahaleSystem.Repository.Implementation;
using MahaleSystem.Repository.Interface;
using MahaleSystem.ViewModel.Manahel;

namespace MahaleSystem.Controllers
{
    public class ManahelsController : Controller
    {
        private readonly ManahelContext _context;
        private readonly ImanahelRepository context1;
        private readonly IUsersManhalRepositry contextuser;
        private bool IsSuperAdmin = false;
        public ManahelsController(ImanahelRepository context,IUsersManhalRepositry contextuser)
        {
            this.context1 = context;
            this.contextuser = contextuser;
        }

        // GET: Manahels
        public ActionResult Index()
        {
            IsSuperAdmin = true;
            ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            ViewData["IsSuperAdmin"] = IsSuperAdmin;
            return View(context1.GetAllManahelsTest());
        }
        public ActionResult AdminIndex(string user_ID)
        {
            List<UsersManhals> manhalsID = contextuser.GetAllBy(a => a.UserId == user_ID);
            List<Manahel> manahels = new List<Manahel>();
            foreach (var item in manhalsID)
            {
                manahels.Add(context1.GetElement(item.ManelId));
            }
            IsSuperAdmin = false;
            ViewData["IsSuperAdmin"] = IsSuperAdmin;
            ViewData["Manahel"] = manahels;//context1.GetAllManahelsMenuTest();
            return View(manahels);
        }

        public ActionResult SuperAdminIndex()
        {
            IsSuperAdmin = true; ViewData["IsSuperAdmin"] = IsSuperAdmin;
            List<UsersManhals> manhalsID = contextuser.GetAll();
            List<Manahel> manahels = new List<Manahel>();
            foreach (var item in manhalsID)
            {
                manahels.Add(context1.GetElement(item.ManelId));
            }
            ViewData["Manahel"] = manahels;// context1.GetAllManahelsMenuTest();
            return View(manahels);
        }

        public ActionResult DetailsAll()
        {
            ViewData["IsSuperAdmin"] = IsSuperAdmin;
            ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            List<InfoVM> infoVm = new List<InfoVM>()
            {
                new InfoVM(){name="Number of Manahel",value=10 },
                new InfoVM(){name="Number of Khalia",value=1000},
                new InfoVM(){name="Number of Queue",value=950},
                new InfoVM(){name="Number of Products",value=100}
            };
            return View(infoVm);
        }
        // GET: Manahels/Details/5
        public ActionResult Details(int id)
        {
            ViewData["IsSuperAdmin"] = IsSuperAdmin;
            ViewData["Manahel"] = context1.GetAllManahelsMenuTest();

            var manahel = context1.GetManahelsTest(id);
            if (manahel == null)
            {
                return NotFound();
            }

            return View(manahel);
        }

        // GET: Manahels/Create
        public ActionResult Create()
        {
            ViewData["IsSuperAdmin"] = IsSuperAdmin;
            ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            return View();
        }

        // POST: Manahels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Ssn,NickName,LocationName,FlowerName,DateCreated,DateUpdated")] Manahel manahel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manahel);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(manahel);
        }

        // GET: Manahels/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            if (id == null)
            {
                return NotFound();
            }

            var manahel =  _context.Manahels.Find(id);
            if (manahel == null)
            {
                return NotFound();
            }
            return View(manahel);
        }

        // POST: Manahels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Ssn,NickName,LocationName,FlowerName,DateCreated,DateUpdated")] Manahel manahel)
        {
            if (id != manahel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manahel);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManahelExists(manahel.Id))
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
            return View(manahel);
        }

        // GET: Manahels/Delete/5
        public ActionResult Delete(int? id)
        {
            ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            if (id == null)
            {
                return NotFound();
            }

            var manahel =  _context.Manahels
                .FirstOrDefault(m => m.Id == id);
            if (manahel == null)
            {
                return NotFound();
            }

            return View(manahel);
        }

        // POST: Manahels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var manahel = _context.Manahels.Find(id);
            _context.Manahels.Remove(manahel);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ManahelExists(int id)
        {
            return _context.Manahels.Any(e => e.Id == id);
        }
    }
}
