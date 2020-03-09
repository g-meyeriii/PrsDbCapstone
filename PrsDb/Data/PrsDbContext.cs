﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrsDb.Models;

namespace PrsDb.Data
{
    public class PrsDbContext : DbContext
    {
        public PrsDbContext (DbContextOptions<PrsDbContext> options)
            : base(options)
        {
        } 
        
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating (ModelBuilder model) {
            model.Entity<User>(u => {
                u.ToTable("Users");
                u.HasKey(u => u.Id);
                u.Property(u => u.UserName).HasMaxLength(30).IsRequired();
                u.HasIndex(u => u.UserName).IsUnique();
                u.Property(u => u.Password).HasMaxLength(30).IsRequired();
                u.Property(u => u.FirstName).HasMaxLength(30).IsRequired();
                u.Property(u => u.LastName).HasMaxLength(30).IsRequired();
                u.Property(u => u.Phone).HasMaxLength(12);
                u.Property(u => u.Email).HasMaxLength(255);
                u.Property(u => u.IsReviewer).IsRequired().HasDefaultValue(false);
                u.Property(u => u.IsAdmin).IsRequired().HasDefaultValue(false);
            });
            model.Entity<Vendor>(v => {
                v.ToTable("Vendors");
                v.HasKey(v => v.Id);
                v.Property(v => v.Code).IsRequired().HasMaxLength(30);
                v.HasIndex(v => v.Code).IsUnique();
                v.Property(v => v.Name).HasMaxLength(30).IsRequired();
                v.Property(v => v.Address).HasMaxLength(30).IsRequired();
                v.Property(v => v.City).HasMaxLength(30).IsRequired();
                v.Property(v => v.State).HasMaxLength(2).IsRequired();
                v.Property(v => v.Zip).HasMaxLength(5).IsRequired();
                v.Property(v => v.Phone).HasMaxLength(12);
                v.Property(v => v.Email).HasMaxLength(255);
            });
            model.Entity<Product>(p => {
                p.ToTable("Product");
                p.HasKey(p => p.Id);
                p.Property(p => p.PartNbr).HasMaxLength(30).IsRequired();
                p.Property(p => p.Name).HasMaxLength(30).IsRequired();
                p.Property(p => p.Price).HasMaxLength(13);
                p.Property(p => p.Unit).HasMaxLength(30).IsRequired();
                p.Property(p => p.PhotoPath).HasMaxLength(255);
                          
            });
            model.Entity<RequestLine>(rl => {
                rl.ToTable("RequestLine");
                rl.HasKey(rl => rl.Id);
                rl.Property(rl => rl.Quantity).HasDefaultValue(1);
            });
        }

        public DbSet<PrsDb.Models.Product> Product { get; set; }

        public DbSet<PrsDb.Models.RequestLine> RequestLine { get; set; }


        
    }
}
