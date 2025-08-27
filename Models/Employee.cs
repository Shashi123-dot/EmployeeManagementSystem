using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(70)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(70)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [ForeignKey("Department")]
        public int? DeptID { get; set; }
        public Department Department { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [Required]
        public string Status { get; set; } = "Active";
        //Navigation property
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<Salary> Salaries { get; set; }
    }
}
