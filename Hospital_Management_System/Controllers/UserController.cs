using Hospital_Management_System .Controllers;
using Hospital_Management_System .Models;
using Hospital_Management_System .Services;
using Microsoft .AspNetCore .Http;
using Microsoft .AspNetCore .Mvc;
using Microsoft .EntityFrameworkCore;
using System;

namespace Hospital_Management_System .Controllers
    {
    public class UserController : Controller
        {
        private readonly IUserService service;

        public UserController ( IUserService service )
            {
            this .service = service;
            }
        public ActionResult UserRegistration ()
            {
            return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserRegistration ( User user )
            {
            try
                {
                user .RoleID = 2;
                var res = service .UserRegistration(user);
                if ( res != null )
                    {
                    ViewBag .Message = " Register Sucessfully.";
                    return RedirectToAction(nameof(Login));
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
        [HttpGet]
        public IActionResult Login ()
            {
            var response = service .GetAllRoles();
            ViewBag .Roles = response;
            return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login ( User u )
            {
            try
                {
                var user = service .UserLogin(u);
                if ( user != null )
                    {
                    HttpContext .Session .SetString("UserName" , user .UserName);
                    HttpContext .Session .SetInt32("UserID" , user .UserID);

                    if ( user .RoleID == 1 )
                        {
                        return RedirectToAction("AdminHome" , "Admin");
                        }
                    else if ( user .RoleID == 3 )
                        {
                        return RedirectToAction("DoctorHome" , "Doctor");
                        }
                    else
                        {
                        return RedirectToAction("PatientHome" , "Patient");
                        }
                    }
                }

            catch ( Exception ex )
                {
                ViewBag .Error = ex .Message;
                }
            return View();
            }
        }
    }