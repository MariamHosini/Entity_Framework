namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label2 = new Label();
            std_Fname = new TextBox();
            label3 = new Label();
            std_Phone = new TextBox();
            label4 = new Label();
            std_Lname = new TextBox();
            btn_Add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(632, 34);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // std_Fname
            // 
            std_Fname.Location = new Point(756, 39);
            std_Fname.Name = "std_Fname";
            std_Fname.Size = new Size(123, 23);
            std_Fname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(632, 152);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 9;
            label3.Text = "Phone";
            // 
            // std_Phone
            // 
            std_Phone.Location = new Point(756, 157);
            std_Phone.Name = "std_Phone";
            std_Phone.Size = new Size(123, 23);
            std_Phone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(632, 96);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 7;
            label4.Text = "Last Name";
            // 
            // std_Lname
            // 
            std_Lname.Location = new Point(756, 96);
            std_Lname.Name = "std_Lname";
            std_Lname.Size = new Size(123, 23);
            std_Lname.TabIndex = 6;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.Font = new Font("Segoe UI", 15F);
            btn_Add.ForeColor = SystemColors.ControlLightLight;
            btn_Add.Location = new Point(632, 230);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(247, 37);
            btn_Add.TabIndex = 10;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SteelBlue;
            btn_update.Font = new Font("Segoe UI", 15F);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(632, 284);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(247, 37);
            btn_update.TabIndex = 11;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkRed;
            btn_delete.Font = new Font("Segoe UI", 15F);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(632, 345);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(247, 37);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(632, 404);
            button1.Name = "button1";
            button1.Size = new Size(247, 37);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(909, 502);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(std_Phone);
            Controls.Add(label4);
            Controls.Add(std_Lname);
            Controls.Add(label2);
            Controls.Add(std_Fname);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private TextBox std_Fname;
        private Label label3;
        private TextBox std_Phone;
        private Label label4;
        private TextBox std_Lname;
        private Button btn_Add;
        private Button btn_update;
        private Button btn_delete;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
    }
}
