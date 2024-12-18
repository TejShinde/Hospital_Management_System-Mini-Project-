using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public interface IAppointmentRepository
        {
        int AddAppointment ( Appointment appointment );
        Appointment GetAppointment ( int AppointmentID );
        IEnumerable<Appointment> GetAllAppointments ();
        IEnumerable<Appointment> GetAppointmentByDoctorId ( string Date , int DoctorID );
        IEnumerable<Appointment> GetAppointmentByPatientId ( int PatientID );

        }
    }
