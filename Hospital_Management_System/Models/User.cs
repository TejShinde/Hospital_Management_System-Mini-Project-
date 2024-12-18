using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;
using System .Data;


namespace Hospital_Management_System .Models
    {
    [Table("Users")]
    public class User
        {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]

        [DataType(DataType .Password)]
        public string? Password { get; set; }

        [Required]
        public int RoleID { get; set; } // Foreign key to Role table

        }
    }
