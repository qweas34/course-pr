using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static iText.IO.Util.IntHashtable;

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
                List<Book> books =  db.Books.ToList();
                return books;
        }
        public Book getBook_byId(int id)
        {
             Book book = db.Books.Find(id);
             return book;
        }
        public void DeleteBook(Book book)
        {
            
        }

        public Book addBook(string Title, string Description, string Path)
        {
            Book bookTemp = new Book { Title = Title, Description = Description, Path =Path };
            db.Books.Add(bookTemp);
            db.SaveChanges();
            return bookTemp;
        }

    }
}
