using DhruviBookStore.DataAccess.Repository.IRepository;
using DhruviBookStore.Models;
using DhruviBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DhruviBookStore.DataAccess.Repository
{
   public class CoverType
    {
        private readonly ApplicationDbContext _db;
        public CoverType(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverType.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = CoverType.Name;
                _db.SaveChanges();
            }
        }
    }
}
