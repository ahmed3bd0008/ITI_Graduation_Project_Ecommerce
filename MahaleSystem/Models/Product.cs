using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime DatePick { get; set; }
        public string FlowerName { get; set; }
        public string ProductName { get; set; }
        public string ProductAmount { get; set; }
        [ForeignKey("Manhal")]
        public int? ManhalId { get; set; }
        public virtual Mnahel Manhal { get; set; }
    }
}
