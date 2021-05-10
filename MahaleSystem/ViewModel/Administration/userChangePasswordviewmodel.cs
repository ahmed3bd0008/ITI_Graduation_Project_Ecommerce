using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Administration
{
    public class userChangePasswordviewmodel
    {
        public String Id { get; set; }
        public String OldPassword { get; set; }
        public String NewPassword { get; set; }
        public String ConfarmnewPassword { get; set; }
    }
}
