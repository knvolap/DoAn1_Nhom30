using Models.EF;
using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using QuanLyVanBan.Common;
using System.Net;

namespace QuanLyVanBan.Controllers
{
    public class VanBanDiController : BasicController
    {
        private DbContextVB db = new DbContextVB();
        // GET: VanBanDi

        public ActionResult Index(string searchString1, string searchString2, string searchString3, int page = 1, int pageSize = 5)
        {
            var dao = new VanBanDiDao();
            var session = (QuanLyVanBan.Common.UserLogin)Session[QuanLyVanBan.Common.CommonConstant.USER_SESSION];

            var model = dao.ListAllPaging(searchString1, searchString2, searchString3, page, pageSize, session.UserID);
            if (!string.IsNullOrEmpty(searchString1))
            {
                ViewBag.SearchString1 = searchString1;
            }
            else if (!string.IsNullOrEmpty(searchString2))
            {
                ViewBag.SearchString2 = searchString2;
            }
            else
            {
                ViewBag.SearchString3 = searchString3;
            }

            return View(model);
        }

        public ActionResult Resend()
        {
            return View();
        }

        public ActionResult Send()
        {
            return View();
        }

    }

}