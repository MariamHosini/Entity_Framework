namespace WindowsForm
{
    partial class Departments
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
            managers = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label4 = new Label();
            dept_location = new TextBox();
            label2 = new Label();
            dept_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // managers
            // 
            managers.FormattingEnabled = true;
            managers.Location = new Point(742, 175);
            managers.Name = "managers";
            managers.Size = new Size(121, 23);
            managers.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 25);
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
            button1.Location = new Point(616, 416);
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
            btn_delete.Location = new Point(616, 358);
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
            btn_update.Location = new Point(616, 297);
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
            btn_Add.Location = new Point(616, 243);
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
            label3.Location = new Point(601, 170);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 33;
            label3.Text = "Manager";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(599, 116);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 32;
            label4.Text = "Location";
            // 
            // dept_location
            // 
            dept_location.Location = new Point(740, 121);
            dept_location.Name = "dept_location";
            dept_location.Size = new Size(123, 23);
            dept_location.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(597, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 30;
            label2.Text = "Name";
            // 
            // dept_name
            // 
            dept_name.Location = new Point(738, 74);
            dept_name.Name = "dept_name";
            dept_name.Size = new Size(123, 23);
            dept_name.TabIndex = 29;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(934, 486);
            Controls.Add(managers);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dept_location);
            Controls.Add(label2);
            Controls.Add(dept_name);
            Name = "Departments";
            Text = "Departments";
            Load += Departments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox managers;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_Add;
        private Label label3;
        private Label label4;
        private TextBox dept_location;
        private Label label2;
        private TextBox dept_name;
    }
}