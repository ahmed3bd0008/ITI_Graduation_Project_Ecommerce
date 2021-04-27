using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Manahel
{
    public class AddKhaliaVM
    {
        public int Id { get; set; }

        [Display(Name = "SSN"), Required]
        [Range(minimum: 1, maximum: 500)]
        public int Ssn { get; set; }

        [Display(Name = "Khalia Level"), Required]
        public string KhaliaLevel { get; set; }

        [Display(Name = "Khalia Type"), Required]
        public string KhaliaType { get; set; }

        [Required]
        public string Wood { get; set; }

        [Display(Name = "Praweez Count"), Required]
        [Range(minimum: 1, maximum: 9)]
        public int PraweezCount { get; set; }

        public string Notes { get; set; }

        public int ManhalId { get; set; }

        [Display(Name = "Queen Status"), Required]
        public string QueueStatus { get; set; }

        [Display(Name = "Date Fertilization"), Required]
        public DateTime? DateFertilization { get; set; }
    }
}
