using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;

namespace Hospital_Management_System .Services
    {
    public class SpecialityService : ISpecialityService
        {
        private readonly ISpecialityRepository reop;
        public SpecialityService ( ISpecialityRepository reop )
            {
            this .reop = reop;
            }
        public int AddSpeciality ( Speciality speciality )
            {
            return reop .AddSpeciality(speciality);
            }

        public int DeleteSpeciality ( int sId )
            {
            return reop .DeleteSpeciality(sId);
            }

        public IEnumerable<Speciality> GetAllSpecialities ()
            {
            return reop .GetAllSpecialities();
            }

        public Speciality GetSpecialityById ( int sId )
            {
            return reop .GetSpecialityById(sId);
            }

        public Speciality UpdateSpecaility ( Speciality speciality )
            {
            return reop .UpdateSpecaility(speciality);
            }

        }
    }
