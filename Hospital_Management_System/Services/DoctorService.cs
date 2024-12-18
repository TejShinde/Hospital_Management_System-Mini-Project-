using Hospital_Management_System .Data;
using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;
using Microsoft .EntityFrameworkCore;

namespace Hospital_Management_System .Services
    {
    public class DoctorService : IDoctorService
        {
        private readonly IDoctorRepository repo;
        public DoctorService ( IDoctorRepository repo )
            {
            this .repo = repo;
            }
        public int AddDoctor ( Doctor doctor )//frm admin
            {
            return repo .AddDoctor(doctor);
            }

        public IEnumerable<Doctor> GetAllDoctors ()
            {
            return repo .GetAllDoctors();
            }

        public Doctor GetDoctorById ( int DoctorID )
            {
            return repo .GetDoctorById(DoctorID);
            }

        public int UpdateDoctorById ( Doctor doctor )//frm admin
            {
            return repo .UpdateDoctorById(doctor);
            }
        public int DeleteDoctorById ( int DoctorID )//frm admin
            {
            return repo .DeleteDoctorById(DoctorID);
            }

        public int DoctorRegister ( User user )
            {
            return repo .DoctorRegister(user);
            }
        }
    }



