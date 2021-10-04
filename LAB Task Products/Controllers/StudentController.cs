using LAB Task Products.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB Task Products.Models;

namespace LAB Task Products.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            Database db = new Database();
            var students =db.Students.GetAll();
            return View(students);
        }
        public ActionResult Update(Student s)
        {
            if (s != null)
                return View(s);
            else
                return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Normal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Add(s);
                return RedirectToAction("index");
            }
            return View();

            
        }
        public ActionResult Delete(int Id)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Delete(Id);
                return RedirectToAction("index");
            }
            return View();


        }

        public ActionResult AddCart(int Id)
        {

             Database db = new Database();
            var students = db.Students.AddCart(Id);
            //db.Students.AddCart(Id);
            //return RedirectToAction("index");
            return View(students);


        }


    }
}