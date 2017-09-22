using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class CacheController : Controller
    {
        [OutputCache( Duration = 60, VaryByParam = "*")]
        public ActionResult Index()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }

        [OutputCache( CacheProfile ="Cache2Mins")]
        public ActionResult Now()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View("Index");
        }

        private Book[] GetBooks()
        {
            var books = HttpContext.Cache["books"] as Book[];
            if (books == null) {
                books = BookRepository.GetBooks();
                ViewBag.Message = "Cache Created!";
                HttpContext.Cache.Insert("books", books , null, 
                        DateTime.Now.AddMinutes(2), TimeSpan.Zero);
            }
            else
                ViewBag.Message = "Cache Being Used!";

            return books; 
        }
       
        public ActionResult Books()
        {
           var books =  GetBooks();
           return View(books);
        }

       
        public ActionResult List()
        {
            var books = GetBooks();
            return View(books);
        }

        public static string GetQuote(HttpContext context)
        {
            var quotes = new List<string>
                {
                    "Work is worship",
                    "Winners never quit. Quitters never win",
                    "You never win until you start",
                    "Failing to plan is planning to fail"
                };

            var rnd = new Random();
            var quote = quotes[rnd.Next(quotes.Count)];
            return quote;
        }

    }
}