﻿using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Value> Values {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id=1, Name="Sitefinity"},
                    new Value {Id=2, Name="Kentico"},
                    new Value {Id=3, Name="Sitecore"}
                );
        }
    }
}
