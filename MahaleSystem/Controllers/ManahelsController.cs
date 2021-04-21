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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MahaleSystem.Controllers
{
    public class ManahelsController : Controller
    {
        private readonly ManahelContext _context;
        private readonly ImanahelRepository context1;
        private readonly IUsersManhalRepositry contextuser;
        private readonly IWebHostEnvironment webHostEnvironment;
        public static bool IsSuperAdmin = false;
        public static string userID = "";
        public ManahelsController(ImanahelRepository context,IUsersManhalRepositry contextuser,IWebHostEnvironment webHostEnvironment)
        {
            this.context1 = context;
            this.contextuser = contextuser;
            this.webHostEnvironment = webHostEnvironment;
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
            IsSuperAdmin = false;userID = user_ID;
            List<UsersManhals> manhalsID = contextuser.GetAllBy(a => a.UserId == user_ID);
            List<Manahel> manahels = new List<Manahel>();
            foreach (var item in manhalsID)
            {
                manahels.Add(context1.GetElement(item.ManelId));
            }
            //ViewData["IsSuperAdmin"] = IsSuperAdmin;
            //ViewData["Manahel"] = manahels;//context1.GetAllManahelsMenuTest();
            return View(manahels);
        }

        public ActionResult SuperAdminIndex()
        {
            IsSuperAdmin = true; //ViewData["IsSuperAdmin"] = IsSuperAdmin;
            List<UsersManhals> manhalsID = contextuser.GetAll();
            List<Manahel> manahels = new List<Manahel>();
            foreach (var item in manhalsID)
            {
                manahels.Add(context1.GetElement(item.ManelId));
            }
            //ViewData["Manahel"] = manahels;// context1.GetAllManahelsMenuTest();
            return View(manahels);
        }

        public ActionResult DetailsAll()
        {
            //ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            List<InfoVM> infoVm = new List<InfoVM>()
            {
                new InfoVM(){name="Number of Manahel",value=10 },
                new InfoVM(){name="Number of Khalia",value=1000},
                new InfoVM(){name="Number of Queue",value=950},
                new InfoVM(){name="Number of Products",value=100}
            };
            if (IsSuperAdmin)
                return View(infoVm);
            else
                return RedirectToAction("AdminIndex", new { user_ID = userID });
        }
        // GET: Manahels/Details/5
        public ActionResult Details(int id)
        {
            ViewData["ManhalImage"] = new AddImageVM() { id = id, imageFile = null };
            Manahel manahel = context1.GetElement(id);
            if (manahel != null)
            {
                List<Khalias> khalias = context1.GetKhaliases(id);
                List<ImagesManahel> images = context1.GetImages(id);
                ManhalDetailsVM detailsVM = new ManhalDetailsVM();
                detailsVM.manhal = manahel;
                detailsVM.khalias = khalias;
                detailsVM.imagesManahels = images;

                return View(detailsVM);
            }
                return NotFound();

            //return View(manahel);
        }

        // GET: Manahels/Create
        public ActionResult Create()
        {
            var res = contextuser.GetUsers();
            ViewData["Users"] = res;
            return View(new CreateManhalVM());
            //ViewData["IsSuperAdmin"] = IsSuperAdmin;
        }

        // POST: Manahels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[Bind("Id,Ssn,NickName,LocationName,FlowerName,DateCreated,DateUpdated")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateManhalVM manahelVM)
        {
            var res = contextuser.GetUsers();
            ViewData["Users"] = res;
            if (ModelState.IsValid)
            {
                Task<bool> b = context1.Is_SSN_Exist(manahelVM.manahel.Ssn, manahelVM.AccountId);
                if (b.Result == false)
                {
                    Manahel manahel = context1.Add(manahelVM.manahel);
                    context1.Savechange();
                    UsersManhals usersManhals = new UsersManhals();
                    usersManhals.ManelId = manahel.Id;
                    usersManhals.UserId = manahelVM.AccountId;
                    contextuser.Add(usersManhals);
                    contextuser.Savechange();
                    string uniqueFileName = null;
                    if (manahelVM.imageFile != null)
                    {
                        try
                        {
                            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                            uniqueFileName = Guid.NewGuid().ToString() + "_" + manahelVM.imageFile.FileName;
                            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                            using (var fileStream = new FileStream(filePath, FileMode.Create))
                            {
                                manahelVM.imageFile.CopyTo(fileStream);
                            }
                            ImagesManahel images = new ImagesManahel();
                            images.ImagesString = uniqueFileName;
                            images.ManahelId = manahel.Id;

                            context1.AddImage(images);
                        }
                        catch { }
                }
                    return RedirectToAction(nameof(SuperAdminIndex));
                }
            }
            return View(manahelVM);
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

        public async Task<IActionResult> AddImage(AddImageVM imageVM)
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
                    ImagesManahel images = new ImagesManahel();
                    images.ImagesString = uniqueFileName;
                    images.ManahelId = imageVM.id.Value;
                    context1.AddImage(images);

                }
                catch { }
            }
            return RedirectToAction("Details", "Manahels", new { id = imageVM.id });
        }

        private bool ManahelExists(int id)
        {
            return _context.Manahels.Any(e => e.Id == id);
        }
    }
    public class GetManahalViewComponent : ViewComponent
    {
        private readonly ImanahelRepository context1;
        private readonly IUsersManhalRepositry contextuser;
        public GetManahalViewComponent(ImanahelRepository context, IUsersManhalRepositry contextuser)
        {
            this.context1 = context;
            this.contextuser = contextuser;
        }
        public IViewComponentResult Invoke()
        {
            List<Manahel> manahels = new List<Manahel>();
            if (ManahelsController.IsSuperAdmin)
            {
                List<UsersManhals> manhalsID = contextuser.GetAll();
                foreach (var item in manhalsID)
                {
                    manahels.Add(context1.GetElement(item.ManelId));
                }
            }
            else
            {
                List<UsersManhals> manhalsID = contextuser.GetAllBy(a => a.UserId == ManahelsController.userID);
                foreach (var item in manhalsID)
                {
                    manahels.Add(context1.GetElement(item.ManelId));
                }
            }
            return View("GetManahal", manahels);
        }
    }
}
