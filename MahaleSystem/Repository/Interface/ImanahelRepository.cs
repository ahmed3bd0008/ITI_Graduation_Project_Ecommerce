﻿using MahaleSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Interface
{
    public interface ImanahelRepository:IGenaricRepository<Manahel>
    {
        public Task<bool> Is_SSN_Exist(string ssn, string AccountID);
        public int AddImage(ImagesManahel item);
        public List<Khalias> GetKhaliases(int id_Manahal);
        public List<ImagesManahel> GetImages(int id_Manahal);
        public Manahel GetManahelsTest(int id);
        public List<Manahel> GetAllManahelsTest();
        public List<Manahel> GetAllManahelsMenuTest();
    }
}
