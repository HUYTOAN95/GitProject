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
    
    public partial class tbl_HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_HoaDon()
        {
            this.tbl_ChitietHD = new HashSet<tbl_ChitietHD>();
        }
    
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public Nullable<int> TongTien { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> CaSo { get; set; }
        public Nullable<int> Tong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChitietHD> tbl_ChitietHD { get; set; }
        public virtual tbl_NhanVien tbl_NhanVien { get; set; }
    }
}