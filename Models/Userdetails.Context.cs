﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EShopApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EshopdbEntities : DbContext
    {
        public EshopdbEntities()
            : base("name=EshopdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Orderitem> Orderitems { get; set; }
        public DbSet<Ordertable> Ordertables { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Productinventory> Productinventories { get; set; }
        public DbSet<Useraddress> Useraddresses { get; set; }
        public DbSet<Userdetail> Userdetails { get; set; }
        public DbSet<Userpayment> Userpayments { get; set; }
        public DbSet<Productcategory> Productcategories { get; set; }
    }
}