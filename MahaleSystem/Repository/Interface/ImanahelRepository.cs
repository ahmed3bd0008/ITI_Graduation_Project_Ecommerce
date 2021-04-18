using MahaleSystem.Models;
using System.Collections.Generic;

namespace MahaleSystem.Repository.Interface
{
    public interface ImanahelRepository:IGenaricRepository<Manahel>
    {
        public bool Is_SSN_Exist(string ssn, string AccountID);
        public Manahel GetManahelsTest(int id);
        public List<Manahel> GetAllManahelsTest();
        public List<Manahel> GetAllManahelsMenuTest();
    }
}
