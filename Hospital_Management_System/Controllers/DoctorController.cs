using Hospital_Management_System .Models;
using Hospital_Management_System .Services;
using Microsoft .AspNetCore .Authorization;
using Microsoft .AspNetCore .Http;
using Microsoft .AspNetCore .Mvc;
using Microsoft .AspNetCore .Mvc .Rendering;
using System .Numerics;

namespace Hospital_Management_System .Controllers
    {

    public class DoctorController : Controller
        {

        public IActionResult DoctorHome ()
            {
            return View();
            }
        public ActionResult Logout ()
            {
            HttpContext .Session .Clear();
            ViewBag .Message = "Doctor Logout Sucessfully.";
            return RedirectToAction("Login" , "User");
            }


        // Action for doctor to view all appointments (active, pending, cancelled)
        //public IActionResult ViewAppointments ()//*
        //    {
        //    try
        //        {
        //        var doctorID = HttpContext .Session .GetInt32("DoctorID") .GetValueOrDefault();
        //        var appointments = appointmentService .GetAppointmentsForDoctor(doctorID);
        //        return View(appointments);
        //        }
        //    catch ( Exception ex )
        //        {
        //        ViewBag .Error = ex .Message;
        //        return View();
        //        }
        //    }

        //// Action to approve an appointment
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult ApproveAppointment ( int appointmentID )//*
        //    {
        //    try
        //        {
        //        var result = appointmentService .ApproveAppointment(appointmentID);
        //        if ( result )
        //            {
        //            ViewBag .Message = "Appointment approved successfully.";
        //            }
        //        else
        //            {
        //            ViewBag .Error = "Failed to approve appointment.";
        //            }
        //        }
        //    catch ( Exception ex )
        //        {
        //        ViewBag .Error = ex .Message;
        //        }
        //    return RedirectToAction(nameof(ViewAppointments));
        //    }

        //// Action to change appointment status (e.g., to Cancel)
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult CancelAppointment ( int appointmentID )//*
        //    {
        //    try
        //        {
        //        var result = appointmentService .CancelAppointment(appointmentID);
        //        if ( result )
        //            {
        //            ViewBag .Message = "Appointment cancelled successfully.";
        //            }
        //        else
        //            {
        //            ViewBag .Error = "Failed to cancel appointment.";
        //            }
        //        }
        //    catch ( Exception ex )
        //        {
        //        ViewBag .Error = ex .Message;
        //        }
        //    return RedirectToAction(nameof(ViewAppointments));
        //    }



        ////Doctor profile page
        //[HttpGet]
        //public IActionResult Profile ( int UserID )
        //    {
        //    if ( UserID <= 0 )
        //        {
        //        ViewBag .Error = "Invalid User ID.";
        //        return View("Error");
        //        }
        //    var doctor = dr .GetDoctorProfile(UserID);
        //    if ( doctor != null )
        //        {
        //        return View("DoctorProfile" , doctor);
        //        }

        //    ViewBag .Error = "Doctor profile not found.";
        //    return View("Error");
        //    }



        }
    }




