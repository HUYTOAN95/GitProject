﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoffeManagerProjectEntities : DbContext
    {
        public CoffeManagerProjectEntities()
            : base("name=CoffeManagerProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ChitietHD> tbl_ChitietHD { get; set; }
        public virtual DbSet<tbl_HoaDon> tbl_HoaDon { get; set; }
        public virtual DbSet<tbl_NgSD> tbl_NgSD { get; set; }
        public virtual DbSet<tbl_NhanVien> tbl_NhanVien { get; set; }
        public virtual DbSet<tbl_ThucDon> tbl_ThucDon { get; set; }
    }
}
