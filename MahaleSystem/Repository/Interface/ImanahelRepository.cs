using MahaleSystem.Models;
using MahaleSystem.ViewModel.Manahel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Interface
{
    public interface ImanahelRepository:IGenaricRepository<Manahel>
    {
        public Task<bool> Is_SSN_Exist(string ssn, string AccountID);
        public List<Manahel> GetAllManahel();
        public Khalias AddKhalia(Khalias item);
        public Queue AddQueue(Queue item);
        public bool Check_SSN_Khalia(int SSN, int id_manahal);
        public Khalias UpdateKhalia(Khalias item);
        public Queue UpdateQueu(Queue item);
        public bool DeleteKhalia(int id_Khalia);
        public int AddImage(ImagesManahel item);
        public List<Khalias> GetKhaliases(int id_Manahal);
        public List<Khalias> SearchQS(int id_Manahal, string txtSearch);
        public Khalias getOneKhalia(int id_Khalia);
        public List<ImagesManahel> GetImages(int id_Manahal);
        public List<InfoVM> calcKhalaiaLevel(int id_manahal);
        public List<InfoVM> calcKhalaiaType(int id_manahal);
        public List<InfoVM> calcQueenStatus(int id_manahal);
        public Tuple<List<InfoVM>[], int> getStatistics(int id_manahal);
        public int GetKhlaiaStatistics(int id_khalia);
        public Tuple<List<InfoVM>[], int> GetStatisticForManahalList(List<Manahel> manahels);
        public void DeleteImage(int idImg);
        public void DeleteManhalImages(int idManhal);
    }
}
