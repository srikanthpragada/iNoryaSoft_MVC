using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcdemo.Controllers
{
    public class WebCoursesController : ApiController
    {
        STRepository repo;

        WebCoursesController()
        {
            repo = new STRepository();
        }
        public IEnumerable<Course> Get()
        {
            return repo.GetCourses();
        }

        public void Post(Course course)
        {
            try {
                repo.InsertCourse(course);
                repo.Save();
            }
            catch(Exception ex)
            {
                HttpResponseMessage msg = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                throw new HttpResponseException(msg);
            }
        }
    }
}
