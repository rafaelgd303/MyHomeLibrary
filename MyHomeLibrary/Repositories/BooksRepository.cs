using MyHomeLibrary.Interfaces;
using MyHomeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeLibrary.Repositories
{
    public class BooksRepository : IBooksInterface
    {
        private List<Book> _books;
        private int _counter = 2; 

        public BooksRepository()
        {
            _books = new List<Book>
            {
                new Book {Id = 0, Title = "Hobbit", Author = "JRR Tolkien", Page = 290},
                new Book {Id = 1, Title = "Lord of the Rings", Author = "JRR Tolkien", Page = 850}
            };
        }

        public void AddBook(Book book)
        {
            book.Id = _counter;
            _books.Add(book);
            _counter++;
        }

        public void DeleteBook(int id)
        {
            var bookToDelete = _books.SingleOrDefault(book => book.Id == id);
            _books.Remove(bookToDelete);
        }

        public Book FindBook(int id)
        {
            var bookToUpdate = _books.FirstOrDefault(book => book.Id == id);
            return bookToUpdate;
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public void UpdateBook(Book book)
        {
            int bookIndexToUpdate = _books.FindIndex(b => b.Id == book.Id);
            if (bookIndexToUpdate != -1)
            {
                _books[bookIndexToUpdate] = book;
            }
        }
    }
}
