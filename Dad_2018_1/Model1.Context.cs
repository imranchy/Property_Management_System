﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dad_2018_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PropertyContextEntities : DbContext
    {
        public PropertyContextEntities()
            : base("name=PropertyContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertySales> PropertySales { get; set; }
        public virtual DbSet<PropertyType> PropertyType { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<SalesDetail> SalesDetail { get; set; }
    }
}