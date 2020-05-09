using MyHomeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeLibrary.Interfaces
{
    public interface IBooksInterface
    {
        List<Book> GetBooks();
        void AddBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);
    }
}
