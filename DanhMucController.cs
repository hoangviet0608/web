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
        DataClasses1DataContext db = new DataClasses1DataContext("Data Source=DESKTOP-0746MOR;Initial Catalog=qlbh1;Integrated Security=True;TrustServerCertificate=True");

        // GET: DanhMuc
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetCategories()
        {
            var ketqua = "goi thanh cong";
            return Json(ketqua, JsonRequestBehavior.AllowGet);
        }
    }
}