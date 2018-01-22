using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Models;

namespace Admin.Controllers
{
    public class LoginController : Controller
    {   
        //
        // GET: /Login/
        CoffeManagerProjectEntities db = new CoffeManagerProjectEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string sTaiKhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f.Get("txtMatKhau").ToString();
            tbl_NgSD nsd = db.tbl_NgSD.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhau == sMatKhau);
            if (nsd != null)
            {
                ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
                Session["TaiKhoan"] = nsd;
                return RedirectToAction("Index", "Admin");
            }
            ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
            return View();
        }
	}
}