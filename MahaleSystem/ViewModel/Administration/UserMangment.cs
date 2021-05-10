using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Administration
{
    public class UserMangment
    {
        public UserMangment()
        {
            Claims = new();
        }
        public String Id { get; set; }
        public string UserName { get; set; }
        public String  Roles { get; set; }
        public List<string> Claims { get; set; }
    }
}
