using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aspnet_jquery.Controllers
{
    public class LanguagesController : ApiController
    {
      

        public IEnumerable<String> Get(string term)
        {
            var langs = new List<String>() { "Java", "JavaScript", "Python", "CSharp", "TypeScript" };
            var sellangs = from l in langs
                           where l.Contains(term)
                           select l;

            return sellangs;

        }


         
    }
}
