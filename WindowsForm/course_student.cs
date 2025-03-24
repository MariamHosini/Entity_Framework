using DB.Context;
using DB.Modelss;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class course_student : Form
    {
        UniversityContext db = new UniversityContext();

        public course_student()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
           
            db.Course_Students.Load();
            dataGridView1.DataSource = db.Course_Students.Local.ToBindingList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void course_student_Load(object sender, EventArgs e)
        {
            db.Students.Load();
            var lst = db.Students.Local
                        .Select(c => new { FullName = c.FirstName + " " + c.LastName, id = c.ID })
                        .ToList();

            students.DisplayMember = "FullName";
            students.ValueMember = "id";

            students.DataSource = lst;

            db.Courses.Load();
            var lst2 = db.Courses.Local
                        .Select(c => new { Name = c.Name, id = c.ID })
                        .ToList();

            courses.DisplayMember = "Name";
            courses.ValueMember = "id";
            courses.DataSource = lst2;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int selectedID1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
            int selectedID2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);

            var crs = db.Course_Students.Local.ToBindingList().FirstOrDefault(crs => crs.CourseID == selectedID2 && crs.StudentID == selectedID1);

            db.Course_Students.Remove(crs);

            db.SaveChanges();
            db.Course_Students.Load();
            dataGridView1.DataSource = db.Course_Students.Local.ToBindingList();
            btn_delete.Enabled = false;
            
            btn_Add.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = true;
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int crs_id = int.Parse(row.Cells[0].Value.ToString());
                db.Courses.Load();
                var inst = db.Courses.Local
                        .FirstOrDefault(c => c.ID == crs_id);
                courses.SelectedValue = inst.ID;

                int std_id = int.Parse(row.Cells[2].Value.ToString());
                db.Students.Load();
                var dept = db.Students.Local
                        .FirstOrDefault(c => c.ID == std_id);
                students.SelectedValue = dept.ID;


            }
        }

        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var C = new Course_Student();

            C.CourseID = Convert.ToInt32(courses.SelectedValue);
            C.StudentID = Convert.ToInt32(students.SelectedValue);
            db.Course_Students.Add(C);
            db.SaveChanges();
            db.Course_Students.Load();
            dataGridView1.DataSource = db.Course_Students.Local.ToBindingList();

            btn_delete.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.CellClick -= dataGridView1_CellClick;
            btn_delete.Enabled = false;
           
            btn_Add.Enabled = true;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }
    }
}
