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
    public partial class courSesession : Form
    {
        UniversityContext db = new UniversityContext();

        public courSesession()
        {
            InitializeComponent();
            btn_delete.Enabled = false;

            db.CoursesSessions.Load();
            dataGridView1.DataSource = db.CoursesSessions.Local.ToBindingList();
        }

        private void courSesession_Load(object sender, EventArgs e)
        {
            db.Instructors.Load();
            var lst = db.Instructors.Local
                        .Select(c => new { FullName = c.FirstName + " " + c.LastName, id = c.ID })
                        .ToList();

            Instructors.DisplayMember = "FullName";
            Instructors.ValueMember = "id";

            Instructors.DataSource = lst;

            db.Courses.Load();
            var lst2 = db.Courses.Local
                        .Select(c => new { Name = c.Name, id = c.DepartmentID })
                        .ToList();

            courses.DisplayMember = "Name";
            courses.ValueMember = "id";
            courses.DataSource = lst2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr_s_date.Text = "";
            cr_s_title.Text = "";
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            var crs = db.CoursesSessions.Local.ToBindingList().FirstOrDefault(std => std.Id == selectedID);
            db.CoursesSessions.Remove(crs);

            db.SaveChanges();
            db.CoursesSessions.Load();
            dataGridView1.DataSource = db.CoursesSessions.Local.ToBindingList();
            btn_delete.Enabled = false;

            btn_Add.Enabled = true;

            cr_s_date.Text = "";
            cr_s_title.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            var crs = db.CoursesSessions.Local.ToBindingList().FirstOrDefault(crs => crs.Id == selectedID);
            crs.Title = cr_s_title.Text;
            crs.Date = DateTime.ParseExact(cr_s_date.Text, "M/d/yyyy h:mm:ss tt", null);
            crs.CourseID = Convert.ToInt32(courses.SelectedValue);
            crs.InstructorID = Convert.ToInt32(Instructors.SelectedValue);
            db.SaveChanges();
            db.CoursesSessions.Load();
            dataGridView1.DataSource = db.CoursesSessions.Local.ToBindingList();
            btn_delete.Enabled = false;

            btn_Add.Enabled = true;

            cr_s_date.Text = "";
            cr_s_title.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var C = new CourseSession();
            C.Title = cr_s_title.Text;
            C.Date = DateTime.ParseExact(cr_s_date.Text, "d-M-yyyy", null);
            C.CourseID = Convert.ToInt32(courses.SelectedValue);
            C.InstructorID = Convert.ToInt32(Instructors.SelectedValue);
            db.CoursesSessions.Add(C);
            db.SaveChanges();
            db.CoursesSessions.Load();
            dataGridView1.DataSource = db.CoursesSessions.Local.ToBindingList();
            cr_s_date.Text = "";
            cr_s_title.Text = "";
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cr_s_date.Text = row.Cells[1].Value.ToString();
                cr_s_title.Text = row.Cells[2].Value.ToString();
                int crs_id = int.Parse(row.Cells[3].Value.ToString());
                db.Courses.Load();
                var inst = db.Courses.Local
                        .FirstOrDefault(c => c.ID == crs_id);
                courses.SelectedValue = inst.ID;

                int inst_id = int.Parse(row.Cells[5].Value.ToString());
                db.Instructors.Load();
                var dept = db.Instructors.Local
                        .FirstOrDefault(c => c.ID == inst_id);
                Instructors.SelectedValue = dept.ID;

            }
        }
    }
}
