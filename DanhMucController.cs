
using QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBH.Controllers
{
    public class DanhMucController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext("Data Source=VIET;Initial Catalog=QLBH;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        // GET: DanhMuc
        public ActionResult Index()
        {
            var x = db.DanhMucs.ToList();
            return View(x);
        }

        [HttpPost]
        public JsonResult GetListDanhMuc()
        {
            var tableBody = db.DanhMucs.Select(c => new
            {
                c.id,
                c.TenDanhMuc,
                c.MoTa,
                c.idDanhMucCha
            }).ToList();

            return Json(tableBody, JsonRequestBehavior.AllowGet);
        }
    }
}
