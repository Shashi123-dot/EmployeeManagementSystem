using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Salary> Salarys { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // Unique constraint for Attendance (one record per employee per day)
            modelBuilder.Entity<Attendance>()
                .HasIndex(a => new { a.EmployeeID, a.AttendanceDate })
                .IsUnique();

            // Unique constraint for Salary (one record per employee per month/year)
            modelBuilder.Entity<Salary>()
                .HasIndex(s => new { s.EmployeeID, s.SalaryMonth, s.SalaryYear })
                .IsUnique();
        }
    } 
}
