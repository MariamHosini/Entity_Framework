namespace WindowsForm
{
    partial class courseSessionAttendance
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
            label1 = new Label();
            students = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btn_delete = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label4 = new Label();
            note = new TextBox();
            label2 = new Label();
            grade = new TextBox();
            crs_session = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Font = new Font("Segoe UI", 15F);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(627, 312);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(247, 37);
            btn_update.TabIndex = 42;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(614, 185);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 40;
            label1.Text = "Course Session";
            // 
            // students
            // 
            students.FormattingEnabled = true;
            students.Location = new Point(755, 145);
            students.Name = "students";
            students.Size = new Size(121, 23);
            students.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 22);
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
            button1.Location = new Point(627, 413);
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
            btn_delete.Location = new Point(627, 370);
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
            btn_Add.Location = new Point(629, 262);
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
            label3.Location = new Point(614, 140);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 34;
            label3.Text = "Students";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(612, 86);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 33;
            label4.Text = "Note";
            // 
            // note
            // 
            note.Location = new Point(753, 91);
            note.Name = "note";
            note.Size = new Size(123, 23);
            note.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(610, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 31;
            label2.Text = "Grade";
            // 
            // grade
            // 
            grade.Location = new Point(751, 44);
            grade.Name = "grade";
            grade.Size = new Size(123, 23);
            grade.TabIndex = 30;
            // 
            // crs_session
            // 
            crs_session.FormattingEnabled = true;
            crs_session.Location = new Point(755, 190);
            crs_session.Name = "crs_session";
            crs_session.Size = new Size(121, 23);
            crs_session.TabIndex = 41;
            // 
            // courseSessionAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(928, 471);
            Controls.Add(btn_update);
            Controls.Add(crs_session);
            Controls.Add(label1);
            Controls.Add(students);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(note);
            Controls.Add(label2);
            Controls.Add(grade);
            Name = "courseSessionAttendance";
            Text = "courseSessionAttendance";
            Load += courseSessionAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private Label label1;
        private ComboBox students;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_delete;
        private Button btn_Add;
        private Label label3;
        private Label label4;
        private TextBox note;
        private Label label2;
        private TextBox grade;
        private ComboBox crs_session;
    }
}