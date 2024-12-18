using Hospital_Management_System .Data;
using Hospital_Management_System .Models;
using Hospital_Management_System .Services;
using System .Security .Cryptography;

namespace Hospital_Management_System .Repository
    {
    public class SpecialityRepository : ISpecialityRepository
        {
        private readonly ApplicationDBContext db;
        public SpecialityRepository ( ApplicationDBContext db )
            {
            this .db = db;
            }
        public int AddSpeciality ( Speciality speciality )
            {
            int res = 0;
            db .specialities .Add(speciality);
            res = db .SaveChanges();
            return res;
            }

        public int DeleteSpeciality ( int sId )
            {
            int res = 0;
            var sp = db .specialities .Where(x => x .sId == sId) .SingleOrDefault();
            if ( sp != null )
                {
                db .specialities .Remove(sp);
                res = db .SaveChanges();
                }
            return res;
            }

        public IEnumerable<Speciality> GetAllSpecialities ()
            {
            return db .specialities .ToList();
            }

        public Speciality GetSpecialityById ( int sId )
            {
            return db .specialities .Where(x => x .sId == sId) .SingleOrDefault();
            }

        public Speciality UpdateSpecaility ( Speciality speciality )
            {
            var sp = db .specialities .Where(x => x .sId == speciality .sId) .SingleOrDefault();
            if ( sp != null )
                {
                sp .sName = speciality .sName;
                db .SaveChanges();
                }
            return sp;
            }

        }
    }
