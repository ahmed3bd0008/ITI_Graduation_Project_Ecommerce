using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public class Khalias
    {
        public int Id { get; set; }
        public int Ssn { get; set; }
        public string KhaliaLevel { get; set; }
        public string KhaliaType { get; set; }
        public string Wood { get; set; }
        public int PraweezCount { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Manhal")]
        public int ManhalId { get; set; }
        public virtual Manahel Manhal { get; set; }
        public virtual Queue Queues { get; set; }
    }
}
