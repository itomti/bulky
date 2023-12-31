﻿using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
            new Category { Id = 3, Name = "History", DisplayOrder = 3 },
            new Category { Id = 4, Name = "Drama", DisplayOrder = 4 },
            new Category { Id = 5, Name = "Romance", DisplayOrder = 5 }
        );
    }
}