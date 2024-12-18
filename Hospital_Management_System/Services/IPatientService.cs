using Hospital_Management_System .Models;

namespace Hospital_Management_System .Services
    {
    public interface IPatientService
        {
        int AddPatientProfile ( Patient patient );

        //  Patient GetPatientById ( int patientID );//*
        //  bool UpdatePatientProfile ( Patient patient );//*

        }
    }
