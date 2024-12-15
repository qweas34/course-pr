using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Controller
{
  
    public class controller
    {
        private BooksDbContext db = new BooksDbContext();
        public controller()
        {
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Books.Load();
        }
        public List<Book> getBooksList()
        {
                Book b = new Book { Title = "gsdfgsdf", Description = "sdfgdfgsdf", Path = "gfsdgdfgsdfgsdf"};
                List<Book> books = db.Books.ToList();
                return books;
           
        }
        public Book getBook(int id)
        {
            
                Book book = db.Books.Find(id);
                return book;
            
        }


        public void addBook(string Title, string Description, string Path)
        {
            Book bookTemp = new Book { Title = Title, Description = Description, Path =Path };
                db.Books.Add(bookTemp);
                db.SaveChanges();
            

        }

    }
}
