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
using Microsoft.AspNetCore.Http;

namespace MahaleSystem.Controllers
{
    public class ManahelsController : Controller
    {
        private readonly ImanahelRepository context1;
        private readonly IUsersManhalRepositry contextuser;
        private readonly IWebHostEnvironment webHostEnvironment;
        public static bool IsSuperAdmin = false;
        public static string userID = "";
        public ManahelsController(ImanahelRepository context1,IUsersManhalRepositry contextuser,IWebHostEnvironment webHostEnvironment)
        {
            this.context1 = context1;
            this.contextuser = contextuser;
            this.webHostEnvironment = webHostEnvironment;
        }
        // GET: Manahels
        public ActionResult Index()
        {
            IsSuperAdmin = true;
           // ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            //ViewData["IsSuperAdmin"] = IsSuperAdmin;
            return View();
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
            IsSuperAdmin = true; 
            return View(context1.GetAllManahel());
        }
        public ActionResult DetailsAll()
        {
            //ViewData["Manahuel"] = context1.GetAllManahelsMenuTest();
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
            ViewData["GeneralAverage"] = 66;
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
        public ActionResult SearchLevel(int id, string txtSearch)
        {
            ViewData["ManhalImage"] = new AddImageVM() { id = id, imageFile = null };
            Manahel manahel = context1.GetElement(id);
            if (manahel != null)
            {
                List<Khalias> khalias = context1.GetKhaliases(id).Where(a => a.KhaliaLevel == txtSearch).ToList() ;
                List<ImagesManahel> images = context1.GetImages(id);
                ManhalDetailsVM detailsVM = new ManhalDetailsVM();
                detailsVM.manhal = manahel;
                detailsVM.khalias = khalias;
                detailsVM.imagesManahels = images;

                return View(nameof(Details),detailsVM);
            }
            return NotFound(); 
        }
        public ActionResult SearchStatus(int id, string txtSearch)
        {
            ViewData["ManhalImage"] = new AddImageVM() { id = id, imageFile = null };
            Manahel manahel = context1.GetElement(id);
            if (manahel != null)
            {
                List<Khalias> khalias = context1.GetKhaliases(id).Where(a => a.Queues.QueueStatus == txtSearch).ToList();
                List<ImagesManahel> images = context1.GetImages(id);
                ManhalDetailsVM detailsVM = new ManhalDetailsVM();
                detailsVM.manhal = manahel;
                detailsVM.khalias = khalias;
                detailsVM.imagesManahels = images;

                return View(nameof(Details), detailsVM);
            }
            return NotFound();
        }
        public ActionResult SearchType(int id, string txtSearch)
        {
            ViewData["ManhalImage"] = new AddImageVM() { id = id, imageFile = null };
            Manahel manahel = context1.GetElement(id);
            if (manahel != null)
            {
                List<Khalias> khalias = context1.GetKhaliases(id).Where(a => a.KhaliaType == txtSearch).ToList();
                List<ImagesManahel> images = context1.GetImages(id);
                ManhalDetailsVM detailsVM = new ManhalDetailsVM();
                detailsVM.manhal = manahel;
                detailsVM.khalias = khalias;
                detailsVM.imagesManahels = images;

                return View(nameof(Details), detailsVM);
            }
            return NotFound();
        }

        // GET: Manahels/Create
        public ActionResult Create()
        {
            var res = contextuser.GetUsers();
            ViewData["Users"] = res;
            return View(new CreateManhalVM());
            //ViewData["IsSuperAdmin"] = IsSuperAdmin;
        }
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
                    manahelVM.manahel.DateUpdated = manahelVM.manahel.DateCreated;
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
            //ViewData["Manahel"] = context1.GetAllManahelsMenuTest();
            if (id == null)
            {
                return NotFound();
            }

            var manahel = context1.GetElement(id.Value);
            if (manahel == null)
            {
                return NotFound();
            }
            return View(manahel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Ssn,NickName,LocationName,FlowerName,DateCreated")] Manahel manahel)
        {
            if (id != manahel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    manahel.DateUpdated = DateTime.Now;
                    context1.Updata(manahel);
                    context1.Savechange();
                    if (IsSuperAdmin == true)
                        return RedirectToAction(nameof(SuperAdminIndex));
                    else
                    {
                        string userId = contextuser.GetAllBy(a => a.ManelId == manahel.Id).FirstOrDefault().UserId;
                        return RedirectToAction(nameof(AdminIndex), new { user_ID = manahel });
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!context1.IsExist(a => a.Id == manahel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(manahel);
        }

        // GET: Manahels/Delete/5
        public ActionResult Delete(int id)
        {
            var manahel = context1.GetElement(id);
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
            var manahel = context1.GetElement(id);
            if (manahel != null)
            {
                var ks = context1.GetKhaliases(id);
                foreach (var item in ks)
                {
                    try
                    {
                        context1.DeleteKhalia(item.Id);
                    }
                    catch { }
                }
                context1.DeleteManhalImages(id);
                context1.Delete(id);
                context1.Savechange();
                var userManhal = contextuser.GetAllBy(a => a.ManelId == id).FirstOrDefault();
                if (userManhal != null)
                    contextuser.Delete(userManhal.Id);
                return RedirectToAction(nameof(SuperAdminIndex));
            }
            return View(id);
        }
        [HttpGet]
        public ActionResult AddKhalia(int idM)
        {
            ViewData["ManhalId"] = idM;
            ViewBagData();
            Khalias k = new Khalias();
            k.Queues = new Queue();
            return View(new AddKhaliaVM());
        }
        [HttpPost]
        public ActionResult AddKhalia(AddKhaliaVM khaliaVM)
        {
            if (ModelState.IsValid)
            {
                if (context1.Check_SSN_Khalia(khaliaVM.Ssn, khaliaVM.ManhalId) == false)
                {
                    Khalias khalias = new Khalias();
                    khalias.Ssn = khaliaVM.Ssn; khalias.KhaliaLevel = khaliaVM.KhaliaLevel;
                    khalias.KhaliaType = khaliaVM.KhaliaType;
                    khalias.ManhalId = khaliaVM.ManhalId;
                    khalias.Notes = khaliaVM.Notes;
                    khalias.PraweezCount = khaliaVM.PraweezCount;
                    khalias.Wood = khaliaVM.Wood;
                    var k = context1.AddKhalia(khalias);

                    Queue queue = new Queue();
                    queue.DateFertilization = khaliaVM.DateFertilization;
                    queue.KhaliaId = k.Id;
                    queue.QueueStatus = khaliaVM.QueueStatus;
                    context1.AddQueue(queue);
                    return RedirectToAction(nameof(Details), new { id = khalias.ManhalId });
                }
            }
            ViewBagData();
            return View(khaliaVM);
        }
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
                    ImagesManahel images = new ImagesManahel();
                    images.ImagesString = uniqueFileName;
                    images.ManahelId = imageVM.id;
                    context1.AddImage(images);

                }
                catch { }
            }
            return RedirectToAction("Details", "Manahels", new { id = imageVM.id });
        }
        public ActionResult AddImage2(int id, IFormFile imageFile)
        {
            string uniqueFileName = null;

            if (imageFile != null)
            {
                try
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }
                    ImagesManahel image = new ImagesManahel();
                    image.ImagesString = uniqueFileName;
                    image.ManahelId = id;
                    context1.AddImage(image);

                }
                catch { }
            }
            List<ImagesManahel> images = context1.GetImages(id);
            return new JsonResult(images);
            //return RedirectToAction("Details", "Manahels", new { id = id });
        }
        [HttpGet]
        public ActionResult EditKhalia(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var khalias = context1.getOneKhalia(id.Value);
            if (khalias == null)
            {
                return NotFound();
            }

            ViewData["Average"] = context1.GetKhlaiaStatistics(id.Value);
            ViewBagData();
            return View(khalias);
        }
        // POST: Khalia/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]  //Edit Khalia Info
        public ActionResult EditKhalia(int Id,
            [Bind("Id,Ssn,KhaliaLevel,KhaliaType,Wood,PraweezCount,Notes,ManhalId")] Khalias khalias)
        {
            if (Id != khalias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context1.UpdateKhalia(khalias);   
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewData["Average"] = context1.GetKhlaiaStatistics(Id);
                    ViewBagData();
                    return View(khalias);
                }
                return RedirectToAction(nameof(Details), new { id = khalias.ManhalId });
            }
            ViewData["Average"] = context1.GetKhlaiaStatistics(Id);
            ViewBagData();
            return View(khalias);
        }
        public ActionResult EditQueue(int Id,Queue queue)
        {
            if (Id != queue.Id)
            {
                return NotFound();
            }
            try
            {
                if (queue.Id != 0)
                    context1.UpdateQueu(queue);
                else
                    context1.AddQueue(queue);
            }
            catch (DbUpdateConcurrencyException)
            {
                ViewData["Average"] = context1.GetKhlaiaStatistics(queue.KhaliaId);
                ViewBagData();
                return RedirectToAction(nameof(EditKhalia), new { id = queue.KhaliaId });
            }
            ViewData["Average"] = context1.GetKhlaiaStatistics(queue.KhaliaId);
            ViewBagData();
            return RedirectToAction(nameof(EditKhalia), new { id = queue.KhaliaId });
        }
        public ActionResult DeleteKhalia(int id)
        {
            Khalias khalias = context1.getOneKhalia(id);
            if (khalias != null)
            {
                bool b = context1.DeleteKhalia(id);
                if (b)
                {
                    return RedirectToAction(nameof(Details), new { id = khalias.ManhalId });
                }
            }
            return RedirectToAction(nameof(EditKhalia), new { id = khalias.ManhalId });
        }
        public ActionResult Home()
        {
            if (IsSuperAdmin)
                return RedirectToAction(nameof(SuperAdminIndex));
            else
                return RedirectToAction(nameof(AdminIndex), new { user_ID = userID });
        }
        private void ViewBagData()
        {
            List<string> KhaliaLevel = new List<string>();
            KhaliaLevel.Add("Excellent"); KhaliaLevel.Add("Strong");
            KhaliaLevel.Add("Medium"); KhaliaLevel.Add("Weak");
            ViewData["KhaliaLevel"] = new SelectList(KhaliaLevel);

            List<string> KhaliaType = new List<string>();
            KhaliaType.Add("Complete"); KhaliaType.Add("Medium");
            KhaliaType.Add("Small");
            ViewData["KhaliaType"] = new SelectList(KhaliaType);

            List<string> woodType = new List<string>();
            woodType.Add("New"); woodType.Add("Old");
            ViewData["woodType"] = new SelectList(woodType);

            List<string> QueueStatus = new List<string>();
            QueueStatus.Add("Fertilized"); QueueStatus.Add("not Fertilized");
            QueueStatus.Add("Stacked"); QueueStatus.Add("without Queue");
            ViewData["QueueStatus"] = new SelectList(QueueStatus);

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
    public class DisplayStatisticsViewComponent : ViewComponent
    {
        private readonly ImanahelRepository context1;
        public DisplayStatisticsViewComponent(ImanahelRepository context)
        {
            this.context1 = context;
        }
        public IViewComponentResult Invoke(int id_Manahal)
        {
            return View("DisplayStatistics", context1.getStatistics(id_Manahal));
        }
    }
    public class DisplayAllStatisticsViewComponent : ViewComponent
    {
        private readonly ImanahelRepository context1;
        public DisplayAllStatisticsViewComponent(ImanahelRepository context)
        {
            this.context1 = context;
        }
        public IViewComponentResult Invoke(List<Manahel> manahels)
        {
            return View("DisplayAllStatistics", context1.GetStatisticForManahalList(manahels));
        }
    }
    // get manahel for products
    public class GetManahal2ViewComponent : ViewComponent
    {
        private readonly ImanahelRepository context1;
        private readonly IUsersManhalRepositry contextuser;
        public GetManahal2ViewComponent(ImanahelRepository context, IUsersManhalRepositry contextuser)
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
            return View("GetManahal2", manahels);
        }
    }
}
