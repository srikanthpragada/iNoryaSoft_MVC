using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcdemo.Controllers
{
 
    public class BooksApiController : ApiController
    {
     
        public IEnumerable<Book> GetBooks()
        {
            return BookRepository.GetBooks();
        }
     
        public Book GetBooks(int id)
        {
            var book = BookRepository.GetBooks().Where(b => b.Id == id).FirstOrDefault();
            if (book == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return book; 
        }
    }
}
