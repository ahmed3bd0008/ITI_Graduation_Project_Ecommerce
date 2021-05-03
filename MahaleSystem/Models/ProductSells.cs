using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class ProductSells
    {
        public int Id { get; set; }

        [Display(Name ="اسم المنتج"),Required]
        public string PrioductName { get; set; }

        [Display(Name="اسم المنتج"),Required]
        public int ProductAmount { get; set; }

        [Display(Name = "السعر"),Required]
        public int Price { get; set; }

        [Display(Name = "تاريخ البيع"),Required]
        public DateTime dateSell { get; set; }

        [Display(Name = "الملاحظة")]
        public string Notes { get; set; }

        [ForeignKey("product")]
        public int? ProdcutID { get; set; }
        public virtual Product product { get; set; }
    }
}
