using DhruviBookStore.DataAccess.Repository.IRepository;
using DhruviBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DhruviBookStore.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        //modidfying database with db context
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }
    }
}
