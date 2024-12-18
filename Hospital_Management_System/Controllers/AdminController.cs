using Hospital_Management_System .Models;
using Hospital_Management_System .Services;
using Microsoft .AspNetCore .Http;
using Microsoft .AspNetCore .Mvc;

namespace Hospital_Management_System .Controllers
    {
    public class AdminController : Controller
        {
        private readonly IDoctorService service;
        private readonly ISpecialityService speciality;
        private readonly IUserService userService;
        public AdminController ( IDoctorService service , ISpecialityService speciality , IUserService userService )
            {
            this .service = service;
            this .speciality = speciality;
            this .userService = userService;
            }
        // GET: DoctorController
        public ActionResult GetAllDoctors ()
            {
            var response = service .GetAllDoctors();
            return View(response);
            }
        public IActionResult AdminHome ()
            {
            return View();
            }

        // GET: /Admin/DoctorRegister
        [HttpGet]
        public IActionResult DoctorRegister ()
            {
            return View();
            }

        // POST: /Admin/DoctorRegister
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DoctorRegister ( User user )
            {
            try
                {
                user .RoleID = 3;
                int res = userService .UserRegistration(user);
                if ( res >= 1 )
                    {
                    return RedirectToAction(nameof(DoctorProfile));
                    }
                }
            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                }
            return View();
            }

        // GET: DoctorController/Create
        public ActionResult DoctorProfile ()
            {

            ViewBag .Specialities = speciality .GetAllSpecialities();
            ViewBag .Users = userService .GetAllUsers();
            return View();

            }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoctorProfile ( Doctor doctor )
            {
            try
                {
                int res = service .AddDoctor(doctor);
                if ( res >= 1 )
                    {
                    return RedirectToAction(nameof(AdminHome));
                    }
                }
            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                }
            return View();

            }

        // GET: DoctorController/Edit/5
        public ActionResult Edit ( int id )
            {
            ViewBag .Specialities = speciality .GetAllSpecialities();
            var doc = service .GetDoctorById(id);
            return View(doc);
            }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ( Doctor doctor )
            {
            try
                {
                int res = service .UpdateDoctorById(doctor);
                if ( res >= 1 )
                    {
                    return RedirectToAction(nameof(AdminHome));

                    }
                else
                    {
                    ViewBag .Error = "Something went wrong";
                    return View();
                    }
                }
            catch ( Exception ex )
                {
                    {
                    ViewBag .Error = ex .Message;
                    return View();
                    }
                }
            }

        public ActionResult DoctorHome ()
            {
            return View();
            }

        public ActionResult Logout ()
            {
            HttpContext .Session .Clear();
            ViewBag .Message = "Admin Logout Sucessfully.";
            return RedirectToAction("Login" , "User");
            }

        // GET: DoctorController/Delete/5
        public ActionResult Delete ( int id )
            {
            return View(service .GetDoctorById(id));
            }

        //POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm ( int id )
            {
            try
                {
                var doctor = service .GetDoctorById(id);
                int res = service .DeleteDoctorById(id);
                if ( res >= 1 )
                    {
                    return RedirectToAction(nameof(AdminHome));
                    }
                else
                    {
                    return View();
                    }
                }
            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                return View();
                }
            }

        // GET: DoctorController/Details/5
        public ActionResult Details ( int id )
            {
            var doctor = service .GetDoctorById(id); // Get the doctor by ID
            if ( doctor == null )
                {
                return NotFound(); // Return 404 if doctor is not found
                }
            return View(doctor); // Pass the doctor object to the view
            }

        }
    }
