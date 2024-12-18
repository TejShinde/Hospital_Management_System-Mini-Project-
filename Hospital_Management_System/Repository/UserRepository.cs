using Hospital_Management_System .Data;
using Hospital_Management_System .Models;

namespace Hospital_Management_System .Repository
    {
    public class UserRepository : IUserRepository
        {
        private readonly ApplicationDBContext db;
        public UserRepository ( ApplicationDBContext db )
            {
            this .db = db;
            }

        public User UserLogin ( User u )
            {
            var model = db .Users .Where(x => x .UserName == u .UserName && x .Password == u .Password) .SingleOrDefault();
            return model;
            }
        public IEnumerable<Role> GetAllRoles ()
            {
            return db .roles .ToList();
            }

        public int UserRegistration ( User user )
            {
            int result = 0;
            db .Users .Add(user);

            result= db .SaveChanges();
            return result;

            }

        public IEnumerable<User> GetAllUsers ()
            {
            return db .Users .Where(x => x .RoleID == 3) .ToList();

            }
        }
    }

