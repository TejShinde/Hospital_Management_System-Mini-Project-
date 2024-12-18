using Hospital_Management_System .Models;
using Hospital_Management_System .Services;
using Microsoft .AspNetCore .Http;
using Microsoft .AspNetCore .Mvc;

namespace Hospital_Management_System .Controllers
    {
    public class SpecialityController : Controller
        {
        private readonly ISpecialityService service;
        public SpecialityController ( ISpecialityService service )
            {
            this .service = service;
            }

        // GET: SpecialityController
        public ActionResult Index ()
            {
            var response = service .GetAllSpecialities();
            return View(response);
            }

        // GET: SpecialityController/Details/5
        public ActionResult Details ( int id )
            {
            return View();
            }

        // GET: SpecialityController/Create
        public ActionResult Create ()
            {
            return View();
            }

        // POST: SpecialityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create ( Speciality sp )
            {
            try
                {
                int res = service .AddSpeciality(sp);
                if ( res >= 1 )
                    {
                    return RedirectToAction(nameof(Index));
                    }
                else
                    {
                    ViewBag .Error = "Something went wrong";
                    return View();
                    }
                }
            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                return View();
                }
            }

        // GET: SpecialityController/Edit/5
        public ActionResult Edit ( int id )
            {
            return View();
            }

        // POST: SpecialityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ( int id , IFormCollection collection )
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: SpecialityController/Delete/5
        public ActionResult Delete ( int id )
            {
            return View();
            }

        // POST: SpecialityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete ( int id , IFormCollection collection )
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        }
    }
