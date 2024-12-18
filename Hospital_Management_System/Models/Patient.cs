using System .Collections .ObjectModel;
using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;
using System .Reflection;

namespace Hospital_Management_System .Models
    {

    [Table("Patients")]
    public class Patient
        {

        [Key]
        [Display(Name = "Patient Id")]
        public int PatientID { get; set; } // Primary key

        [Required]
        public int UserID { get; set; } // Foreign key to User table

        [Required]
        [Display(Name = "Patient Name")]
        public string? pName { get; set; }

        [Required]
        [Display(Name = "Patient Address")]
        public string? pAddress { get; set; }

        [Required]
        [Display(Name = "Phone No.")]
        public string? pContact { get; set; }

        [Required]
        [Display(Name = "Patient Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Patient Gender")]
        public string? Gender { get; set; }
       
        [Required]
        [Display(Name = "Patient Blood Group")]
        public string? BloodGroup { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType .Password)]
        public string? pPassword { get; set; }

        [Required]
        public int sId { get; set; }
        [NotMapped]
        public string? sName { get; set; }

        }
    }
