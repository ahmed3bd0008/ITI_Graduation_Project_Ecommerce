using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Administration
{
    public static class ConfigClaims
    {
        public static List<Claim> GetAllClaims()
        {
            return Claims;
        }
            private static readonly List<Claim> Claims = new()
            {
                new Claim("AddManhale", "AddManhale"),
                new Claim("EditManhale", "EditManhale"),
                new Claim("DeleteManhale", "DeleteManhale"),
                new Claim("AddProduct", "AddProduct"),
                new Claim("EditProduct", "EditProduct"),
                new Claim("DeleteProduct", "DeleteProduct"),
                new Claim("AddUser", "AddUser"),
                new Claim("EditUser", "EditUser"),
                new Claim("DeleteUser", "DeleteUser"),
                new Claim("MangeClaims", "MangeClaims")

            };
       
    }
}

