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

        [Display(Name = "SSN")]
        public int Ssn { get; set; }

        [Display(Name = "Khalia Level")]
        public string KhaliaLevel { get; set; }

        [Display(Name = "Khalia Type")]
        public string KhaliaType { get; set; }
        public string Wood { get; set; }

        [Display(Name = "Praweez Count")]
        public int PraweezCount { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Manhal")]
        public int ManhalId { get; set; }
        public virtual Manahel Manhal { get; set; }
        public virtual Queue Queues { get; set; }
    }
}
