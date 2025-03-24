using DB.Context;
using DB.Modelss;
using Microsoft.EntityFrameworkCore;
namespace WindowsForm
{
    public partial class Form1 : Form
    {
        UniversityContext db = new UniversityContext();
        public Form1()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            db.Students.Load();
            dataGridView1.DataSource = db.Students.Local.ToBindingList();

        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var std = new Student();

            std.FirstName = std_Fname.Text;
            std.LastName = std_Lname.Text;
            std.Phone = std_Phone.Text;
            db.Students.Add(std);
            db.SaveChanges();
            db.Students.Load();
            dataGridView1.DataSource = db.Students.Local.ToBindingList();

            std_Fname.Text = "";
            std_Lname.Text = "";
            std_Phone.Text = "";
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
                std_Fname.Text = row.Cells[1].Value.ToString();
                std_Lname.Text = row.Cells[2].Value.ToString();
                std_Phone.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var std = db.Students.Local.ToBindingList().FirstOrDefault(std => std.ID == selectedID);
            std.FirstName = std_Fname.Text;
            std.LastName = std_Lname.Text;
            std.Phone = std_Phone.Text;

            db.SaveChanges();
            db.Students.Load();
            dataGridView1.DataSource = db.Students.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            std_Fname.Text = "";
            std_Lname.Text = "";
            std_Phone.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var std = db.Students.Local.ToBindingList().FirstOrDefault(std => std.ID == selectedID);
            db.Students.Remove(std);

            db.SaveChanges();
            db.Students.Load();
            dataGridView1.DataSource = db.Students.Local.ToBindingList();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;

            std_Fname.Text = "";
            std_Lname.Text = "";
            std_Phone.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            std_Fname.Text = "";
            std_Lname.Text = "";
            std_Phone.Text = "";
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_Add.Enabled = true;
        }
    }
}
