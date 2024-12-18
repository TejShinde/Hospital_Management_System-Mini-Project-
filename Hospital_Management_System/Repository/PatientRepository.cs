using System .Collections .Generic;
using System .Linq;
using Hospital_Management_System .Data;
using Hospital_Management_System .Models;
using Microsoft .EntityFrameworkCore;

namespace Hospital_Management_System .Repository
    {
    public class PatientRepository : IPatientRepository
        {
        private readonly ApplicationDBContext _context;

        public PatientRepository ( ApplicationDBContext context )
            {
            _context = context;
            }
        public int PatientRegistration ( Patient patient )
            {
            int res = 0;
            _context .patients .Add(patient);
            res = _context .SaveChanges();
            return res;

            }

        // Update Patient Profile
        public bool UpdatePatientProfile ( Patient patient )//*
            {
            var existingPatient = _context .patients
                .FirstOrDefault(p => p .PatientID == patient .PatientID);

            if ( existingPatient == null )
                return false;

            existingPatient .pName = patient .pName;
            existingPatient .Age = patient .Age;
            existingPatient .pContact = patient .pContact;
            existingPatient .pAddress = patient .pAddress;
            existingPatient .BloodGroup = patient .BloodGroup;
            existingPatient .Gender = patient .Gender;

            _context .SaveChanges();
            return true;
            }
        }
    }
