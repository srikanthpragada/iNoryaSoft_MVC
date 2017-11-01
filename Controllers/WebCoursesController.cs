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

        public Course Get(int id)
        {
            return repo.GetCourseByID(id);
        }

        // WebCourses/id   -- DELETE 
        public void Delete(int id)
        {
            bool done = repo.DeleteCourse(id);

            if (!done)
            {
                HttpResponseMessage msg = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                throw new HttpResponseException(msg);
            }
            else
            {
                repo.Save();
            }
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

        public void Put(int id, Course course)
        {
            try
            {
                course.Id = id; 
                repo.UpdateCourse(course);
                repo.Save();
            }
            catch (Exception ex)
            {
                HttpResponseMessage msg = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                throw new HttpResponseException(msg);
            }
        }

    }
}
