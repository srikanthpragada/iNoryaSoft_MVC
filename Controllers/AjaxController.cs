using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public string Now()
        {
            return DateTime.Now.ToString(); 
        }

        public  ActionResult Search(string pattern)
        {
            Thread.Sleep(2000);
            var books = BookRepository.GetBooks();
            var selbooks = books.Where(b => b.Title.Contains(pattern));

            return PartialView("_books", selbooks); 

        }
    }
}