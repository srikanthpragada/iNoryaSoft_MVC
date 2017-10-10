using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    [Table("stcourses")]
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        public int Fee { get; set; }

        [Required]
        public string Prereq { get; set; }
    }
}