using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcdemo.Models;

namespace mvcdemo.Controllers
{
    public class CoursesController : Controller
    {
        private STRepository repo;

        public CoursesController()
        {
            this.repo = new STRepository();
        }
        // GET: Courses
        public ActionResult Index()
        {
            return View(repo.GetCourses());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = repo.GetCourseByID(id.Value);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Title,Fee,Prereq")] Course course)
        {
            if (ModelState.IsValid)
            {
                repo.InsertCourse(course);
                repo.Save();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = repo.GetCourseByID(id.Value);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }


        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Title,Fee,Prereq")] Course course)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateCourse(course);
                repo.Save();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            repo.DeleteCourse(id.Value);
            repo.Save();
            return RedirectToAction("Index");

        }

      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
