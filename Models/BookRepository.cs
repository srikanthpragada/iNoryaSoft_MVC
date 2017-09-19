using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class BookRepository
    {
        public static Book [] GetBooks()
        {
            return new Book[] {
                  new Book { Id = 1, Title = "Pro Asp.Net MVC", Price = 890, Subject = "aspnet" },
                  new Book { Id = 2, Title = "C# Complete Reference", Price = 590, Subject = "c#" },
                  new Book { Id = 3, Title = "Entity Framework", Price = 670, Subject = "ef" }
            };
        }
    }
}