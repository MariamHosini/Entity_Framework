using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Modelss
{
    public class CourseSessionAttendance
    {
        [Key]
        public int ID { get; set; }
        public int Grade { get; set;}
        public string Note { get; set; }

        [ForeignKey("CourseSession")]
        public int? CourseSessionID { get; set; }
        public CourseSession CourseSession { get; set; }

        [ForeignKey("Student")]
        public int? StudentID { get; set; }
        public Student student { get; set; }


    }
}
