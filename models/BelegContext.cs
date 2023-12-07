using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class BelegContext : DbContext
    {
        public DbSet<Benutzer> Benutzer { get; set; }
        public DbSet<Beleg> Belege { get; set; }
        public DbSet<Artikel> Artikel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=meineDatenbank.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beleg>()
                .HasOne(b => b.Benutzer)
                .WithMany(u => u.Belege)
                .HasForeignKey(b => b.BenutzerId);

            modelBuilder.Entity<Artikel>()
                .HasOne(a => a.Beleg)
                .WithMany(b => b.Artikel)
                .HasForeignKey(a => a.BelegId);
        }
    }
}
