using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public interface ITimeSlotRepository
        {
        IEnumerable<TimeSlot> GetTimeSlotsByDate ( string date , int DoctorID );
        int DeleteTimeSlot ( int tId );

        }
    }
