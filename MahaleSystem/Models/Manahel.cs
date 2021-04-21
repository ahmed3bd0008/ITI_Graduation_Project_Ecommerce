using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Manahel
    {
        public int Id { get; set; }

        [Display(Name = "SSN"),Required]
        public string Ssn { get; set; }

        [Display(Name = "Manahal Name"), Required]
        public string NickName { get; set; }

        [Display(Name = "Location Name"), Required]
        public string LocationName { get; set; }

        [Display(Name = "Flower Name"), Required]
        public string FlowerName { get; set; }

        [Display(Name = "Date Created"), Required]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Last Updated")]
        public DateTime DateUpdated { get; set; }
        
        public virtual List<ImagesManahel> ImageManhals { get; set; }
        public virtual List<Khalias> Khaliases { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
