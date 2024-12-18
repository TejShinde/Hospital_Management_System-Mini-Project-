using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;

namespace Hospital_Management_System .Services
    {
    public class PatientService: IPatientService
        {
        private readonly IPatientRepository repo;
        public PatientService ( IPatientRepository repo )
            {
            this .repo = repo;
            }
        public int AddPatientProfile ( Patient patient )
            {
            return repo .PatientRegistration(patient);
            }

        //public Patient GetPatientById ( int patientID )
        //     {
        //     throw new NotImplementedException();
        //     }

        // public bool UpdatePatientProfile ( Patient patient )
        //     {
        //     throw new NotImplementedException();
        //     }

        // Patient IPatientService.AddPatientProfile ( Patient patient )
        //     {
        //     throw new NotImplementedException();
        //     }
        }
    }
