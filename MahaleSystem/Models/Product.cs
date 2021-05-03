using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name="التاريخ")]
        public DateTime DatePick { get; set; }

        [Display(Name = "اسم الزهرة")]
        public string FlowerName { get; set; }

        [Display(Name = "اسم المنتج")]
        public string ProductName { get; set; }

        [Display(Name = "وصف المنتج")]
        public string Description { get; set; }

        [Display(Name = "الكمية")]
        public int ProductAmount { get; set; }

        [Display(Name = "الوعاء")]
        public string Containter { get; set; }
        [ForeignKey("Manhal")]
        public int? ManhalId { get; set; }
        public virtual Manahel Manhal { get; set; }
        public virtual List<ImagesProduct> ImageProducts { get; set; }
        public virtual List<ProductSells> ProductSell { get; set; }
        public virtual List<ProductPublish> ProductPublishs { get; set; }
    }
}
  