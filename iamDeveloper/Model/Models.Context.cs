﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iamDeveloper.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iamDeveloperEntities1 : DbContext
    {
        public iamDeveloperEntities1()
            : base("name=iamDeveloperEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_AcountCategory> tbl_AcountCategory { get; set; }
        public virtual DbSet<tbl_Specialty> tbl_Specialty { get; set; }
        public virtual DbSet<tbl_SpeciflyCategory> tbl_SpeciflyCategory { get; set; }
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }
    }
}