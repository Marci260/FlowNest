using FlowNest.Endpoint.Models;
using FlowNest.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FlowNest.Data
{
    public class MovieDbContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cast> Casts { get; set; }


        public MovieDbContext()
        {
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=Movies.db");
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MovieDb;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
