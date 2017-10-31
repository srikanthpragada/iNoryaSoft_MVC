using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcdemo.Controllers
{
    public class DeptController : ApiController
    {
        public static Dictionary<String, List<String>> depts =
            new Dictionary<string, List<String>>
        {
             { "Accounts", new List<string> { "Joe", "Steve", "Scott" } } ,
             { "Sales", new List<string> { "Tim", "Richards", "Jhonson" } }
        };


        public IEnumerable<String> GetDepts()
        {
            return depts.Keys;

        }

        public IEnumerable<String> GetEmployees(string id)
        {
            return depts[id];

        }
    }
}
