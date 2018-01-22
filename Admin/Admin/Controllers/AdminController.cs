using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Models;

namespace Admin.Controllers
{
    public class AdminController : Controller
    {
        CoffeManagerProjectEntities db = new CoffeManagerProjectEntities();
        // GET: /Admin/
        public ActionResult Index()
        {  
            return View(db.tbl_NgSD.ToList());
        }
        [HttpGet]
        public ActionResult ThemMoi()
        {
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaNV = new SelectList(db.tbl_NhanVien.ToList().OrderBy(n => n.MaNV), "MaNV", "MaNV");
            var types = new List<SelectListItem>();
            types.Add(new SelectListItem() { Text = "Admin", Value = "0" });
            types.Add(new SelectListItem() { Text = "User_1", Value = "1" });
            types.Add(new SelectListItem() { Text = "User_2", Value = "2" });
            types.Add(new SelectListItem() { Text = "User_3", Value = "3" });
            ViewBag.QuyenTruyCap = types;
            ViewBag.QuyenTruyCap = types;
            ViewBag.NgayDK = DateTime.Today;
            ViewBag.NgayHetHan = DateTime.Today.AddYears(2);
          ;
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(tbl_NgSD nsd, HttpPostedFileBase fileUpload)
        {


            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaNV = new SelectList(db.tbl_NhanVien.ToList().OrderBy(n => n.MaNV), "MaNV", "MaNV");
            var types = new List<SelectListItem>();
            types.Add(new SelectListItem() { Text = "Admin", Value = "0" });
            types.Add(new SelectListItem() { Text = "User_1", Value = "1" });
            types.Add(new SelectListItem() { Text = "User_2", Value = "2" });
            types.Add(new SelectListItem() { Text = "User_3", Value = "3" });
            ViewBag.QuyenTruyCap = types;
            ViewBag.NgayDK = DateTime.Today;
            ViewBag.NgayHetHan = DateTime.Today.AddYears(2);
            //kiểm tra đường dẫn ảnh bìa
           
                db.tbl_NgSD.Add(nsd);
                db.SaveChanges();
            
            //return View();
            return RedirectToAction("Index");
        }
        //Chỉnh sửa sản phẩm
        [HttpGet]
        public ActionResult ChinhSua(string TaiKhoan)
        {
            //Lấy ra đối tượng sách theo mã 
            tbl_NgSD nsd = db.tbl_NgSD.SingleOrDefault(n => n.TaiKhoan == TaiKhoan);
            if (nsd == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaNV = new SelectList(db.tbl_NhanVien.ToList().OrderBy(n => n.MaNV), "MaNV", "MaNV");
            var types = new List<SelectListItem>();
            types.Add(new SelectListItem() { Text = "Admin", Value = "0" });
            types.Add(new SelectListItem() { Text = "User_1", Value = "1" });
            types.Add(new SelectListItem() { Text = "User_2", Value = "2" });
            types.Add(new SelectListItem() { Text = "User_3", Value = "3" });
           
            return View(nsd);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(tbl_NgSD nsd, FormCollection f)
        {
            
            if (ModelState.IsValid)
            {
                //Thực hiện cập nhận trong model
                db.Entry(nsd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaNV = new SelectList(db.tbl_NhanVien.ToList().OrderBy(n => n.MaNV), "MaNV", "MaNV");
            var types = new List<SelectListItem>();
            types.Add(new SelectListItem() { Text = "Admin", Value = "0" });
            types.Add(new SelectListItem() { Text = "User_1", Value = "1" });
            types.Add(new SelectListItem() { Text = "User_2", Value = "2" });
            types.Add(new SelectListItem() { Text = "User_3", Value = "3" });


            ViewBag.QuyenTruyCap = types;

            return RedirectToAction("Index");

        }
	}
}