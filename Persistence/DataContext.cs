﻿using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Value> Values {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData( 
                new Value{Id = 1, Name = "Value 1"},
                new Value{Id= 2, Name="Value 2"},
                new Value{Id= 3, Name="Value 3"},
                new Value{Id= 4, Name="Value 4"}
            );
        }
    }
}
