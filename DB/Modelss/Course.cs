using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Modelss
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public int Duration { get; set; }

        #region Have Relationship(Course , Department)
        [ForeignKey("Course")]
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        #endregion


        #region Explain Relationship (Instructor , Course)
        [ForeignKey("Instructor")]
        public int? InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        #endregion

        #region Relation many to many(Course , CourseSession)
        public ICollection<CourseSession> courseSessions { get; set; } =
            new HashSet<CourseSession>();

        #endregion

        #region Relation many to many(Course , course_Student)
        public ICollection<Course_Student>course_Students { get; set; } =
            new HashSet<Course_Student>();

        #endregion

    }
}
