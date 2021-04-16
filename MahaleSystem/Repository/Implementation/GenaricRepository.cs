using MahaleSystem.Models;
using MahaleSystem.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Implementation
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : class
    {
        private readonly ManahelContext _context;
        private readonly DbSet<T> _entities;
        public GenaricRepository(ManahelContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public T Add(T item)
        {
            _entities.Add(item);
            return item;
        }

        public T Delete(int id)
        {
            var item = _entities.Find(id);
            _entities.Remove(item);
            return item;
        }

        public List<T> GetAll()
        {
           return _entities.ToList();
        }

        public List<T> GetAllBy(Expression<Func<T, bool>> filter)
        {
           return _entities.Where(filter).ToList();
        }

        public T GetElement(int id)
        {
            return _entities.Find(id);
        }

        public bool IsExist(Expression<Func<T, bool>> filter)
        {
            return _entities.Any(filter);
        }

        public int Savechange()
        {
          return  _context.SaveChanges();
        }

        public T Updata(T item)
        {
            _entities.Update(item);
            return item;
        }
    }
}
