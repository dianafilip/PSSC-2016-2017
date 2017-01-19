using PSSC.Models;
using PSSC.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSSC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentRepository repository = new StudentRepository();
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Student student)
        {
            if (!ModelState.IsValid) return View(student);

            repository.Add(student);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student student = repository.Get(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(student);
            }
        }
    }
}