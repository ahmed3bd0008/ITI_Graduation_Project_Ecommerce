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
        public List<Tuple<string,string>> GetUsers()
        {
            var res = (from x in context.Users select new { x.Id, x.UserName }).ToList();
            List<Tuple<string, string>> tuples = new List<Tuple<string, string>>();
            foreach (var item in res)
            {
                tuples.Add(new Tuple<string, string>(item.Id, item.UserName));
            }
            return tuples;
        }
    }
}
