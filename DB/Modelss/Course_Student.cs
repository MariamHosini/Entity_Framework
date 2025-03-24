using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Modelss
{
    public class Course_Student
    {
        [ForeignKey("Course")]
        public int? CourseID { get; set; }
        public Course course { get; set; }
        [ForeignKey("Student")]
        public int? StudentID { get; set; }
        public Student student { get; set; }

    }
}
