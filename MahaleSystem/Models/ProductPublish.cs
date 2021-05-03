using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class ProductPublish
    {
        public int Id { get; set; }

        [Display(Name = "اسم المنتج"), Required]
        public string ProductName { get; set; }

        [Display(Name = "سعر المنتج"), Required]
        public string ProductPrice { get; set; }

        [Display(Name = "وصف المنتج"), Required]
        public string Description { get; set; }

        [Display(Name = "تاريخ ترويج المنتج"), Required]
        public DateTime datePublish { get; set; }

        [ForeignKey("product")]
        public int? ProdcutID { get; set; }
        public virtual Product product { get; set; }

    }
}
