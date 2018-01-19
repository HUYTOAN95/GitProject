using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;

namespace WebSiteBanSach.Controllers
{
    public class SachController : Controller
    {
        //
        // GET: /SachMoiPartial/
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        public PartialViewResult SachMoiPartial()
        {
            var lstSachMoi = db.Sach.Take(3).ToList();
            return PartialView(lstSachMoi);
        }
        //Xem chi tiết
        public ViewResult XemChiTiet(int MaSach=0)
        {
            Sach sach = db.Sach.SingleOrDefault(n=>n.MaSach==MaSach);
            if (sach == null)
            { 
                //Trả về trang báo lỗi 
                Response.StatusCode = 404;
                return null;
            }
            //ChuDe cd = db.ChuDes.Single(n => n.MaChuDe == sach.MaChuDe);
            //ViewBag.TenCD = cd.TenChuDe;
            ViewBag.TenChuDe = db.ChuDe.Single(n => n.MaChuDe == sach.MaChuDe).TenChuDe;
            ViewBag.NhaXuatBan = db.NhaXuatBan.Single(n => n.MaNXB == sach.MaNXB).TenNXB;
            return View(sach);
        }
	}
}