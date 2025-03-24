namespace WindowsForm
{
    partial class course_student
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
            courses = new ComboBox();
            label1 = new Label();
            btn_delete = new Button();
            btn_Add = new Button();
            students = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // courses
            // 
            courses.FormattingEnabled = true;
            courses.Location = new Point(792, 157);
            courses.Name = "courses";
            courses.Size = new Size(121, 23);
            courses.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(664, 149);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 32;
            label1.Text = "Courses";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkRed;
            btn_delete.Font = new Font("Segoe UI", 15F);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(664, 322);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(247, 37);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.Font = new Font("Segoe UI", 15F);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(664, 244);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(247, 37);
            btn_Add.TabIndex = 29;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // students
            // 
            students.FormattingEnabled = true;
            students.Location = new Point(792, 99);
            students.Name = "students";
            students.Size = new Size(121, 23);
            students.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(664, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 34;
            label2.Text = "Students";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 428);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(666, 392);
            button1.Name = "button1";
            button1.Size = new Size(247, 37);
            button1.TabIndex = 37;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // course_student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(950, 471);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(students);
            Controls.Add(label2);
            Controls.Add(courses);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Controls.Add(btn_Add);
            Name = "course_student";
            Text = "course_student";
            Load += course_student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courses;
        private Label label1;
        private Button btn_delete;
        private Button btn_Add;
        private ComboBox students;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}