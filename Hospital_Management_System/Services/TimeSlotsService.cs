using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;

namespace Hospital_Management_System .Services
    {
    public class TimeSlotsService : ITimeSlotsService

        {
        private readonly ITimeSlotRepository repo;
        public TimeSlotsService ( ITimeSlotRepository repo )
            {
            this .repo = repo;
            }
        public int DeleteTimeSlot ( int tId )
            {
            return repo .DeleteTimeSlot(tId);
            }

        public IEnumerable<TimeSlot> GetTimeSlotsByDate ( string date , int DoctorID )
            {
            return repo .GetTimeSlotsByDate(date , DoctorID);
            }

        }
    }
