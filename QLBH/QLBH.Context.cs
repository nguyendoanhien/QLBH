﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
    
        public virtual DbSet<KH> KHs { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<NV> NVs { get; set; }
        public virtual DbSet<Phieu> Phieux { get; set; }
        public virtual DbSet<PhieuGiao> PhieuGiaos { get; set; }
        public virtual DbSet<PhieuHD> PhieuHDs { get; set; }
        public virtual DbSet<PhieuHDChiTiet> PhieuHDChiTiets { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public virtual DbSet<SP> SPs { get; set; }
        public virtual DbSet<SPLoai> SPLoais { get; set; }
        public virtual DbSet<SPNhom> SPNhoms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
