﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyThuVienEntities : DbContext
    {
        public QuanLyThuVienEntities()
            : base("name=QuanLyThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ChiTietPhieuMuon> tbl_ChiTietPhieuMuon { get; set; }
        public virtual DbSet<tbl_DocGia> tbl_DocGia { get; set; }
        public virtual DbSet<tbl_LoaiSach> tbl_LoaiSach { get; set; }
        public virtual DbSet<tbl_NhanVien> tbl_NhanVien { get; set; }
        public virtual DbSet<tbl_NhaXB> tbl_NhaXB { get; set; }
        public virtual DbSet<tbl_PhieuMuonTra> tbl_PhieuMuonTra { get; set; }
        public virtual DbSet<tbl_Sach> tbl_Sach { get; set; }
        public virtual DbSet<tbl_TacGia> tbl_TacGia { get; set; }
        public virtual DbSet<tbl_TaiKhoan> tbl_TaiKhoan { get; set; }
        public virtual DbSet<tbl_ViTri> tbl_ViTri { get; set; }
    }
}
