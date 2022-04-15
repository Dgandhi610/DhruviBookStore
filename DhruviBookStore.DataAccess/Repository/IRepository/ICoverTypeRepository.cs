using System;
using System.Collections.Generic;
using System.Text;

namespace DhruviBookStore.DataAccess.Repository.IRepository
{
   public interface ICoverTypeRepository: IRepository<CoverTypeRepository> 
    {
        void Update(CoverTypeRepository coverType);

    }
}
