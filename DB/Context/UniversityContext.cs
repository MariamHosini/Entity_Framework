using DB.Modelss;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DB.Context
{
    public class UniversityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=MARIAM\\SQLEXPRESS;Database=UniverssityV2;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seading
            var _Department = new List<Department>{
             new Department { DepartmentID = 1, Name = "Computer Science", Location = "Building A" },
             new Department { DepartmentID = 2, ManagerID = 102, Name = "Mathematics", Location = "Building B" },
             new Department { DepartmentID = 3, ManagerID = 103, Name = "Physics", Location = "Building C" }};
            modelBuilder.Entity<Department>().HasData(_Department);

            var _Instructor =new List<Instructor> {
                new Instructor { ID = 101, DepartmentID = 1, FirstName = "Alice", LastName = "Johnson", Phone = "123-456-7890" },
                new Instructor { ID = 102, DepartmentID = 2, FirstName = "Bob", LastName = "Smith", Phone = "987-654-3210" },
                new Instructor { ID = 103, DepartmentID = 3, FirstName = "Charlie", LastName = "Davis", Phone = "555-666-7777" }
            };
            modelBuilder.Entity<Instructor>().HasData(_Instructor);
            
            var _Course = new List<Course> {
                new Course { ID = 1, DepartmentID = 1, InstructorID = 101, Duration = 40, Name = "C# Programming" },
                new Course { ID = 2, DepartmentID = 1, InstructorID = 101, Duration = 35, Name = "Java Programming" },
                new Course { ID = 3, DepartmentID = 2, InstructorID = 102, Duration = 30, Name = "Algebra" },
                new Course { ID = 4, DepartmentID = 3, InstructorID = 103, Duration = 45, Name = "Quantum Physics" }
            };
            modelBuilder.Entity<Course>().HasData(_Course);
            

            var _Student = new List<Student> {
                new Student { ID = 1, FirstName = "John", LastName = "Doe", Phone = "111-222-3333" },
                new Student { ID = 2, FirstName = "Jane", LastName = "Smith", Phone = "444-555-6666" },
                new Student { ID = 3, FirstName = "Michael", LastName = "Brown", Phone = "777-888-9999" },
                new Student { ID = 4, FirstName = "Emily", LastName = "Davis", Phone = "000-111-2222" }
            };
            modelBuilder.Entity<Student>().HasData(_Student);

            var _CourseStudent =  new List<Course_Student> {
                new Course_Student { CourseID = 1, StudentID = 1 },
                new Course_Student { CourseID = 1, StudentID = 2 },
                new Course_Student { CourseID = 2, StudentID = 3 },
                new Course_Student { CourseID = 3, StudentID = 4 },
                new Course_Student { CourseID = 4, StudentID = 1 },
                new Course_Student { CourseID = 4, StudentID = 2 }
            };
            modelBuilder.Entity<Course_Student>().HasData(_CourseStudent);


          var _CourseSession =  new List<CourseSession> {
                new CourseSession { Id = 1, CourseID = 1, InstructorID = 101, Date =  new DateTime(2024, 1, 1), Title = "Intro to C#" },
                new CourseSession { Id = 2, CourseID = 1, InstructorID = 101, Date = new DateTime(2024, 1, 2), Title = "Advanced C#" },
                new CourseSession { Id = 3, CourseID = 2, InstructorID = 101, Date = new DateTime(2024, 1, 3), Title = "Java Basics" },
                new CourseSession { Id = 4, CourseID = 3, InstructorID = 102, Date = new DateTime(2024, 1, 4), Title = "Linear Algebra" },
                new CourseSession { Id = 5, CourseID = 4, InstructorID = 103, Date = new DateTime(2024, 1, 5), Title = "Quantum Mechanics" }
            };
            modelBuilder.Entity<CourseSession>().HasData(_CourseSession);

          var _CourseSessionAttendance = new List<CourseSessionAttendance> {
                new CourseSessionAttendance { ID = 1, CourseSessionID = 1, StudentID = 1, Grade = 90, Note = "Excellent" },
                new CourseSessionAttendance { ID = 2, CourseSessionID = 1, StudentID = 2, Grade = 85, Note = "Good" },
                new CourseSessionAttendance { ID = 3, CourseSessionID = 2, StudentID = 1, Grade = 95, Note = "Outstanding" },
                new CourseSessionAttendance { ID = 4, CourseSessionID = 3, StudentID = 3, Grade = 80, Note = "Satisfactory" },
                new CourseSessionAttendance { ID = 5, CourseSessionID = 4, StudentID = 4, Grade = 70, Note = "Needs Improvement" }
            };
            modelBuilder.Entity<CourseSessionAttendance>().HasData(_CourseSessionAttendance);
            modelBuilder.Entity<Course_Student>().HasKey(SC=> new { SC.StudentID , SC.CourseID});
            modelBuilder.Entity<Course_Student>().Property(sc=>sc.StudentID).ValueGeneratedNever();
            modelBuilder.Entity<Course_Student>().Property(sc => sc.CourseID).ValueGeneratedNever();
            #endregion
            base.OnModelCreating(modelBuilder);
        }
       
        #region Tables
        public virtual DbSet<Department> Departments { get; set; } 
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet <Instructor> Instructors { get; set; }
        public virtual DbSet<CourseSession> CoursesSessions { get; set; }
        public virtual DbSet<Course_Student> Course_Students { get; set; }
        public virtual DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        #endregion

    }

}
