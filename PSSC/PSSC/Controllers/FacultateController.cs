using PSSC.Models;
using PSSC.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSSC.Controllers
{
    public class FacultateController : Controller
    {
        // GET: Facultate
        FacultateRepository repository = new FacultateRepository();
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Facultate facultate)
        {
            if (!ModelState.IsValid) return View(facultate);

            repository.Add(facultate);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Facultate facultate = repository.Get(id);
            if (facultate == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(facultate);
            }
        }
    }
}