using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Khalias
    {
        public int Id { get; set; }

        [Display(Name = "رقم الخلية"),Required]
        [Range(minimum:1,maximum:500)]
        public int Ssn { get; set; }

        [Display(Name = "مستوى الخلية"),Required]
        public string KhaliaLevel { get; set; }

        [Display(Name = "نوع الخلية"),Required]
        public string KhaliaType { get; set; }

        [Required]
        [Display(Name = "نوع الخشب")]
        public string Wood { get; set; }

        [Display(Name = "عدد البروايز"), Required]
        [Range(minimum:1,maximum:9)]
        public int PraweezCount { get; set; }

        [Display(Name = "الملاحظة")]
        public string Notes { get; set; }

        [ForeignKey("Manhal")]
        public int ManhalId { get; set; }
        public virtual Manahel Manhal { get; set; }
        public virtual Queue Queues { get; set; }
    }
}
