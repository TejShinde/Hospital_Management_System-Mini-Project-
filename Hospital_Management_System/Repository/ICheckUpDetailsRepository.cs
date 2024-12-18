using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public interface ICheckUpDetailsRepository
        {
        int AddCheckUpDetails ( CheckupDetails details );
        CheckupDetails GetCheckUpDetailsById ( int cid );

        }
    }
