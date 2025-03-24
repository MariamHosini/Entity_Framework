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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Form1 newForm = new Form1();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            Courses newForm = new Courses();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_Dept_Click(object sender, EventArgs e)
        {
            Departments newForm = new Departments();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_Inst_Click(object sender, EventArgs e)
        {
            Instructors newForm = new Instructors();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_Crs_Std_Click(object sender, EventArgs e)
        {
            course_student newForm = new course_student();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_Crs_Seeion_Click(object sender, EventArgs e)
        {
            courSesession newForm = new courSesession();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_crs_S_Att_Click(object sender, EventArgs e)
        {
            courseSessionAttendance newForm = new courseSessionAttendance();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(newForm);
            newForm.Show();

        }
    }
}
