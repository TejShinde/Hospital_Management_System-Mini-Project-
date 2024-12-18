using Hospital_Management_System .Models;
using Microsoft .EntityFrameworkCore;
using System .Collections .Generic;
using System .Data;

namespace Hospital_Management_System .Data
    {
    public class ApplicationDBContext : DbContext

        {
        //override configuration that we need at app level
        public ApplicationDBContext ( DbContextOptions<ApplicationDBContext> options ) : base(options)

            {
            }
        public DbSet<Speciality> specialities { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TimeSlot> timeslots { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<CheckupDetails> checkups { get; set; }

        }
    }
