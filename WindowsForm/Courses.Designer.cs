namespace WindowsForm
{
    partial class Courses
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
            button1 = new Button();
            btn_delete = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label4 = new Label();
            crs_duration = new TextBox();
            label2 = new Label();
            crs_name = new TextBox();
            dataGridView1 = new DataGridView();
            Departments = new ComboBox();
            Instructors = new ComboBox();
            label1 = new Label();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(622, 412);
            button1.Name = "button1";
            button1.Size = new Size(247, 37);
            button1.TabIndex = 24;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkRed;
            btn_delete.Font = new Font("Segoe UI", 15F);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(622, 369);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(247, 37);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.Font = new Font("Segoe UI", 15F);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(624, 261);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(247, 37);
            btn_Add.TabIndex = 21;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(609, 139);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 20;
            label3.Text = "Departments";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(607, 85);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 18;
            label4.Text = "Duration";
            // 
            // crs_duration
            // 
            crs_duration.Location = new Point(748, 90);
            crs_duration.Name = "crs_duration";
            crs_duration.Size = new Size(123, 23);
            crs_duration.TabIndex = 17;
            crs_duration.TextChanged += crs_duration_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(605, 38);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // crs_name
            // 
            crs_name.Location = new Point(746, 43);
            crs_name.Name = "crs_name";
            crs_name.Size = new Size(123, 23);
            crs_name.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 428);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Departments
            // 
            Departments.FormattingEnabled = true;
            Departments.Location = new Point(750, 144);
            Departments.Name = "Departments";
            Departments.Size = new Size(121, 23);
            Departments.TabIndex = 26;
            // 
            // Instructors
            // 
            Instructors.FormattingEnabled = true;
            Instructors.Location = new Point(750, 189);
            Instructors.Name = "Instructors";
            Instructors.Size = new Size(121, 23);
            Instructors.TabIndex = 28;
            Instructors.SelectedIndexChanged += Instructors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(609, 184);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 27;
            label1.Text = "Instructors";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Font = new Font("Segoe UI", 15F);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(622, 311);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(247, 37);
            btn_update.TabIndex = 29;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click_1;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(963, 469);
            Controls.Add(btn_update);
            Controls.Add(Instructors);
            Controls.Add(label1);
            Controls.Add(Departments);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(crs_duration);
            Controls.Add(label2);
            Controls.Add(crs_name);
            Name = "Courses";
            Text = "Courses";
            Load += Courses_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_delete;
        private Button btn_Add;
        private Label label3;
        private Label label4;
        private TextBox crs_duration;
        private Label label2;
        private TextBox crs_name;
        private DataGridView dataGridView1;
        private ComboBox Departments;
        private ComboBox Instructors;
        private Label label1;
        private Button btn_update;
    }
}