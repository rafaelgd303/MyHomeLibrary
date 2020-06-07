using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHomeLibrary.Interfaces;
using MyHomeLibrary.Models;

namespace MyHomeLibrary.Controllers
{
    public class BookController : Controller
    {
        private IBooksInterface _booksRepo;

        public BookController(IBooksInterface booksRepository)
        {
            _booksRepo = booksRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _booksRepo.GetBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _booksRepo.AddBook(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _booksRepo.DeleteBook(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _booksRepo.FindBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            _booksRepo.UpdateBook(book);
            return RedirectToAction("Index");
        }
    }
}