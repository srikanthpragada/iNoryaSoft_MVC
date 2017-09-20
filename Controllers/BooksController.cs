using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class BooksController : Controller
    {

        // GET: Books
        public ActionResult Index()
        {
            var book = new Book { Id = 1, Title = "Pro Asp.Net MVC", Price = 780, Subject = "aspnet" };
            return View(book);
        }

        public ActionResult List()
        {
            var books = BookRepository.GetBooks();
            return View(books);
        }


        public ActionResult Delete(string id)
        {
            // delete book with id 
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            var book = new Book();
            book.Price = 200;
            book.Subject = "ASP";
            return View(book);
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (book.Subject.ToUpper() == "ASP" && book.Price < 200)
                ModelState.AddModelError("", "Invalid price for selected subject!");

            if (!ModelState.IsValid)
                return View(book);

            return RedirectToAction("List");
        }

        public ActionResult Edit(string id)
        {
            // Get details of book with id and display 
            var book = new Book(); //  get it from database 
            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(string id, Book book)
        {
            // Update row in table using data coming from book
            return RedirectToAction("List");

        }


    }
}