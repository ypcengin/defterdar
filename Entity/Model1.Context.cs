﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCRAPP.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class E_TICARET_MAGAZAEntities : DbContext
    {
        public E_TICARET_MAGAZAEntities()
            : base("name=E_TICARET_MAGAZAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KATEGORI> KATEGORI { get; set; }
        public virtual DbSet<MUSTERI> MUSTERI { get; set; }
        public virtual DbSet<PERSONEL> PERSONEL { get; set; }
        public virtual DbSet<SATIS> SATIS { get; set; }
        public virtual DbSet<URUN> URUN { get; set; }
        public virtual DbSet<KULLANICI> KULLANICI { get; set; }
    }
}