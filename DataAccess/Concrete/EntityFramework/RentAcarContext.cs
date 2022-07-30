using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{ 
        public class RentAcarContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentAcar;Trusted_Connection=true");
            }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Rental> Rentals { get; set; }
            public DbSet<CarImage> CarImages { get; set; }

    }
    }
