using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MahaleSystem.ViewModel.Manahel
{
    public class AddImageVM
    {
        public int? id { get; set; }
        
        [Display(Name="Image File"),Required]
        public IFormFile imageFile { get; set; }
    }
}
