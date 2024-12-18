using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;
using System .Collections .Generic;

namespace Hospital_Management_System .Services
    {
    public class AppointmentService : IAppointmentService
        {
        private readonly IAppointmentRepository repo;

        public AppointmentService ( IAppointmentRepository repo )
            {
            this .repo = repo;
            }

        public int AddAppointment ( Appointment appointment )
            {
            return repo .AddAppointment(appointment);
            }

        public IEnumerable<Appointment> GetAllAppointments ()
            {
            return repo .GetAllAppointments();
            }

        public Appointment GetAppointment ( int aId )
            {
            return repo .GetAppointment(aId);
            }

        public IEnumerable<Appointment> GetAppointmentByDoctorId ( string Date , int DoctorID )
            {
            return repo .GetAppointmentByDoctorId(Date , DoctorID);
            }

        public IEnumerable<Appointment> GetAppointmentByPatientId ( int PatientID )
            {
            return repo .GetAppointmentByPatientId(PatientID);
            }
        }

    }
