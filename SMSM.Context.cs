﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sales_Management_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_sales_management_systemEntities : DbContext
    {
        public DB_sales_management_systemEntities()
            : base("name=DB_sales_management_systemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_cat> TB_cat { get; set; }
        public virtual DbSet<TB_Supp> TB_Supp { get; set; }
        public virtual DbSet<TB_Pur> TB_Pur { get; set; }
        public virtual DbSet<TB_Cust> TB_Cust { get; set; }
        public virtual DbSet<TB_Sell> TB_Sell { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
    }
}
