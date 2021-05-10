using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Administration
{
    public class UserProfileviewmodel
    {
        public UserProfileviewmodel()
        {
            UserClaims = new();
        }
        public String Id { get; set; }
        public String UserName { get; set; }
        public List<String> UserClaims { get; set; }
    }
}
