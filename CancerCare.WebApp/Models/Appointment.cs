using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CancerCare.WebApp.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User user { get; set; }
        [Required]
        [DisplayName("Full Name")]

        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int TelNo { get; set; }
        [Required]
        [DisplayName("Doctor Name")]
        public string DoctorName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } = "Scheduled";
    }
}
