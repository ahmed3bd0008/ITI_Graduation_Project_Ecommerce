using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Administration
{
    public class ClaimsUserViewModel
    {
        public ClaimsUserViewModel()
        {
            Claimsuser = new();
        }
      public List<CusrtomClaims> Claimsuser { set; get; }
        public String UserId { get; set; }
    }
}
