﻿using System;
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

        [Display(Name = "SSN"),Required]
        [Range(minimum:1,maximum:500)]
        public int Ssn { get; set; }

        [Display(Name = "Khalia Level"),Required]
        public string KhaliaLevel { get; set; }

        [Display(Name = "Khalia Type"),Required]
        public string KhaliaType { get; set; }

        [Required]
        public string Wood { get; set; }

        [Display(Name = "Praweez Count"), Required]
        [Range(minimum:1,maximum:9)]
        public int PraweezCount { get; set; }

        public string Notes { get; set; }

        [ForeignKey("Manhal")]
        public int ManhalId { get; set; }
        public virtual Manahel Manhal { get; set; }
        public virtual Queue Queues { get; set; }
    }
}
