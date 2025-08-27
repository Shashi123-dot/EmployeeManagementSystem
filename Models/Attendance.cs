using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public DateTime AttendanceDate { get; set; }
        [Required]
        [MaxLength(15)]
        public string Status { get; set; } // Present, Absent,Late, Leave
    }
}
