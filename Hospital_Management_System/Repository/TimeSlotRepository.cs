using Hospital_Management_System .Data;
using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public class TimeSlotRepository : ITimeSlotRepository
        {
        private readonly ApplicationDBContext db;
        public TimeSlotRepository ( ApplicationDBContext db )
            {
            this .db = db;
            }
        public int DeleteTimeSlot ( int tId )
            {
            int result = 0;
            // var slot = db.timeslots.Where()
            //  result = db.timeslots.Remove(slot);
            return result;
            }

        public IEnumerable<TimeSlot> GetTimeSlotsByDate ( string date , int DoctorID )
            {
            var availableTimeSlots = db .timeslots
                .Where(t => !db .appointments
                    .Where(a => a .Date == date && a .DoctorID == DoctorID)
                    .Select(a => a .TimeSlotID)
                    .Contains(t .TimeSlotID))
                .ToList();
            return availableTimeSlots;

            }
        }
    }
