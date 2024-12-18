using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;
using Hospital_Management_System .Services;
using Microsoft .AspNetCore .Http;
using Microsoft .AspNetCore .Authorization;
using Microsoft .AspNetCore .Http;
//using Newtonsoft .Json .Linq;
//using Microsoft .Identity .Client;
//using Microsoft .VisualStudio .Web .CodeGenerators .Mvc .Templates .BlazorIdentity .Pages;
using Microsoft .AspNetCore .Mvc;
using System;

namespace Hospital_Management_System .Controllers
    {
    public class PatientController : Controller
        {
        private readonly IPatientService service;
        private readonly ISpecialityService service1;

        public PatientController ( IPatientService service , ISpecialityService service1 )
            {
            this .service = service;
            this .service1 = service1;
            }

        public ActionResult PatientHome ()
            {
            return View();
            }

        // GET: 
        public ActionResult PatientProfile ()
            {
            return View();
            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PatientProfile ( Patient patient )
            {
            try
                {
                var res = service .AddPatientProfile(patient);
                if ( res != null )
                    {
                    ViewBag .Message = "Patient Profile Updated";
                    return RedirectToAction(nameof(PatientHome));
                    }
                else
                    {
                    ViewBag .Error = "Something Went Wrong";
                    return View();
                    }
                }
            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                return View();
                }
            }

        public ActionResult Logout ()
            {
            HttpContext .Session .Clear();
            ViewBag .Message = "Patient Logout Successfully.";
            return RedirectToAction("Login" , "User");
            }
        }
    }

//public ActionResult UpdateProfile ()//*
//    {
//    var patientID = HttpContext .Session .GetInt32("PatientID") .GetValueOrDefault();
//    var patient = service .GetPatientById(patientID);
//    return View(patient);
//    }

//[HttpPost]
//public ActionResult SaveProfileChanges ( Patient patient )//*
//    {
//    var result = service .UpdatePatientProfile(patient);
//    if ( result )
//        {
//        ViewBag .Message = "Profile updated successfully.";
//        }
//    else
//        {
//        ViewBag .Error = "Profile update failed.";
//        }
//    return View("UpdateProfile" , patient);
//    }



//public ActionResult ViewAppointments ()//*
//    {
//    var patientID = HttpContext .Session .GetInt32("PatientID") .GetValueOrDefault();
//    var appointments = appointmentService .GetAppointmentsForPatient(patientID);
//    return View(appointments);
//    }

//public ActionResult ViewAppointmentStatus ( int appointmentID )//*
//    {
//    var status = appointmentService .GetAppointmentStatus(appointmentID);
//    return View("AppointmentStatus" , status);
//    }

//public ActionResult GetNotifications ()
//    {
//    var patientID = HttpContext .Session .GetInt32("PatientID") .GetValueOrDefault();
//    var notifications = _notificationService .GetNotificationsForPatient(patientID);
//    return View(notifications);
//    }

