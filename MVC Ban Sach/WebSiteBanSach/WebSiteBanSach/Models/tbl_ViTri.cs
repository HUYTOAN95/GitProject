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
    
    public partial class tbl_ViTri
    {
        public tbl_ViTri()
        {
            this.tbl_Sach = new HashSet<tbl_Sach>();
        }
    
        public string MaViTri { get; set; }
        public string TenViTri { get; set; }
    
        public virtual ICollection<tbl_Sach> tbl_Sach { get; set; }
    }
}