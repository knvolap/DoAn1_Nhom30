using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class VanBanDiDao
    {
        DbContextVB db = null;
        public VanBanDiDao()
        {
            db = new DbContextVB();
        }

      
    }
}
