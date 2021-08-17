﻿using FormsDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsDemo.Data
{
  public class PetsDbContext : DbContext
  {

    public DbSet<Pet> Pets { get; set; }

    public PetsDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Pet>().HasData(
        new Pet { Id=1, Name="Rosie", Owner="John", Age=6, Type=PetType.Dog},
        new Pet { Id=2, Name="Luna", Owner="Char", Age=6, Type=PetType.Dog}
      );
    }
  }
}
