//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ChitietHD
    {
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> ThanhTien { get; set; }
        public Nullable<double> KhuyenMai { get; set; }
    
        public virtual tbl_HoaDon tbl_HoaDon { get; set; }
        public virtual tbl_ThucDon tbl_ThucDon { get; set; }
    }
}
