using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CancerCare.WebApp.Models
{
    public class Appointment
    {
        [DisplayName("FullName")]
        [Required]
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
