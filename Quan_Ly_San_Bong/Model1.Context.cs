﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_San_Bong
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Management_FootballPitchEntities : DbContext
    {
        public Management_FootballPitchEntities()
            : base("name=Management_FootballPitchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Deposit_Invoice> Deposit_Invoice { get; set; }
        public virtual DbSet<Football_Pitch> Football_Pitch { get; set; }
        public virtual DbSet<Football_Pitch_State_By_Time> Football_Pitch_State_By_Time { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Time_Slot> Time_Slot { get; set; }
        public virtual DbSet<User_Info> User_Info { get; set; }
    }
}