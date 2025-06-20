namespace UnicomTICManagementSystem.View
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.ages = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.Add_Student = new System.Windows.Forms.Button();
            this.Update_Student = new System.Windows.Forms.Button();
            this.Delete_Student = new System.Windows.Forms.Button();
            this.dataGridView177 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox_Student = new System.Windows.Forms.ComboBox();
            this.Next_Student = new System.Windows.Forms.Button();
            this.Back_Student = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.Label();
            this.comboBox277 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView177)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.name.Location = new System.Drawing.Point(146, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(208, 22);
            this.name.TabIndex = 5;
            // 
            // ages
            // 
            this.ages.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ages.Location = new System.Drawing.Point(509, 16);
            this.ages.Name = "ages";
            this.ages.Size = new System.Drawing.Size(203, 22);
            this.ages.TabIndex = 6;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.address.Location = new System.Drawing.Point(509, 55);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(203, 22);
            this.address.TabIndex = 7;
            // 
            // Add_Student
            // 
            this.Add_Student.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Student.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Student.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Student.Location = new System.Drawing.Point(611, 135);
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(75, 31);
            this.Add_Student.TabIndex = 8;
            this.Add_Student.Text = "Add";
            this.Add_Student.UseVisualStyleBackColor = false;
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // Update_Student
            // 
            this.Update_Student.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_Student.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Student.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_Student.Location = new System.Drawing.Point(513, 135);
            this.Update_Student.Name = "Update_Student";
            this.Update_Student.Size = new System.Drawing.Size(75, 31);
            this.Update_Student.TabIndex = 9;
            this.Update_Student.Text = "Update";
            this.Update_Student.UseVisualStyleBackColor = false;
            this.Update_Student.Click += new System.EventHandler(this.Update_Student_Click);
            // 
            // Delete_Student
            // 
            this.Delete_Student.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete_Student.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Student.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Student.Location = new System.Drawing.Point(411, 135);
            this.Delete_Student.Name = "Delete_Student";
            this.Delete_Student.Size = new System.Drawing.Size(75, 31);
            this.Delete_Student.TabIndex = 10;
            this.Delete_Student.Text = "Delete";
            this.Delete_Student.UseVisualStyleBackColor = false;
            this.Delete_Student.Click += new System.EventHandler(this.Delete_Student_Click);
            // 
            // dataGridView177
            // 
            this.dataGridView177.ColumnHeadersHeight = 29;
            this.dataGridView177.Location = new System.Drawing.Point(23, 172);
            this.dataGridView177.Name = "dataGridView177";
            this.dataGridView177.RowHeadersWidth = 51;
            this.dataGridView177.Size = new System.Drawing.Size(640, 266);
            this.dataGridView177.TabIndex = 18;
            this.dataGridView177.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView177_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "PhoneNumber";
            // 
            // phonenumber
            // 
            this.phonenumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.phonenumber.Location = new System.Drawing.Point(146, 52);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(208, 22);
            this.phonenumber.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "CourseName";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // ComboBox_Student
            // 
            this.ComboBox_Student.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboBox_Student.Location = new System.Drawing.Point(146, 91);
            this.ComboBox_Student.Name = "ComboBox_Student";
            this.ComboBox_Student.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Student.TabIndex = 17;
            this.ComboBox_Student.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Student_SelectedIndexChanged);
            // 
            // Next_Student
            // 
            this.Next_Student.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Student.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Student.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Student.Location = new System.Drawing.Point(200, 135);
            this.Next_Student.Name = "Next_Student";
            this.Next_Student.Size = new System.Drawing.Size(75, 31);
            this.Next_Student.TabIndex = 19;
            this.Next_Student.Text = "Next";
            this.Next_Student.UseVisualStyleBackColor = false;
            this.Next_Student.Click += new System.EventHandler(this.Next_Student_Click);
            // 
            // Back_Student
            // 
            this.Back_Student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Student.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Student.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back_Student.Location = new System.Drawing.Point(85, 135);
            this.Back_Student.Name = "Back_Student";
            this.Back_Student.Size = new System.Drawing.Size(75, 31);
            this.Back_Student.TabIndex = 20;
            this.Back_Student.Text = "Back";
            this.Back_Student.UseVisualStyleBackColor = false;
            this.Back_Student.Click += new System.EventHandler(this.Back_Student_Click);
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.Location = new System.Drawing.Point(407, 101);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(96, 19);
            this.ClassName.TabIndex = 21;
            this.ClassName.Text = "ClassName";
            // 
            // comboBox277
            // 
            this.comboBox277.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox277.FormattingEnabled = true;
            this.comboBox277.Location = new System.Drawing.Point(509, 96);
            this.comboBox277.Name = "comboBox277";
            this.comboBox277.Size = new System.Drawing.Size(121, 24);
            this.comboBox277.TabIndex = 22;
            // 
            // StudentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.comboBox277);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.Back_Student);
            this.Controls.Add(this.Next_Student);
            this.Controls.Add(this.ComboBox_Student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView177);
            this.Controls.Add(this.Delete_Student);
            this.Controls.Add(this.Update_Student);
            this.Controls.Add(this.Add_Student);
            this.Controls.Add(this.address);
            this.Controls.Add(this.ages);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView177)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ages;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button Add_Student;
        private System.Windows.Forms.Button Update_Student;
        private System.Windows.Forms.Button Delete_Student;
        private System.Windows.Forms.DataGridView dataGridView177;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ComboBox_Student;
        private System.Windows.Forms.Button Next_Student;
        private System.Windows.Forms.Button Back_Student;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.ComboBox comboBox277;
    }
}