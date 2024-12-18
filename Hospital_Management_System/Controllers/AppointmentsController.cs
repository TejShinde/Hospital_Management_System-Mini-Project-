using Hospital_Management_System .Data;
using Hospital_Management_System .Models;
using Hospital_Management_System .Services;
using Microsoft .AspNetCore .Mvc;
using Microsoft .AspNetCore .Http;
using Microsoft .AspNetCore .Mvc .Rendering;
//using static System .Runtime .InteropServices .JavaScript .JSType;

namespace Hospital_Management_System .Controllers
    {
    public class AppointmentsController : Controller
        {
        private readonly IAppointmentService appointmentService;
        private readonly ISpecialityService specialityService;
        private readonly IDoctorService doctorService;
        private readonly ITimeSlotsService timeSlotsService;
        private readonly ApplicationDBContext context;


        public AppointmentsController ( IAppointmentService appointmentService , ISpecialityService specialityService , IDoctorService doctorService , ApplicationDBContext context , ITimeSlotsService timeSlotsService )
            {
            this .appointmentService = appointmentService;
            this .specialityService = specialityService;
            this .doctorService = doctorService;
            this .timeSlotsService = timeSlotsService;
            this .context = context;
            }
        public JsonResult GetDoctorsBySpecialityId ( int sId )
            {
            return Json(context .doctors .Where(x => (x .sId == sId)) .ToList());
            }

        public JsonResult GetTimeSlotsByDate ( string date , int DoctorID )
            {
            return Json(timeSlotsService .GetTimeSlotsByDate(date , DoctorID) .ToList());
            }

        // GET: AppointmentController
        public ActionResult Index ()
            {
            var response = appointmentService .GetAllAppointments();
            return View(response);
            }

        public ActionResult GetAppointmentByDid ()
            {
            var CDate = DateTime .Now;
            var Date = CDate .ToShortDateString();
            ViewBag .Date = Date;
            int DoctorID = (int) HttpContext .Session .GetInt32("UserID");

            var res = appointmentService .GetAppointmentByDoctorId(Date , DoctorID) .ToList();

            return View(res);
            }
        public JsonResult GetAppointmentByDate ( string Date )
            {
            int DoctorID = (int) HttpContext .Session .GetInt32("UserID");
            return Json(appointmentService .GetAppointmentByDoctorId(Date , DoctorID) .ToList());
            }

        public ActionResult GetAppointmentByPid ()
            {
            int PatientID = (int) HttpContext .Session .GetInt32("UserID");
            var response = appointmentService .GetAppointmentByPatientId(PatientID);
            return View(response);
            }
        // GET: AppointmentController/Details/5
        public ActionResult Details ( int id )
            {
            return View();
            }

        // GET: AppointmentController/Create
        public ActionResult BookAppointment ()
            {
            ViewBag .Specialities = specialityService .GetAllSpecialities();
            //ViewBag.Tslots = timeslotsService.GetTimeSlotsByDate(date);
            return View();
            }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookAppointment ( Appointment appointment )
            {
            try
                {
                int UserID = (int) HttpContext .Session .GetInt32("UserID");
                appointment .PatientID = UserID;
                int res = appointmentService .AddAppointment(appointment);
                if ( res >= 1 )
                    {
                    return RedirectToAction(nameof(Index));
                    }
                else
                    {
                    ViewBag .Error = "Something went wrong.";
                    return View();
                    }
                }
            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                return View();
                }
            }




        // GET: AppointmentController/Delete/5
        public ActionResult Delete ( int id )
            {
            return View();
            }

        // POST: AppointmentController/Delete/5
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

        // Action to view the appointments for the logged-in patient (or general appointments)
        //public IActionResult ViewAppointments ()
        //    {
        //    var patientID = HttpContext .Session .GetInt32("PatientID") .GetValueOrDefault();
        //    var appointments = appointmentService .GetAppointmentsForPatient(patientID);  // Fetch appointments
        //    return View(appointments);  // Pass the list of appointments to the view
        //    }
        }
    }











//        // Get Appointment Status (for demo purposes)
//        public IActionResult GetAppointmentStatus ( int appointmentID )
//            {
//            var status = appointmentService .GetAppointmentStatus(appointmentID);
//            return Json(new { status = status });
//            }
//        // Active Appointments
//        public IActionResult ActiveAppointments ()
//            {
//            var activeAppointments = appointmentService .GetActiveAppointments();
//            return View(activeAppointments);
//            }

//        // Pending Appointments
//        public IActionResult PendingAppointments ()
//            {
//            var pendingAppointments = appointmentService .GetPendingAppointments();
//            return View(pendingAppointments);
//     


