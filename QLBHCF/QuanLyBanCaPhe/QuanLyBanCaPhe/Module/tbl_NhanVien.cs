//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanCaPhe.Module
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_NhanVien
    {
        public tbl_NhanVien()
        {
            this.tbl_HoaDon = new HashSet<tbl_HoaDon>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    
        public virtual ICollection<tbl_HoaDon> tbl_HoaDon { get; set; }
    }
}
