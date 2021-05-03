using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Account
{
    public class AddUserViewModel:Image
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="password not matched")]
        public String ConfirmPassword { get; set; }
        [Required]
        public String Phone { get; set; }
        public IFormFile formFile;
    }
}
