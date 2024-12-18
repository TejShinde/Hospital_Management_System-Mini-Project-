﻿using Hospital_Management_System .Models;

namespace Hospital_Management_System .Services
    {
    public interface ISpecialityService
        {
        int AddSpeciality ( Speciality speciality );

        int DeleteSpeciality ( int sId );
        IEnumerable<Speciality> GetAllSpecialities ();
       
        Speciality GetSpecialityById ( int sId );

        Speciality UpdateSpecaility ( Speciality speciality );
        }
    }