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

        [Display(Name = "كود المنحل"),Required]
        public string Ssn { get; set; }

        [Display(Name = "اسم المنحل"), Required]
        public string NickName { get; set; }

        [Display(Name = "الموقع"), Required]
        public string LocationName { get; set; }

        [Display(Name = "اسم الزهرة"), Required]
        public string FlowerName { get; set; }

        [Display(Name = "تاريخ الانشاء"), Required]
        public DateTime DateCreated { get; set; }

        [Display(Name = "اخر تعديل")]
        public DateTime DateUpdated { get; set; }

        [Display(Name = "صورة المنحل")]
        public virtual List<ImagesManahel> ImageManhals { get; set; }
        public virtual List<Khalias> Khaliases { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
