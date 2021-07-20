using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;


namespace Models.DAO
{
    public class VanBanDenDao
    {
        DbContextVB db = null;
        public VanBanDenDao()
        {
            db = new DbContextVB();
        }

        //Phân trang
        public IEnumerable<VanBanDen> ListAllPaging(string searchString1, string searchString2, string searchString3, int page, int pageSize, string userID)
        {
            IQueryable<VanBanDen> model = db.VanBanDens;
            if (!string.IsNullOrEmpty(searchString1))
            {
                model = model.Where(x => x.TieuDe.Contains(searchString1));
            }
            else if (!string.IsNullOrEmpty(searchString2))
            {
                model = model.Where(x => x.KyHieuVanBanDen.Contains(searchString2));
            }
            else if (!string.IsNullOrEmpty(searchString3))
            {
                model = model.Where(x => x.NgayGui.ToString() == searchString3);
            }

            return model.Where(x => x.IDNhanVien == userID).OrderByDescending(x => x.NgayGui).ToPagedList(page, pageSize);
        }






    }
}
