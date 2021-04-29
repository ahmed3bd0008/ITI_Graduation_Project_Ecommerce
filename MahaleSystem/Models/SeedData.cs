using MahaleSystem.Models.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Models
{
    public static class SeedData
    {
        public static void Initailizer(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomIdentityRole>().HasData(
                new CustomIdentityRole {Name="SuperAdmin"}
                );
            modelBuilder.Entity<CustomIdentityRole>().HasData(
              new CustomIdentityRole { Name = "Admin" }
              );

        }

    }
}
