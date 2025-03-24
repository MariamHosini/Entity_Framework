using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Modelss
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string Phone { get; set; }

        #region Relation many to many(student , course_Student)
        public ICollection<Course_Student> course_Students { get; set; } =
            new HashSet<Course_Student>();

        #endregion

        #region Relation many to many(Student , CourseSessionAttendance)

        public ICollection<CourseSessionAttendance> Attendances { get; set; } =
            new HashSet<CourseSessionAttendance>();
        #endregion
    }
}
