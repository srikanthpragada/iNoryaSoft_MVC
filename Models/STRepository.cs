using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class STRepository
    {
        private STContext context;

        public STRepository()
        {
            this.context = new STContext();
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses.ToList();
        }

        public Course GetCourseByID(int id)
        {
            return context.Courses.Find(id);
        }

        public void InsertCourse(Course course)
        {
            context.Courses.Add(course);
        }

        public bool DeleteCourse(int id)
        {
            Course course = context.Courses.Find(id);
            if (course != null)
            {
                context.Courses.Remove(course);
                return true;
            }
            else
                return false; 
        }

        public void UpdateCourse(Course course)
        {
            context.Entry(course).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}