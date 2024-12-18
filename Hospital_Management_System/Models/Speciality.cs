using System .ComponentModel .DataAnnotations .Schema;
using System .ComponentModel .DataAnnotations;

namespace Hospital_Management_System .Models
    {
    [Table("speciality")]
    public class Speciality
        {
        [Key]
        public int sId { get; set; }
        [Required]
        public string? sName { get; set; }
        }
    }
