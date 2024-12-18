using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;

namespace Hospital_Management_System .Models
    {
    [Table("TimeSlot")]
    public class TimeSlot
        {
        [Key]
        public int TimeSlotID { get; set; } // Primary key
        [Required]
        public string? tslot { get; set; }
        //  public string TimeSlotDescription { get; set; } // e.g., "10:00 AM - 11:00 AM"


        //[Required]
        //public int DoctorID { get; set; }
        //[Required]
        //[Display(Name = "Start time")]
        //public DateTime St { get; set; }
        //[Required]
        //[Display(Name = "End time")]
        //public DateTime En { get; set; }
        //[Required]
        //[Display(Name = "Status")]
        //public string? Status { get; set; }

        }
    }
