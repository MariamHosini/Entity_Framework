namespace WindowsForm
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            btn_courses = new Button();
            btn_Dept = new Button();
            btn_Inst = new Button();
            btn_Crs_Std = new Button();
            btn_crs_S_Att = new Button();
            btn_Crs_Seeion = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(420, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 519);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(414, 38);
            label1.TabIndex = 2;
            label1.Text = "University Managment System";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(60, 107);
            button1.Name = "button1";
            button1.Size = new Size(285, 49);
            button1.TabIndex = 0;
            button1.Text = "Students";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_courses
            // 
            btn_courses.BackColor = Color.LightSeaGreen;
            btn_courses.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_courses.ForeColor = SystemColors.ControlLightLight;
            btn_courses.Location = new Point(60, 179);
            btn_courses.Name = "btn_courses";
            btn_courses.Size = new Size(285, 49);
            btn_courses.TabIndex = 3;
            btn_courses.Text = "Courses";
            btn_courses.UseVisualStyleBackColor = false;
            btn_courses.Click += btn_courses_Click;
            // 
            // btn_Dept
            // 
            btn_Dept.BackColor = Color.LightSeaGreen;
            btn_Dept.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Dept.ForeColor = SystemColors.ControlLightLight;
            btn_Dept.Location = new Point(60, 251);
            btn_Dept.Name = "btn_Dept";
            btn_Dept.Size = new Size(285, 49);
            btn_Dept.TabIndex = 4;
            btn_Dept.Text = "Departments";
            btn_Dept.UseVisualStyleBackColor = false;
            btn_Dept.Click += btn_Dept_Click;
            // 
            // btn_Inst
            // 
            btn_Inst.BackColor = Color.LightSeaGreen;
            btn_Inst.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Inst.ForeColor = SystemColors.ControlLightLight;
            btn_Inst.Location = new Point(60, 318);
            btn_Inst.Name = "btn_Inst";
            btn_Inst.Size = new Size(285, 49);
            btn_Inst.TabIndex = 5;
            btn_Inst.Text = "Instructors";
            btn_Inst.UseVisualStyleBackColor = false;
            btn_Inst.Click += btn_Inst_Click;
            // 
            // btn_Crs_Std
            // 
            btn_Crs_Std.BackColor = Color.LightSeaGreen;
            btn_Crs_Std.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Crs_Std.ForeColor = SystemColors.ControlLightLight;
            btn_Crs_Std.Location = new Point(60, 389);
            btn_Crs_Std.Name = "btn_Crs_Std";
            btn_Crs_Std.Size = new Size(285, 49);
            btn_Crs_Std.TabIndex = 6;
            btn_Crs_Std.Text = "Courses_Students";
            btn_Crs_Std.UseVisualStyleBackColor = false;
            btn_Crs_Std.Click += btn_Crs_Std_Click;
            // 
            // btn_crs_S_Att
            // 
            btn_crs_S_Att.BackColor = Color.LightSeaGreen;
            btn_crs_S_Att.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_crs_S_Att.ForeColor = SystemColors.ControlLightLight;
            btn_crs_S_Att.Location = new Point(60, 469);
            btn_crs_S_Att.Name = "btn_crs_S_Att";
            btn_crs_S_Att.Size = new Size(285, 49);
            btn_crs_S_Att.TabIndex = 7;
            btn_crs_S_Att.Text = "Course_Session_Attendance";
            btn_crs_S_Att.UseVisualStyleBackColor = false;
            btn_crs_S_Att.Click += btn_crs_S_Att_Click;
            // 
            // btn_Crs_Seeion
            // 
            btn_Crs_Seeion.BackColor = Color.LightSeaGreen;
            btn_Crs_Seeion.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Crs_Seeion.ForeColor = SystemColors.ControlLightLight;
            btn_Crs_Seeion.Location = new Point(60, 536);
            btn_Crs_Seeion.Name = "btn_Crs_Seeion";
            btn_Crs_Seeion.Size = new Size(285, 49);
            btn_Crs_Seeion.TabIndex = 8;
            btn_Crs_Seeion.Text = "Course_Session";
            btn_Crs_Seeion.UseVisualStyleBackColor = false;
            btn_Crs_Seeion.Click += btn_Crs_Seeion_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1370, 608);
            Controls.Add(btn_Crs_Seeion);
            Controls.Add(btn_crs_S_Att);
            Controls.Add(btn_Crs_Std);
            Controls.Add(btn_Inst);
            Controls.Add(btn_Dept);
            Controls.Add(btn_courses);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button btn_courses;
        private Button btn_Dept;
        private Button btn_Inst;
        private Button btn_Crs_Std;
        private Button btn_crs_S_Att;
        private Button btn_Crs_Seeion;
    }
}