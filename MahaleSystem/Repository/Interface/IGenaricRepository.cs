using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MahaleSystem.Repository.Interface
{
    public interface IGenaricRepository<T> 
    {
        public  T Add(T item);
        public T Updata(T item);
        public T Delete(int id);
        public List< T> GetAll();
        public List<T> GetAllBy(Expression<Func<T, bool>> filter);
        public T GetElement(int id);
        public bool IsExist(Expression<Func<T, bool>> filter);
        public int Savechange();
    }
}
