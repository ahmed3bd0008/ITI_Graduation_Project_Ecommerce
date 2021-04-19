using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Implementation
{
    public class UsersManhalRepositry: GenaricRepository<UsersManhals>,IUsersManhalRepositry
    {
        private readonly ManahelContext context;
        public UsersManhalRepositry(ManahelContext _context):base(_context)
        {
            context = _context;
        }
    }
}
