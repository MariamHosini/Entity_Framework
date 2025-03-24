using DB;
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
    public partial class Departments : Form
    {
        UniversityContext db = new UniversityContext();
        public Departments()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            db.Departments.Load();
            dataGridView1.DataSource = db.Departments.Local.ToBindingList();
        }

        private void Departments_Load(object sender, EventArgs e)
        {


            db.Instructors.Load();
            var lst2 = db.Instructors.Local
                        .Select(c => new { Name = c.FirstName + " " + c.LastName, ID = c.ID })
                        .ToList();

            managers.DisplayMember = "Name";
            managers.ValueMember = "ID";
            managers.DataSource = lst2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Add.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dept_name.Text = row.Cells[1].Value.ToString();
                dept_location.Text = row.Cells[2].Value.ToString();

                int inst_id = int.Parse(row.Cells[3].Value.ToString());
                db.Instructors.Load();
                var inst = db.Instructors.Local
                        .FirstOrDefault(c => c.ID == inst_id);
                managers.SelectedValue = inst.ID;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dept_name.Text = "";
            dept_location.Text = "";

            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DepartmentID"].Value);
            var crs = db.Departments.Local.ToBindingList().FirstOrDefault(std => std.DepartmentID == selectedID);
            db.Departments.Remove(crs);

            db.SaveChanges();
            db.Departments.Load();
            dataGridView1.DataSource = db.Departments.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            dept_name.Text = "";
            dept_location.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var d = new Department();
            d.Name = dept_name.Text;
            d.Location = dept_location.Text;
            d.ManagerID = Convert.ToInt32(managers.SelectedValue);
            db.Departments.Add(d);
            db.SaveChanges();
            db.Departments.Load();
            dataGridView1.DataSource = db.Departments.Local.ToBindingList();
            dept_name.Text = "";
            dept_location.Text = "";
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DepartmentID"].Value);
            var dept = db.Departments.Local.ToBindingList().FirstOrDefault(crs => crs.DepartmentID == selectedID);
            dept.Name = dept_name.Text;
            dept.Location = dept_location.Text;
           
            dept.ManagerID = Convert.ToInt32(managers.SelectedValue);
            db.SaveChanges();
            db.Courses.Load();
            dataGridView1.DataSource = db.Departments.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            dept_name.Text = "";
            dept_location.Text = "";
        }
    }
}
