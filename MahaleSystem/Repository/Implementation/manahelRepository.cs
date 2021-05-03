using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using MahaleSystem.ViewModel.Manahel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Implementation
{
    public class manahelRepository:GenaricRepository<Manahel>, ImanahelRepository
    {
        private readonly ManahelContext context;
        private readonly DbSet<Manahel> entities;
        public manahelRepository(ManahelContext _context):base(_context)
        {
            context = _context;
            entities = context.Set<Manahel>();
        }
        public async Task<bool> Is_SSN_Exist(string ssn,string AccountID)
        {
            var userManhal = await context.UsersManhals.Where(a => a.UserId == AccountID).ToListAsync();
            foreach (var item in userManhal)
            {
                var manahl = entities.Where(a => a.Id == item.ManelId).Where(b => b.Ssn == ssn).FirstOrDefault();
                if (manahl != null)
                    return true;
            }
            return false;
        }
        public List<Manahel> GetAllManahel()
        {
            return context.Manahels.Include(x => x.ImageManhals).ToList();
        }
        public Khalias AddKhalia(Khalias item)
        {
            context.khaliases.Add(item);
            context.SaveChanges();
            return context.khaliases.ToList().Last();
        }
        public Queue AddQueue(Queue item)
        {
            context.Queues.Add(item);
            context.SaveChanges();
            return item;
        }
        public bool Check_SSN_Khalia(int SSN, int id_manahal)
        {
            if (SSN > 500 || SSN < 1)
                return true;
            Khalias khalias = context.khaliases.Where(a => a.ManhalId == id_manahal)
                                .Where(b => b.Ssn == SSN).FirstOrDefault();
            if (khalias == null)
                return false;
            else
                return true;
        }
        public Khalias UpdateKhalia(Khalias item)
        {
            context.khaliases.Update(item);
            int x = context.SaveChanges();
            return item;
        }
        public Queue UpdateQueu(Queue item)
        {
            context.Queues.Update(item);
            context.SaveChanges();
            return item;
        }
        public bool DeleteKhalia(int id_Khalia)
        {
            Khalias khalias = getOneKhalia(id_Khalia);
            if (khalias != null)
            {
                Queue queue = context.Queues.Where(a => a.KhaliaId == id_Khalia).FirstOrDefault();
                if (queue != null)
                {
                    context.Queues.Remove(queue);
                    context.SaveChanges();
                }
                context.khaliases.Remove(khalias);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int AddImage(ImagesManahel item)
        {
            context.ImagesManahels.Add(item);
            return context.SaveChanges();
        }
        public List<Khalias> GetKhaliases(int id_Manahal)
        {
            Manahel manahel = entities.Find(id_Manahal);
            List<Khalias> khaliases = new List<Khalias>();
            if (manahel != null)
            {
                khaliases = context.khaliases.Where(a => a.ManhalId == id_Manahal)
                                              .Include(x => x.Queues).ToList();
            }
            return khaliases;
        }
        public Khalias getOneKhalia(int id_Khalia)
        {
            return context.khaliases.Where(a => a.Id == id_Khalia).Include(x => x.Queues).FirstOrDefault();
        }
        public List<ImagesManahel> GetImages(int id_Manahal)
        {
            return context.ImagesManahels.Where(a => a.ManahelId == id_Manahal).ToList();
        }
        public List<InfoVM> calcKhalaiaLevel(int id_manahal)
        {
            int level1 = 0, level2 = 0, level3 = 0, level4 = 0;
            var khalia = context.khaliases.Where(a => a.ManhalId == id_manahal);
            foreach (var item in khalia)
            {
                try
                {
                    if (item.KhaliaLevel == "ممتاز")
                        level1++;
                    else if (item.KhaliaLevel == "قوي")
                        level2++;
                    else if (item.KhaliaLevel == "جيد")
                        level3++;
                    else if (item.KhaliaLevel == "ضعيف")
                        level4++;
                }
                catch { }
            }
            return new List<InfoVM>()
            {
                new InfoVM() {name = "الخلايا الممتازة", value = level1 },
                new InfoVM() {name = "الخلايا القوية", value = level2 },
                new InfoVM() {name = "الخلايا الجيدة", value = level3 },
                new InfoVM() {name = "الخلايا الضعيفة", value = level4 },
            };
        }
        public List<InfoVM> calcKhalaiaType(int id_manahal)
        {
            int level1 = 0, level2 = 0, level3 = 0, all = 0 ;
            var khalia = context.khaliases.Where(a => a.ManhalId == id_manahal);
            foreach (var item in khalia)
            {
                try
                {
                    if (item.KhaliaType == "كاملة")
                        level1++;
                    else if (item.KhaliaType == "طرد")
                        level2++;
                    else if (item.KhaliaType == "نوية")
                        level3++;
                }
                catch { }
            }
            all = level1 + level2 + level3;
            return new List<InfoVM>()
            {
                new InfoVM() {name = "كل الخلايا", value = all },
                new InfoVM() {name = "الخلايا الكاملة", value = level1 },
                new InfoVM() {name = "عدد الطرود", value = level2 },
                new InfoVM() {name = "عدد النوية", value = level3 },
            };
            //return new Tuple<int, int, int>(level1, level2, level3);

        }
        public List<InfoVM> calcQueenStatus(int id_manahal)
        {
            int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0;
            var queueus = context.khaliases.Where(a => a.ManhalId == id_manahal).Select(x => x.Queues).ToList();
            foreach (var item in queueus)
            {
                if (item != null)
                {
                    try
                    {
                        if (item.QueueStatus == "ملقحة")
                            counter1++;
                        else if (item.QueueStatus == "عذراء")
                            counter2++;
                        else if (item.QueueStatus == "مكدبة")
                            counter3++;
                        else if (item.QueueStatus == "بدون ملكة")
                            counter4++;
                    }
                    catch { }
                }
                else
                    counter4++;
            }
            return new List<InfoVM>()
            {
                new InfoVM() {name = "الملكات الملقحة", value = counter1 },
                new InfoVM() {name = "الملكات العذراء", value = counter2 },
                new InfoVM() {name = "الملكات المكدبة", value = counter3 },
                new InfoVM() {name = "بدون ملكة", value = counter4 },
            };
            //return new Tuple<int, int, int, int>(counter1, counter2, counter3, counter4);
        }
        public Tuple<List<InfoVM>[],int> getStatistics(int id_manahal)
        {
            List<InfoVM>[] arr = new List<InfoVM>[3];
            arr[0] = calcKhalaiaType(id_manahal);
            arr[1] = calcKhalaiaLevel(id_manahal);
            arr[2] = calcQueenStatus(id_manahal);
            int degree = 0, max = 0 ;
            for (int i = 0; i < 3; i++)
            {
                int c = 4;
                foreach (var item in arr[i])
                {
                    degree += (item.value * c);
                    c--;
                    max += item.value * 4;
                }
            }
            try
            {
                degree = (degree * 100) / max;
            }
            catch { }
            return new Tuple<List<InfoVM>[], int>(arr, degree);
        }
        public int GetKhlaiaStatistics(int id_khalia)
        {
            var khalia = context.khaliases.Where(a => a.Id == id_khalia).FirstOrDefault();
            int max = 12;// 4 Level + 4 Type + 4 QueueStatus
            if (khalia != null)
            {
                int statistic = 0;
                switch (khalia.KhaliaLevel)
                {
                    case "Excellent":
                        statistic += 4;
                        break;
                    case "Strong":
                        statistic += 3;
                        break;
                    case "Good":
                        statistic += 2;
                        break;
                    case "Weak":
                        statistic += 1;
                        break;
                    default:
                        break;
                }
                switch (khalia.KhaliaType)
                {
                    case "Complete":
                        statistic += 4;
                        break;
                    case "Medium":
                        statistic += 3;
                        break;
                    case "Small":
                        statistic += 2;
                        break;
                    default:
                        break;
                }
                switch (khalia.Queues.QueueStatus)
                {
                    case "Fertilized":
                        int dateFert = khalia.Queues.DateFertilization.Value.Year;
                        int dateNow = DateTime.Now.Year;
                        if ((dateNow - dateFert) < 2)
                            statistic += 4;
                        else
                            statistic += 3;
                        break;
                    case "Not Fertilized":
                        statistic += 2;
                        break;
                    case "Stacked":
                    case "Without Queue":
                        statistic += 1;
                        break;
                    default:
                        break;
                }
                statistic = (statistic * 100) / max;
                return statistic;
            }
            return 0;
        }
        public Tuple<List<InfoVM>[], int> GetStatisticForManahalList(List<Manahel> manahels)
        {
            int ManhalCount = manahels.Count;
            int average = 0, parcent = 0 ; List<InfoVM>[] t = Initial();
            int kL1 = 0, kL2 = 0, kL3 = 0, kL4 = 0;
            int kT1 = 0, kT2 = 0, kT3 = 0, kT4 = 0;
            int kQ1 = 0, kQ2 = 0, kQ3 = 0, kQ4 = 0;
            for (int i = 0; i < manahels.Count; i++)
            {
                try
                {
                    Tuple<List<InfoVM>[], int> tuple = getStatistics(manahels[i].Id);
                    average += tuple.Item2;
                    kT4 += tuple.Item1[0][0].value;
                    kT1 += tuple.Item1[0][1].value;
                    kT2 += tuple.Item1[0][2].value;
                    kT3 += tuple.Item1[0][3].value;

                    kL1 += tuple.Item1[1][0].value;
                    kL2 += tuple.Item1[1][1].value;
                    kL3 += tuple.Item1[1][2].value;
                    kL4 += tuple.Item1[1][3].value;


                    kQ1 += tuple.Item1[2][0].value;
                    kQ2 += tuple.Item1[2][1].value;
                    kQ3 += tuple.Item1[2][2].value;
                    kQ4 += tuple.Item1[2][3].value;
                }
                catch { }
            }
            try
            {
                t[0][0].value = kT4 /*/ ManhalCount*/;
                t[0][1].value = kT1 /*/ ManhalCount*/;
                t[0][2].value = kT2 /*/ ManhalCount*/;
                t[0][3].value = kT3 /*/ ManhalCount*/;

                t[1][0].value = kL1 /*/ ManhalCount*/;
                t[1][1].value = kL2 /*/ ManhalCount*/;
                t[1][2].value = kL3/* / ManhalCount*/;
                t[1][3].value = kL4 /*/ ManhalCount*/;


                t[2][0].value = kQ1 /*/ ManhalCount*/;
                t[2][1].value = kQ2 /*/ ManhalCount*/;
                t[2][2].value = kQ3 /*/ ManhalCount*/;
                t[2][3].value = kQ4 /*/ ManhalCount*/;
                parcent = average / ManhalCount;
            }
            catch { }
            return new Tuple<List<InfoVM>[], int>(t, parcent);
        }

        public List<InfoVM>[] Initial()
        {
            List<InfoVM>[] t = new List<InfoVM>[3];
            var t1= new List<InfoVM>()
            {
                new InfoVM() {name = "كل الخلايا", value = 0 },
                new InfoVM() {name = "الخلايا الكاملة", value = 0 },
                new InfoVM() {name = "الخلايا الطرود", value = 0 },
                new InfoVM() {name = "الخلايا النوية", value = 0 },
            };
            var t2= new List<InfoVM>()
            {
                new InfoVM() {name = "الخلايا الممتازة", value = 0 },
                new InfoVM() {name = "الخلايا القوية", value = 0 },
                new InfoVM() {name = "الخلايا الجيدة", value = 0 },
                new InfoVM() {name = "الخلايا الضعيفة", value = 0 },
            };
            
            var t3 = new List<InfoVM>()
            {
                new InfoVM() { name = "الملكات الملقحة", value = 0 },
                new InfoVM() {name = "الملكات العذراء", value = 0 },
                new InfoVM() {name = "الملكات المكدبة", value = 0 },
                new InfoVM() {name = "بدون ملكة", value = 0 },
            };
            t[0] = t1;
            t[1] = t2;
            t[2] = t3;

            return t;
        }

        //public List<Tuple<string, double>> GetKhaliaCount(int id_Manahal)
        //{

        //    return list2;
        //}
    }
   
}
