//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteBanSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_NhanVien
    {
        public tbl_NhanVien()
        {
            this.tbl_PhieuMuonTra = new HashSet<tbl_PhieuMuonTra>();
            this.tbl_TaiKhoan = new HashSet<tbl_TaiKhoan>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
    
        public virtual ICollection<tbl_PhieuMuonTra> tbl_PhieuMuonTra { get; set; }
        public virtual ICollection<tbl_TaiKhoan> tbl_TaiKhoan { get; set; }
    }
}
