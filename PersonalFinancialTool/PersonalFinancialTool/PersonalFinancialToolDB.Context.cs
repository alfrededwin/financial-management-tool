﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalFinancialTool
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonalFinancialToolDBContainer1 : DbContext
    {
        public PersonalFinancialToolDBContainer1()
            : base("name=PersonalFinancialToolDBContainer1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
