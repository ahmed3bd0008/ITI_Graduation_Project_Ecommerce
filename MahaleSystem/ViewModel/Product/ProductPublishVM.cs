using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Product
{
    public class ProductPublishVM
    {

        [Display(Name = "اسم المنتج"), Required]
        public string ProductName { get; set; }

        [Display(Name = "سعر المنتج"), Required]
        public string ProductPrice { get; set; }

        [Display(Name = "وصف المنتج"), Required]
        public string Description { get; set; }

        [Display(Name = "تاريخ ترويج المنتج"), Required]
        public DateTime datePublish { get; set; }
        public int? ProdcutID { get; set; }
    }
}
