using System .Collections .ObjectModel;
using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;

namespace Hospital_Management_System .Models
    {
    [Table("Doctors")]
    public class Doctor
        {
        [Key]
        [Display(Name = "Doctor Id")]
        public int DoctorID { get; set; } // Primary key

        [Required]
        public int UserID { get; set; } // Foreign key to User table

        [Required]
        [Display(Name = "Doctor Name")]
        public string? dName { get; set; }

        [Required]
        [Display(Name = "Doctor Qualification")]
        public string? Skills { get; set; }

        [Required]
        public string? dAddress { get; set; }

        [Required]
        [Display(Name = "Phone No.")]
        public string? dContact { get; set; }

        [Required]
        public int sId { get; set; }

        //[Required]
        //public string? UserName { get; set; }

        //[Required]
        //[Display(Name = " Password")]
        //[DataType(DataType .Password)]
        //public string? dPassword { get; set; }
        }
    }
