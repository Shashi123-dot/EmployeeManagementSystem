using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }

        [Required]
        [MaxLength(100)]
        public string DeptName { get; set; }

        [MaxLength(100)]
        public string DeptHead { get; set; }

        // Navigation property
        public ICollection<Employee> Employees { get; set; }
    }
}
