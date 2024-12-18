using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;

namespace Hospital_Management_System .Models
    {
    [Table("Appointment")]

    public class Appointment
        {
        [Key]
        public int AppointmentID { get; set; } // Primary key
       
        [Required]
        public int UserID { get; set; } // Foreign key to User table

        [Required]
        public int DoctorID { get; set; } // Foreign key to Doctor table

        [Required]
        public int PatientID { get; set; } //Foreign key to Patient table

        [Required]
        public int sId { get; set; }

        [Required]
        public string? Date { get; set; }

        [Required]
        public int TimeSlotID { get; set; } // Foreign key to TimeSlot table
        public string? Status { get; set; } // Example: "Pending", "Confirmed", "Completed"

        [Required]
        [Display(Name = "Comment")]
        public string? Comment { get; set; }

        [NotMapped]
        [Display(Name = "Patient Name")]
        public string? pName { get; set; }

        [NotMapped]
        [Display(Name = "Time Slot")]
        public string? tslot { get; set; }
        [NotMapped]
        [Display(Name = "SPeciality Name")]
        public string? sName { get; set; }
        [NotMapped]
        [Display(Name = "Doctor Name")]
        public string? dName { get; set; }


        }
    }
