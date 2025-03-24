using DB.Modelss;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string Phone { get; set; }


        #region Manage Relationship (Instructor , Department)  & Having
        [ForeignKey("Deparment")]
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        #endregion

        #region Explain Relationship (Instructor , Course)
        public ICollection<Course> courses { get; set; }= new HashSet<Course>();
        #endregion

        #region Relation many to many(Course , Instructor)

        public ICollection<CourseSession> courseSessions { get; set; } =
            new HashSet<CourseSession>();

        #endregion
    }
}
