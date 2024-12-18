using Hospital_Management_System .Data;
using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public class CheckUpRepository : ICheckUpDetailsRepository

        {
        private readonly ApplicationDBContext db;
        public CheckUpRepository ( ApplicationDBContext db )
            {
            this .db = db;
            }
        public int AddCheckUpDetails ( CheckupDetails details )
            {
            int result = 0;
            db .checkups .Add(details);
            result = db .SaveChanges();
            return result;

            }

        public CheckupDetails GetCheckUpDetailsById ( int cid )
            {
            return db .checkups .Where(x => x .cId == cid) .SingleOrDefault();
            }

        }
    }
