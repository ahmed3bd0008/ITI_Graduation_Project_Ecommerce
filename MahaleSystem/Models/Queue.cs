using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Queue
    {
        public int Id { get; set; }

        [Display(Name="Queue Status")]
        public string QueueStatus { get; set; }

        [Display(Name = "Date Fertilization")]
        public DateTime? DateFertilization { get; set; }
        [ForeignKey("Khalia")]
        public int KhaliaId { get; set; }
        public virtual Khalias Khalia { get; set; }
    }
}
