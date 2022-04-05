using DhruviBookStore.DataAccess.Repository.IRepository;
using DhruviBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DhruviBookStore.DataAccess.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db, SP_Class SP_Class)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Class(_db);
        }
public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
