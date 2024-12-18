using Hospital_Management_System .Models;

namespace Hospital_Management_System .Services
    {
    public interface IDoctorService
        {
        int AddDoctor ( Doctor doctor );
        int DoctorRegister ( User user );
        IEnumerable<Doctor> GetAllDoctors ();
        Doctor GetDoctorById ( int DoctorID );
        int UpdateDoctorById ( Doctor doctor );
        int DeleteDoctorById ( int DoctorID );

        }
    }
