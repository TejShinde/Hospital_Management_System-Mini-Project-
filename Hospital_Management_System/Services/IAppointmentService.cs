using Hospital_Management_System .Models;

namespace Hospital_Management_System .Services
    {
    public interface IAppointmentService
        {
        int AddAppointment ( Appointment appointment );
        Appointment GetAppointment ( int aId );
        IEnumerable<Appointment> GetAllAppointments ();
        IEnumerable<Appointment> GetAppointmentByDoctorId ( string Date , int DoctorID );
        IEnumerable<Appointment> GetAppointmentByPatientId ( int PatientID );
        }
    }
