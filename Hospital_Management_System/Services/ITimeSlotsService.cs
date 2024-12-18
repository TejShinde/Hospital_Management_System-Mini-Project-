using Hospital_Management_System .Models;

namespace Hospital_Management_System .Services
    {
    public interface ITimeSlotsService
        {
        IEnumerable<TimeSlot> GetTimeSlotsByDate ( string date , int DoctorID );

        int DeleteTimeSlot ( int tId );

        }
    }
