using FlowNest.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Data
{
    public class FlowNestDBContext : IdentityDbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public FlowNestDBContext(DbContextOptions<FlowNestDBContext> ctx)
        : base(ctx)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Ratings)
                .WithOne(r => r.Movie)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Movie>()
            .Property(m => m.Genres)
            .HasConversion<string>();





            base.OnModelCreating(modelBuilder);
        }
    }
}

