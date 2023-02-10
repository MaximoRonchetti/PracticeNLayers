using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Models.Data;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class

    {
        //protected DbSet<T> _objectSet;
        protected PracticeNLayersContext _context;
        public RepositoryBase(PracticeNLayersContext context)
        {
            //_objectSet = context.Set<T>();
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }



        public T Update(T entity)
        {
            var obj = _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return obj.Entity;
        }
    }
}
