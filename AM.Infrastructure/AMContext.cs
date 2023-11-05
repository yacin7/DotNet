using festivals.Domain;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Artiste> Artistes { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Concert> Concerts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=MohamedYassineFerchichiDB;Integrated Security=true;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConcertConfiguration());

            modelBuilder.Entity<Concert>()
                .HasKey(c => new { c.ArtisteFk, c.FestivalFk, c.DateConcert });

            modelBuilder.Entity<Concert>()
                .HasOne(c => c.Artiste)
                .WithMany(a => a.Concerts)
                .HasForeignKey(c => c.ArtisteFk);

            modelBuilder.Entity<Concert>()
                .HasOne(c => c.Festival)
                .WithMany(f => f.Concerts)
                .HasForeignKey(c => c.FestivalFk);
        }
       
    }
}
