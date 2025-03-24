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
    public partial class Courses : Form
    {
        UniversityContext db = new UniversityContext();

        public Courses()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            db.Courses.Load();
            dataGridView1.DataSource = db.Courses.Local.ToBindingList();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            db.Instructors.Load();
            var lst = db.Instructors.Local
                        .Select(c => new { FullName = c.FirstName + " " + c.LastName, id = c.ID })
                        .ToList();

            Instructors.DisplayMember = "FullName";
            Instructors.ValueMember = "id";

            Instructors.DataSource = lst;

            db.Departments.Load();
            var lst2 = db.Departments.Local
                        .Select(c => new { Name = c.Name, id = c.DepartmentID })
                        .ToList();

            Departments.DisplayMember = "Name";
            Departments.ValueMember = "id";
            Departments.DataSource = lst2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                crs_name.Text = row.Cells[1].Value.ToString();
                crs_duration.Text = row.Cells[2].Value.ToString();
                int inst_id = int.Parse(row.Cells[5].Value.ToString());
                db.Instructors.Load();
                var inst = db.Instructors.Local
                        .FirstOrDefault(c => c.ID == inst_id);
                Instructors.SelectedValue = inst.ID;

                int dept_id = int.Parse(row.Cells[3].Value.ToString());
                db.Departments.Load();
                var dept = db.Departments.Local
                        .FirstOrDefault(c => c.DepartmentID == dept_id);
                Departments.SelectedValue = dept.DepartmentID;

            }
        }

        private void Instructors_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var C = new Course();
            C.Name = crs_name.Text;
            C.Duration = int.Parse(crs_duration.Text);
            C.DepartmentID = Convert.ToInt32(Departments.SelectedValue);
            C.InstructorID = Convert.ToInt32(Instructors.SelectedValue);
            db.Courses.Add(C);
            db.SaveChanges();
            db.Courses.Load();
            dataGridView1.DataSource = db.Courses.Local.ToBindingList();
            crs_name.Text = "";
            crs_duration.Text = "";
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

        }

        private void crs_duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var crs = db.Courses.Local.ToBindingList().FirstOrDefault(std => std.ID == selectedID);
            db.Courses.Remove(crs);

            db.SaveChanges();
            db.Courses.Load();
            dataGridView1.DataSource = db.Courses.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            crs_name.Text = "";
            crs_duration.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crs_name.Text = "";
            crs_duration.Text = "";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var crs = db.Courses.Local.ToBindingList().FirstOrDefault(crs => crs.ID == selectedID);
            crs.Name = crs_name.Text;
            crs.Duration = int.Parse(crs_duration.Text);
            crs.DepartmentID = Convert.ToInt32(Departments.SelectedValue);
            crs.InstructorID = Convert.ToInt32(Instructors.SelectedValue);
            db.SaveChanges();
            db.Courses.Load();
            dataGridView1.DataSource = db.Courses.Local.ToBindingList();
            btn_delete.Enabled = false;

            btn_Add.Enabled = true;
            btn_update.Enabled=false;
            crs_name.Text = "";
            crs_duration.Text = "";
        }
    }
}
