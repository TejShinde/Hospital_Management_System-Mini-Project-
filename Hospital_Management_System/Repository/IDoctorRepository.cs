using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public interface IDoctorRepository
        {
    
        IEnumerable<Doctor> GetAllDoctors ();
        int DoctorRegister ( User user );
        Doctor GetDoctorById ( int DoctorID );
        int AddDoctor ( Doctor doctor );//frml admin
        int UpdateDoctorById ( Doctor doctor );//frml admin
        int DeleteDoctorById ( int DoctorID );//frml admin
        bool UpdateDoctorProfile ( Doctor doctor );//*

        }
    }
