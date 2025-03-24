namespace WindowsForm
{
    partial class Instructors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            departments = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            inst_fname = new TextBox();
            inst_phone = new TextBox();
            inst_lname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // departments
            // 
            departments.FormattingEnabled = true;
            departments.Location = new Point(743, 178);
            departments.Name = "departments";
            departments.Size = new Size(121, 23);
            departments.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(602, 173);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 40;
            label1.Text = "Departments";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 428);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(615, 401);
            button1.Name = "button1";
            button1.Size = new Size(247, 37);
            button1.TabIndex = 37;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkRed;
            btn_delete.Font = new Font("Segoe UI", 15F);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(615, 343);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(247, 37);
            btn_delete.TabIndex = 36;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Font = new Font("Segoe UI", 15F);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(615, 282);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(247, 37);
            btn_update.TabIndex = 35;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.Font = new Font("Segoe UI", 15F);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(615, 228);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(247, 37);
            btn_Add.TabIndex = 34;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(602, 128);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 33;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(600, 74);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 32;
            label4.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(598, 27);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 30;
            label2.Text = "First Name";
            // 
            // inst_fname
            // 
            inst_fname.Location = new Point(739, 32);
            inst_fname.Name = "inst_fname";
            inst_fname.Size = new Size(123, 23);
            inst_fname.TabIndex = 29;
            // 
            // inst_phone
            // 
            inst_phone.Location = new Point(741, 133);
            inst_phone.Name = "inst_phone";
            inst_phone.Size = new Size(123, 23);
            inst_phone.TabIndex = 42;
            // 
            // inst_lname
            // 
            inst_lname.Location = new Point(739, 82);
            inst_lname.Name = "inst_lname";
            inst_lname.Size = new Size(123, 23);
            inst_lname.TabIndex = 43;
            // 
            // Instructors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(907, 450);
            Controls.Add(inst_lname);
            Controls.Add(inst_phone);
            Controls.Add(departments);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(inst_fname);
            Name = "Instructors";
            Text = "Instructors";
            Load += Instructors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox departments;
        private Label label1;
        private ComboBox Departments;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_Add;
        private Label label3;
        private Label label4;
        private TextBox crs_duration;
        private Label label2;
        private TextBox inst_fname;
        private TextBox inst_phone;
        private TextBox inst_lname;
    }
}