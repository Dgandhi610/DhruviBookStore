using System;
using System.Collections.Generic;
using System.Text;

namespace DhruviBookStore.DataAccess.Repository.IRepository
{
   public interface ICoverType: IRepository<CoverType> 
    {
        void Update(CoverType coverType);

    }
}
