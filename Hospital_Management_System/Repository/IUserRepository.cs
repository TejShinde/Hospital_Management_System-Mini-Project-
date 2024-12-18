using Hospital_Management_System .Models;
using System .Data;

namespace Hospital_Management_System .Repository
    {
    public interface IUserRepository
        {
        User UserLogin ( User u );
        IEnumerable<Role> GetAllRoles ();
        int UserRegistration ( User user );
        IEnumerable<User> GetAllUsers ();//frm admin

        }
    }
