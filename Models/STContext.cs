using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class STContext : DbContext
    {
        public STContext() : base("name=msdbconstr")
        {

        }

        public DbSet<Course> Courses { get; set; }
    }

}