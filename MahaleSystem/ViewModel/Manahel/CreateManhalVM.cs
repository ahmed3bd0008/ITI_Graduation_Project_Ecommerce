using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Manahel
{
    public class CreateManhalVM
    {
        public Models.Manahel manahel { get; set; }

        [Required]
        public string AccountId { get; set; }

        [Display(Name = "Image File")]
        public IFormFile imageFile { get; set; }
    }
}
