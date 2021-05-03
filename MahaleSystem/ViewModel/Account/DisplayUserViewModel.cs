using MahaleSystem.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Account
{
    public class DisplayUserViewModel
    {
        public DisplayUserViewModel()
        {
            users = new();
            Roles=new();
        }
        public List<CustomIdentityuser> users { set; get; }
        public List< String >Roles { get; set; }
    }
}
