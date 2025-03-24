using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Modelss
{
    public class CourseSession
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }

        #region Relation many to many(Course , Instructor)

        [ForeignKey("Course")]
        public int? CourseID { get; set; }
        public Course course { get; set; }

        [ForeignKey("Instructor")]
        public int? InstructorID { get; set; }
        public Instructor Instructor { get; set; }


        #endregion

        #region Relation many to many(CourseSession , CourseSessionAttendance)

        public ICollection<CourseSessionAttendance> Attendances { get; set; } = 
            new HashSet<CourseSessionAttendance>();    
        #endregion
    }
}
