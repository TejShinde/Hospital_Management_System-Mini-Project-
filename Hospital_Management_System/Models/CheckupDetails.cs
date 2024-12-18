using System .ComponentModel .DataAnnotations;
using System .ComponentModel .DataAnnotations .Schema;

namespace Hospital_Management_System .Models
    {
    [Table("checkupdetails")]
    public class CheckupDetails
        {
        [Key]
        public int cId { get; set; }
        [Required]
        public int aId { get; set; }
        [Required]
        public int height { get; set; }
        [Required]
        public int weight { get; set; }
        [Required]
        public string? bloodGrp { get; set; }
        [Required]
        public string? issue { get; set; }
        [Required]
        public string? medicine { get; set; }
        [Required]
        public string? aNDate { get; set; }

        }
    }
