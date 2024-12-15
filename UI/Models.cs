using System;
using Microsoft.EntityFrameworkCore;
using Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Models
{
 
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Books.db");
        }

    }
   
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

    }
}
