﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNETMvcCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblDeneyimler> TblDeneyimlers { get; set; }
        public virtual DbSet<TblEğitimlerim> TblEğitimlerim { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimdas { get; set; }
        public virtual DbSet<TblHobilerim> TblHobilerims { get; set; }
        public virtual DbSet<Tblİletisim> Tblİletisim { get; set; }
        public virtual DbSet<TblSertifikalarim> TblSertifikalarims { get; set; }
        public virtual DbSet<TblYetenekler> TblYeteneklers { get; set; }
        public virtual DbSet<TblSosyalMedya> TblSosyalMedyas { get; set; }
    }
}
