﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homecare.Models.DataModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HomecareTestDB : DbContext
    {
        public HomecareTestDB()
            : base("name=HomecareTestDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Caretaker> Caretakers { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<RouteDetail> RouteDetails { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_Rights> User_Rights { get; set; }
    }
}
