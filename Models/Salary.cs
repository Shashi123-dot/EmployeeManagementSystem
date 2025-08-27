using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Salary
    {
        [Key]
        public int SalaryID { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal BasicPay { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Allowances { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Deductions { get; set; }
        [NotMapped]
        public decimal NetPay => BasicPay + Allowances - Deductions;
        [Required]
        public int SalaryMonth { get; set; } // 1-12 for Jan-Dec
        [Required]
        public int SalaryYear { get; set; } // e.g., 2025
    }
}
