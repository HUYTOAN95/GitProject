//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeWFP
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_LoaiSach
    {
        public tbl_LoaiSach()
        {
            this.tbl_Sach = new HashSet<tbl_Sach>();
        }
    
        public int MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }
    
        public virtual ICollection<tbl_Sach> tbl_Sach { get; set; }
    }
}
