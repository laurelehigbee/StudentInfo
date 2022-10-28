using System;
using Microsoft.EntityFrameworkCore;

namespace StudentInfo.Models
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : base (options)
        {

        }

        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpPosition> EmpPositions { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<SemesterJob> SemesterJobs { get; set; }
        public DbSet<StudentJob> StudentJobs { get; set; }
        public DbSet<WageChange> WageChanges { get; set; }
    }
}
