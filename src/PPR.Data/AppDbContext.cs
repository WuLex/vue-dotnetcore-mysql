using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace PPR.Data {

    public class Book {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
    }

    public class Publisher {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }

    public class AppDbContext : DbContext {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL ("server=localhost;database=test;user=root;password=redhat");
        }

        public DbSet<Book> Book { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);

            modelBuilder.Entity<Publisher> (entity => {
                entity.HasKey (e => e.ID);
                entity.Property (e => e.Name).IsRequired ();
            });

            modelBuilder.Entity<Book> (entity => {
                entity.HasKey (e => e.ISBN);
                entity.Property (e => e.Title).IsRequired ();
                entity.HasOne (d => d.Publisher)
                    .WithMany (p => p.Books);
            });
        }
    }
}