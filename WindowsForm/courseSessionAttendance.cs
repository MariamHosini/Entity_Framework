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
    public partial class courseSessionAttendance : Form
    {
        UniversityContext db = new UniversityContext();

        public courseSessionAttendance()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            db.CourseSessionAttendances.Load();
            dataGridView1.DataSource = db.CourseSessionAttendances.Local.ToBindingList();
        }

        private void courseSessionAttendance_Load(object sender, EventArgs e)
        {
            db.Students.Load();
            var lst = db.Students.Local
                        .Select(c => new { FullName = c.FirstName + " " + c.LastName, id = c.ID })
                        .ToList();

            students.DisplayMember = "FullName";
            students.ValueMember = "id";

            students.DataSource = lst;

            db.CoursesSessions.Load();
            var lst2 = db.CoursesSessions.Local
                        .Select(c => new { Name = c.Title, id = c.Id })
                        .ToList();

            crs_session.DisplayMember = "Name";
            crs_session.ValueMember = "id";
            crs_session.DataSource = lst2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                grade.Text = row.Cells[1].Value.ToString();
                note.Text = row.Cells[2].Value.ToString();
                int std_id = int.Parse(row.Cells[5].Value.ToString());
                db.Students.Load();
                var inst = db.Students.Local
                        .FirstOrDefault(c => c.ID == std_id);
                students.SelectedValue = inst.ID;

                int dept_id = int.Parse(row.Cells[3].Value.ToString());
                db.CoursesSessions.Load();
                var dept = db.CoursesSessions.Local
                        .FirstOrDefault(c => c.Id == dept_id);
                crs_session.SelectedValue = dept.Id;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            note.Text = "";
            grade.Text = "";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var crs = db.CourseSessionAttendances.Local.ToBindingList().FirstOrDefault(std => std.ID == selectedID);
            db.CourseSessionAttendances.Remove(crs);

            db.SaveChanges();
            db.CourseSessionAttendances.Load();
            dataGridView1.DataSource = db.CourseSessionAttendances.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            note.Text = "";
            grade.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var crs = db.CourseSessionAttendances.Local.ToBindingList().FirstOrDefault(crs => crs.ID == selectedID);
            crs.Note = note.Text;
            crs.Grade = int.Parse(grade.Text);
            crs.StudentID = Convert.ToInt32(students.SelectedValue);
            crs.CourseSessionID = Convert.ToInt32(crs_session.SelectedValue);
            db.SaveChanges();
            db.CourseSessionAttendances.Load();
            dataGridView1.DataSource = db.CourseSessionAttendances.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            note.Text = "";
            grade.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var C = new CourseSessionAttendance();
            C.Note = note.Text;
            C.Grade = int.Parse(grade.Text);
            C.StudentID = Convert.ToInt32(students.SelectedValue);
            C.CourseSessionID = Convert.ToInt32(crs_session.SelectedValue);
            db.CourseSessionAttendances.Add(C);
            db.SaveChanges();
            db.CourseSessionAttendances.Load();
            dataGridView1.DataSource = db.CourseSessionAttendances.Local.ToBindingList();
            note.Text = "";
            grade.Text = "";
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }
    }
}
