using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{    public class RecipesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public RecipesDbContext(DbContextOptions<RecipesDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Recipe>()
                .Property(r => r.Name)
                .IsRequired();

            modelBuilder.Entity<Recipe>()
                .Property(r => r.Ingredients)
                .IsRequired();

            modelBuilder.Entity<Recipe>()
                .Property(r => r.Type)
                .IsRequired();
        }
    }
}
