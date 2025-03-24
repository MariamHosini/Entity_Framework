namespace WindowsForm
{
    partial class courSesession
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
            btn_update = new Button();
            Instructors = new ComboBox();
            label1 = new Label();
            courses = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btn_delete = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label4 = new Label();
            cr_s_title = new TextBox();
            label2 = new Label();
            cr_s_date = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Font = new Font("Segoe UI", 15F);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(623, 302);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(247, 37);
            btn_update.TabIndex = 42;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // Instructors
            // 
            Instructors.FormattingEnabled = true;
            Instructors.Location = new Point(751, 180);
            Instructors.Name = "Instructors";
            Instructors.Size = new Size(121, 23);
            Instructors.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(610, 175);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 40;
            label1.Text = "Instructors";
            // 
            // courses
            // 
            courses.FormattingEnabled = true;
            courses.Location = new Point(751, 135);
            courses.Name = "courses";
            courses.Size = new Size(121, 23);
            courses.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 428);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(623, 403);
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
            btn_delete.Location = new Point(623, 360);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(247, 37);
            btn_delete.TabIndex = 36;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.Font = new Font("Segoe UI", 15F);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(625, 252);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(247, 37);
            btn_Add.TabIndex = 35;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(610, 130);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 34;
            label3.Text = "Courses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(608, 76);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 33;
            label4.Text = "Title";
            // 
            // cr_s_title
            // 
            cr_s_title.Location = new Point(749, 81);
            cr_s_title.Name = "cr_s_title";
            cr_s_title.Size = new Size(123, 23);
            cr_s_title.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(606, 29);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 31;
            label2.Text = "Date";
            // 
            // cr_s_date
            // 
            cr_s_date.Location = new Point(747, 34);
            cr_s_date.Name = "cr_s_date";
            cr_s_date.Size = new Size(123, 23);
            cr_s_date.TabIndex = 30;
            // 
            // courSesession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(932, 450);
            Controls.Add(btn_update);
            Controls.Add(Instructors);
            Controls.Add(label1);
            Controls.Add(courses);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cr_s_title);
            Controls.Add(label2);
            Controls.Add(cr_s_date);
            Name = "courSesession";
            Text = "courSesession";
            Load += courSesession_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private ComboBox Instructors;
        private Label label1;
        private ComboBox courses;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_delete;
        private Button btn_Add;
        private Label label3;
        private Label label4;
        private TextBox cr_s_title;
        private Label label2;
        private TextBox cr_s_date;
    }
}