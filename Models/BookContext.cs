using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module6HW5.Models
{
    public class BookContext 
    {
        private static BookContext instance;
        List<Book> Books = new List<Book>();
        public BookContext()

        {

            Books.Add(new Book { Id = 203203, Name = "Harry Potter and the Philosopher's Stone", Price = 300, Author = "Joanne Rowling", YearofPublishing = 1997 });
            Books.Add(new Book { Id = 20620, Name = "Harry Potter and the Chamber of Secrets", Price = 310, Author = "Joanne Rowling", YearofPublishing = 1998 });
            Books.Add(new Book { Id = 20220, Name = "Harry Potter and the Prisoner of Azkaban", Price = 310, Author = "Joanne Rowling", YearofPublishing = 1999 });

        }
        public List<Book> GetBooks() => Books;
        public void AddBooks(int Id, string Name, string Author, int Price, int YearofPublishing)
        {
            Books.Add(new Book { Id = Id, Name = Name, Price = Price, Author = Author, YearofPublishing = YearofPublishing });
        }
        public static BookContext getInstance()
        {
            if (instance == null)
                instance = new BookContext();
            return instance;
        }
        public void RemoveBook(int Id)
        {
            foreach (var a in Books)
            {
                if (a.Id == Id)
                {
                    Books.Remove(a);
                    break;
                }

            }
        }
        public Book GetBook(int Id)
        {
            foreach (var a in Books)
            {
                if (a.Id == Id)
                {
                    return a;
                    
                }
            }
            return null;
        }
        public void Updatebook(int Id, string Name, string Author, int Price, int YearofPublishing)
        {
            foreach (var item in Books)
            {
                if(Id==item.Id)
                {
                    item.Name = Name;   
                    item.YearofPublishing = YearofPublishing;
                    item.Author = Author;
                    item.Price = Price; 
                }
            }
        }
    }
}

