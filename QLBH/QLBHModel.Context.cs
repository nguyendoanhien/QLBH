﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBH
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBHDBContext : DbContext
    {
        public QLBHDBContext()
            : base("name=QLBHDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<KH> KHs { get; set; }
        public DbSet<NCC> NCCs { get; set; }
        public DbSet<NV> NVs { get; set; }
        public DbSet<Phieu> Phieux { get; set; }
        public DbSet<PhieuGiao> PhieuGiaos { get; set; }
        public DbSet<PhieuHD> PhieuHDs { get; set; }
        public DbSet<PhieuHDChiTiet> PhieuHDChiTiets { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public DbSet<SP> SPs { get; set; }
        public DbSet<SPLoai> SPLoais { get; set; }
        public DbSet<SPNhom> SPNhoms { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}