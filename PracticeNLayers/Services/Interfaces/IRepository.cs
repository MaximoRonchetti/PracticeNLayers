using Microsoft.EntityFrameworkCore.Storage;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public void Add(T entity);
        public T Update(T entity);
        public IEnumerable<T> GetAll();
        public void Delete(T entity);
        public IEnumerable<T> Query(Expression<Func<T, bool>> filter);



    }
}
