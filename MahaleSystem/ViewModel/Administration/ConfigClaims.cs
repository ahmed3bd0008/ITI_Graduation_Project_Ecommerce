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
                new Claim("AddManhale", "اضافه المنحل"),
                new Claim("EditManhale", "تعديل المنحل"),
                new Claim("DeleteManhale", "حذف المنحل"),
                new Claim("AddProduct", "أضافه المنتج"),
                new Claim("EditProduct", "تعديد المنتج"),
                new Claim("DeleteProduct", "حذف المنتج"),
                new Claim("AddUser", "اضافه مستخدم"),
                new Claim("EditUser", "تعديل المستخدم"),
                new Claim("DeleteUser", "حذف المستخدم"),
                new Claim("MangeClaims", "أضافه الصلاحيات")

            };
       
    }
}

