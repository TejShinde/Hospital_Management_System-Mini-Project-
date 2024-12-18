using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;

namespace Hospital_Management_System .Models
    {
    [Table("Roles")]
    public class Role
        {
        [Key]
        public int RoleID { get; set; }

        [Required]
        public string? RoleName { get; set; } // Admin, Doctor, Patient
        }
    }
