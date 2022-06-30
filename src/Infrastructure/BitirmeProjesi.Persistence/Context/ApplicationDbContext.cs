﻿using BitirmeProjesi.Domain.Entities;
using BitirmeProjesi.Domain.Entitiess;
using BitirmeProjesi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<List>().HasData(
            //    new List() { Id = Guid.NewGuid(), Category = { Id = Guid.NewGuid(), Name = "Migros Alışverişi" }, IsCompleted=0, Title ="Kırtasiye", Item = {Id=Guid.NewGuid(),Name = "Ekmek",Quantity = 1}, }     }

            //    );
            //base.OnModelCreating(modelBuilder);
        }
    }
}