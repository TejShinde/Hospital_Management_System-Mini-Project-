using Hospital_Management_System .Models;
using Hospital_Management_System .Repository;
using System .Data;
using Microsoft .AspNetCore .Http;

namespace Hospital_Management_System .Services
    {
    public class UserService : IUserService

        {
        private readonly IUserRepository repo;
        // private readonly IHttpContextAccessor _httpContextAccessor;  // Inject IHttpContextAccessor

        public UserService ( IUserRepository repo )
            {
            this .repo = repo;
            }

        public User UserLogin ( User u )
            {
            return repo .UserLogin(u);
            }


        public IEnumerable<Role> GetAllRoles ()
            {
            return repo .GetAllRoles();
            }

        public int UserRegistration ( User user )
            {
            return repo .UserRegistration(user);
            }

        public IEnumerable<User> GetAllUsers ()
            {
            return repo .GetAllUsers();
            }
        }
    }
