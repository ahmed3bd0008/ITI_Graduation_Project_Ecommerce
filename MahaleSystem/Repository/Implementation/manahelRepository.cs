using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
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
        public List<Manahel> manahels = new List<Manahel>()
        {
            new Manahel(){Ssn="A",DateCreated=DateTime.Now,DateUpdated=DateTime.Now,FlowerName="flower1"
                            ,Id=1,LocationName="location1",NickName="man1"},
            new Manahel(){Ssn="B",DateCreated=DateTime.Now,DateUpdated=DateTime.Now,FlowerName="flower2"
                            ,Id=2,LocationName="location2",NickName="man2"},
            new Manahel(){Ssn="C",DateCreated=DateTime.Now,DateUpdated=DateTime.Now,FlowerName="flower3"
                            ,Id=3,LocationName="location3",NickName="man3"},
            new Manahel(){Ssn="D",DateCreated=DateTime.Now,DateUpdated=DateTime.Now,FlowerName="flower4"
                            ,Id=4,LocationName="location4",NickName="man4"},
            new Manahel(){Ssn="E",DateCreated=DateTime.Now,DateUpdated=DateTime.Now,FlowerName="flower5"
                            ,Id=5,LocationName="location5",NickName="man5"},
        };
        List<Manahel> mansMenu = new List<Manahel>();
        public manahelRepository(ManahelContext _context):base(_context)
        {
            context = _context;
            entities = context.Set<Manahel>();
        }

        public bool Is_SSN_Exist(string ssn,string AccountID)
        {
            var userManhal = context.UsersManhals.Where(a => a.UserId == AccountID);
            foreach (var item in userManhal)
            {
                var manahl = entities.Where(a => a.Id == item.ManelId).Where(b => b.Ssn == ssn).FirstOrDefault();
                if (manahl != null)
                    return false;
            }
            return true;
        }

        public List<Manahel> GetAllManahelsTest()
        {
            mansMenu.AddRange(manahels);
            mansMenu.AddRange(mansMenu);
            mansMenu.AddRange(mansMenu);
            return mansMenu;
        }
        public Manahel GetManahelsTest(int id)
        {
            return manahels.Find(a => a.Id == id);
        }
        public List<Manahel> GetAllManahelsMenuTest()
        {
            return manahels;
        }
    }
   
}
