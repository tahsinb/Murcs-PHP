﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PHP.Database.Classes;
namespace PHP.Database
{
    public class PHPConext : DbContext
    {
        private readonly IDatabaseAppSettings _databaseAppSettings;
        public PHPConext(IDatabaseAppSettings databaseAppSettings)
        {
            _databaseAppSettings = databaseAppSettings;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder) // Configure one to many or many to one 
        {
            modelbuilder.Entity<Sale>()
                .HasMany(s => s.Products)
                .WithOne();
            modelbuilder.Entity<Sale>()
                .HasOne(s => s.Employee)
                .WithOne();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql($"Host={_databaseAppSettings.URL};Database={_databaseAppSettings.DatabaseName};Username={_databaseAppSettings.UserName};Password={_databaseAppSettings.Password}");

    }

}
