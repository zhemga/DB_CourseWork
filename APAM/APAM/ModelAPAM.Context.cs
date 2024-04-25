﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APAM
{
    using APAM.Common;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class APAM_DBEntities : DbContext
    {
        public APAM_DBEntities()
            : base("APAM_DBEntities")
        {
            UserData.CheckRole(this);
            //DataSeeder.Seed(this);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<AdministratorContact> AdministratorContacts { get; set; }
        public virtual DbSet<AdministratorSalary> AdministratorSalaries { get; set; }
        public virtual DbSet<AdministratorType> AdministratorTypes { get; set; }
        public virtual DbSet<AutoPart> AutoParts { get; set; }
        public virtual DbSet<AutoPartCarModel> AutoPartCarModels { get; set; }
        public virtual DbSet<AutoPartCategory> AutoPartCategories { get; set; }
        public virtual DbSet<AutoPartManufacturer> AutoPartManufacturers { get; set; }
        public virtual DbSet<Bookkeeper> Bookkeepers { get; set; }
        public virtual DbSet<BookkeeperContact> BookkeeperContacts { get; set; }
        public virtual DbSet<BookkeeperSalary> BookkeeperSalaries { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SellerContact> SellerContacts { get; set; }
        public virtual DbSet<SellerSalary> SellerSalaries { get; set; }
    }
}
