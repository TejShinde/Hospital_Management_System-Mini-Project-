using Hospital_Management_System .Data;
using Hospital_Management_System .Models;
using Microsoft .EntityFrameworkCore;
using System .Security .Cryptography;

namespace Hospital_Management_System .Repository
    {
    public class DoctorRepository : IDoctorRepository
        {
        private readonly ApplicationDBContext db;
        public DoctorRepository ( ApplicationDBContext db )
            {
            this .db = db;
            }
        public IEnumerable<Doctor> GetAllDoctors ()
            {
            return db .doctors .ToList();
            // return db .doctors .Include(d => d .UserID) .ToList();
            // Assuming RoleID = 3 represents a doctor
            }
        public int AddDoctor ( Doctor doctor )
            {
            int result = 0;
            db .doctors .Add(doctor);

            result = db .SaveChanges();
            return result;
            }

        public Doctor GetDoctorById ( int DoctorID )
            {
            return db .doctors .Where(x => x .DoctorID == DoctorID) .SingleOrDefault();
            }
        public int UpdateDoctorById ( Doctor doctor )
            {
            int res = 0;
            var doc = db .doctors .Where(x => x .DoctorID == doctor .DoctorID) .SingleOrDefault();
            if ( doc != null )
                {
                doc .dName = doctor .dName;
                doc .Skills = doctor .Skills;
                doc .dContact = doctor .dContact;
                doc .sId = doctor .sId;

                res = db .SaveChanges();
                }
            return res;
            }
        public int DeleteDoctorById ( int DoctorID )
            {
            int res = 0;
            var doc = db .doctors .Where(x => x .DoctorID == DoctorID) .SingleOrDefault();
            if ( doc != null )
                {
                db .doctors .Remove(doc);
                res = db .SaveChanges();
                }
            return res;
            }

        public int DoctorRegister ( User user )
            {
            int result = 0;
            db .Users .Add(user);
            result = db .SaveChanges();
            return result;
            }
        public bool UpdateDoctorProfile ( Doctor doctor )//*
            {
            var existingDoctor = db .doctors .FirstOrDefault(d => d .DoctorID == doctor .DoctorID);
            if ( existingDoctor != null )
                {
                existingDoctor .dName = doctor .dName;
                existingDoctor .sId = doctor .sId;
                existingDoctor .dContact = doctor .dContact;

                db .SaveChanges();
                return true;
                }
            return false;
            }
        }
    }




//public int UpdateDoctorById ( Doctor doctor )
//    {
//    int res = 0;
//    var doc = db .doctors .Where(x => x .DoctorID == doctor .DoctorID) .SingleOrDefault();
//    if ( doc != null )
//        {
//        doc .dName = doctor .dName;
//        doc .Skills = doctor .Skills;
//        doc .dContact = doctor .dContact;
//       doc .sId = doctor .sId;
//        doc .dPassword = doctor .dPassword;
//        doc .UserID = doctor .UserID;
//        res = db .SaveChanges();
//        }
//    return res;
//    }
//public int DeleteDoctorById ( int DoctorID )
//    {
//    int res = 0;
//    var doc = db .doctors .Where(x => x .DoctorID == DoctorID) .SingleOrDefault();
//    if ( doc != null )
//        {
//        db .doctors .Remove(doc);
//        res = db .SaveChanges();
//        }
//    return res;
//    }

//    public Doctor GetDoctorProfile ( int UserID )
//        {
//        return db .Doctors
//                         .FirstOrDefault(d => d .UserID == UserID);
//        }

//    }
//}
