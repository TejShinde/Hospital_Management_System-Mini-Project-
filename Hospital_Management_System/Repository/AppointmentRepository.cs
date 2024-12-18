using Hospital_Management_System .Data;
using Hospital_Management_System .Models;
//using static System .Runtime .InteropServices .JavaScript .JSType;
using Microsoft .EntityFrameworkCore;
using System .Collections .Generic;
using System .Linq;

namespace Hospital_Management_System .Repository
    {
    public class AppointmentRepository : IAppointmentRepository
        {
        private readonly ApplicationDBContext db;

        public AppointmentRepository ( ApplicationDBContext db )
            {
            this .db = db;
            }
        public IEnumerable<Appointment> GetAllAppointments ()
            {
            return db .appointments .ToList();
            }
        public int AddAppointment ( Appointment appointment )
            {
            int result = 0;
            db .appointments .Add(appointment);
            result = db .SaveChanges();
            return result;
            }

        public Appointment GetAppointment ( int aId )
            {
            throw new NotImplementedException();
            }

        public IEnumerable<Appointment> GetAppointmentByDoctorId ( string Date , int DoctorID )
            {
            // var CDate = DateTime.Now;
            //var Date = CDate.ToShortDateString();

            var response = (from p in db .patients
                            join a in db .appointments
                            on p .PatientID equals a .PatientID
                            join t in db .timeslots
                            on a .TimeSlotID equals t .TimeSlotID
                            join d in db .doctors
                            on a .DoctorID equals d .DoctorID
                            where a .Date == Date
                             && d .UserID == DoctorID
                            select new Appointment
                                {
                                AppointmentID = a .AppointmentID ,
                                PatientID = a .PatientID ,
                                pName = p .pName ,
                                Date = a .Date ,
                                tslot = t .tslot ,
                                Comment = a .Comment
                                }) .ToList();

            return response;
            }
        IEnumerable<Appointment> IAppointmentRepository.GetAppointmentByPatientId ( int PatientID )
            {
            var response = (from d in db .doctors
                            join a in db .appointments
                            on d .DoctorID equals a .DoctorID
                            join s in db .specialities
                            on d .sId equals s .sId
                            join t in db .timeslots
                            on a .TimeSlotID equals t .TimeSlotID
                            where a .PatientID == PatientID
                            select new Appointment
                                {
                                dName = d .dName ,
                                sName = s .sName ,
                                Date = a .Date ,
                                tslot = t .tslot ,
                                }) .ToList();

            return response;
            }
        //public Appointment GetAppointmentById ( int id )
        //    {
        //    return db .appointments .FirstOrDefault(a => a .AppointmentID == id);
        //    }
        //public IEnumerable<Appointment> GetAppointmentsForPatient ( int patientId )
        //    {
        //    return db .appointments .Where(a => a .PatientID == patientId) .ToList();
        //    }


        public bool DeleteAppointment ( int id )//*
            {
            var appointment = db .appointments .FirstOrDefault(a => a .AppointmentID == id);
            if ( appointment != null )
                {
                db .appointments .Remove(appointment);
                db .SaveChanges();
                return true;
                }
            return false;
            }
        }
    }


//        public List<Appointment> GetActiveAppointments ()
//            {
//            return db .appointments .Where(a => a .Status == "Active") .ToList();
//            }

//        public List<Appointment> GetPendingAppointments ()
//            {
//            return db .appointments .Where(a => a .Status == "Pending") .ToList();
//            }


//        public List<Appointment> GetAppointmentsForPatient ( int patientID )
//            {
//            return db .appointments
//                .Where(a => a .PatientID == patientID)
//                .Include(a => a .DoctorID)
//                .ToList();
//            }

//        public List<Appointment> GetAllAppointments ()
//            {
//            return db .appointments
//                .Include(a => a .PatientID)
//                .Include(a => a .DoctorID)
//                .ToList();
//            }

//        public Appointment GetAppointmentById ( int id )
//            {
//            return db .appointments
//                .Include(a => a .PatientID)
//                .Include(a => a .DoctorID)
//                .FirstOrDefault(a => a .AppointmentID == id);
//            }




