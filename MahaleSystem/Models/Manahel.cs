using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Manahel
    {
        public int Id { get; set; }
        public string Ssn { get; set; }
        public string NickName { get; set; }
        public string LocationName { get; set; }
        public string FlowerName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        
        public virtual List<ImagesManahel> ImageManhals { get; set; }
        public virtual List<Khalias> Khaliases { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
