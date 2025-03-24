using DB;
using DB.Context;
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
    public partial class Instructors : Form
    {
        UniversityContext db = new UniversityContext();

        public Instructors()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            db.Instructors.Load();
            dataGridView1.DataSource = db.Instructors.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Instructors_Load(object sender, EventArgs e)
        {
            db.Departments.Load();
            var lst2 = db.Departments.Local
                        .Select(c => new { Name = c.Name, ID = c.DepartmentID })
                        .ToList();

            departments.DisplayMember = "Name";
            departments.ValueMember = "ID";
            departments.DataSource = lst2;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                inst_fname.Text = row.Cells[1].Value.ToString();
                inst_lname.Text = row.Cells[2].Value.ToString();

                inst_phone.Text = row.Cells[3].Value.ToString();

                int dept_id = int.Parse(row.Cells[4].Value.ToString());
                db.Departments.Load();
                var inst = db.Departments.Local
                        .FirstOrDefault(c => c.DepartmentID == dept_id);
                departments.SelectedValue = inst.DepartmentID;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            inst_fname.Text = "";
            inst_lname.Text = "";
            inst_phone.Text = "";
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var crs = db.Instructors.Local.ToBindingList().FirstOrDefault(std => std.ID == selectedID);
            db.Instructors.Remove(crs);

            db.SaveChanges();
            db.Departments.Load();
            dataGridView1.DataSource = db.Instructors.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            inst_fname.Text = "";
            inst_lname.Text = "";
            inst_phone.Text = "";

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var dept = db.Instructors.Local.ToBindingList().FirstOrDefault(crs => crs.ID == selectedID);
            dept.FirstName = inst_fname.Text;
            dept.LastName = inst_lname.Text;
            dept.Phone = inst_phone.Text;


            dept.DepartmentID = Convert.ToInt32(departments.SelectedValue);
            db.SaveChanges();
            db.Courses.Load();
            dataGridView1.DataSource = db.Instructors.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            inst_fname.Text = "";
            inst_lname.Text = "";
            inst_phone.Text = "";

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var d = new Instructor();
            d.FirstName = inst_fname.Text;
            d.LastName = inst_lname.Text;
            d.Phone = inst_phone.Text;

            d.DepartmentID = Convert.ToInt32(departments.SelectedValue);
            db.Instructors.Add(d);
            db.SaveChanges();
            db.Instructors.Load();
            dataGridView1.DataSource = db.Instructors.Local.ToBindingList();
            inst_fname.Text = "";
            inst_lname.Text = "";
            inst_phone.Text = "";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }
    }
}
