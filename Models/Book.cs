using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required ( ErrorMessage = "Please provide title!")]
        public string Title { get; set; }

        [Range (100,1000, ErrorMessage = "Invalid Price. Must be between 100 and 1000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please provide subject!")]
        [RegularExpression("^[a-zA-Z]+$" , ErrorMessage = "Subject must have only alpha")]
        public string Subject { get; set; }

    }
}