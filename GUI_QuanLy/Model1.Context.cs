﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_Quanly
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quanlytiemsachEntities5 : DbContext
    {
        public quanlytiemsachEntities5()
            : base("name=quanlytiemsachEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<code> codes { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<sach> saches { get; set; }
        public virtual DbSet<sachduocmua> sachduocmuas { get; set; }
        public virtual DbSet<sachduocthue> sachduocthues { get; set; }
        public virtual DbSet<sachthuoctacgia> sachthuoctacgias { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<taikhoan> taikhoans { get; set; }
    }
}
