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
    public class Department
    {
      
        public int DepartmentID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Location { get; set; }

        #region Manage Relationship(Instructor , Department)

        [ForeignKey("Instructor")]
        public int? ManagerID { get; set; }
        
        #endregion

        #region Have Relationship(Instructor , Department)
        public ICollection<Instructor> instructors { get; set; } =new HashSet<Instructor>();
        #endregion

        #region Have Relationship(Course , Department)

        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
        #endregion
    }
}
