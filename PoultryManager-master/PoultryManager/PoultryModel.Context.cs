﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoultryManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoultryEntities : DbContext
    {
        public PoultryEntities()
            : base("name=PoultryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Egg> Eggs { get; set; }
        public virtual DbSet<Feeding> Feedings { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
    }
}