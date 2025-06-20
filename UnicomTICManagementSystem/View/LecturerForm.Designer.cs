namespace UnicomTICManagementSystem.View
{
    partial class LecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.comboBox44 = new System.Windows.Forms.ComboBox();
            this.Add_Lecturer = new System.Windows.Forms.Button();
            this.Update_Lectuers = new System.Windows.Forms.Button();
            this.Delete_Lacturer = new System.Windows.Forms.Button();
            this.dataGridView777 = new System.Windows.Forms.DataGridView();
            this.Back_Lecturer = new System.Windows.Forms.Button();
            this.Next_Lecturer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView777)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "SubjectId";
            // 
            // L_Name
            // 
            this.L_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L_Name.Location = new System.Drawing.Point(133, 12);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(186, 22);
            this.L_Name.TabIndex = 3;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.User.Location = new System.Drawing.Point(133, 136);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(186, 22);
            this.User.TabIndex = 4;
            // 
            // comboBox44
            // 
            this.comboBox44.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox44.FormattingEnabled = true;
            this.comboBox44.Location = new System.Drawing.Point(133, 76);
            this.comboBox44.Name = "comboBox44";
            this.comboBox44.Size = new System.Drawing.Size(121, 24);
            this.comboBox44.TabIndex = 5;
            // 
            // Add_Lecturer
            // 
            this.Add_Lecturer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Lecturer.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Lecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Lecturer.Location = new System.Drawing.Point(494, 178);
            this.Add_Lecturer.Name = "Add_Lecturer";
            this.Add_Lecturer.Size = new System.Drawing.Size(75, 28);
            this.Add_Lecturer.TabIndex = 6;
            this.Add_Lecturer.Text = "Add";
            this.Add_Lecturer.UseVisualStyleBackColor = false;
            this.Add_Lecturer.Click += new System.EventHandler(this.Add_Lecturer_Click);
            // 
            // Update_Lectuers
            // 
            this.Update_Lectuers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_Lectuers.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Lectuers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_Lectuers.Location = new System.Drawing.Point(267, 178);
            this.Update_Lectuers.Name = "Update_Lectuers";
            this.Update_Lectuers.Size = new System.Drawing.Size(75, 28);
            this.Update_Lectuers.TabIndex = 11;
            this.Update_Lectuers.Text = "Update";
            this.Update_Lectuers.UseVisualStyleBackColor = false;
            this.Update_Lectuers.Click += new System.EventHandler(this.Update_Lecturer_Click);
            // 
            // Delete_Lacturer
            // 
            this.Delete_Lacturer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete_Lacturer.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Lacturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Lacturer.Location = new System.Drawing.Point(384, 178);
            this.Delete_Lacturer.Name = "Delete_Lacturer";
            this.Delete_Lacturer.Size = new System.Drawing.Size(75, 28);
            this.Delete_Lacturer.TabIndex = 10;
            this.Delete_Lacturer.Text = "Delete";
            this.Delete_Lacturer.UseVisualStyleBackColor = false;
            this.Delete_Lacturer.Click += new System.EventHandler(this.Delete_Lecturer_Click);
            // 
            // dataGridView777
            // 
            this.dataGridView777.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView777.Location = new System.Drawing.Point(62, 259);
            this.dataGridView777.Name = "dataGridView777";
            this.dataGridView777.RowHeadersWidth = 51;
            this.dataGridView777.RowTemplate.Height = 24;
            this.dataGridView777.Size = new System.Drawing.Size(579, 188);
            this.dataGridView777.TabIndex = 9;
            // 
            // Back_Lecturer
            // 
            this.Back_Lecturer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Lecturer.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Lecturer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back_Lecturer.Location = new System.Drawing.Point(62, 206);
            this.Back_Lecturer.Name = "Back_Lecturer";
            this.Back_Lecturer.Size = new System.Drawing.Size(75, 32);
            this.Back_Lecturer.TabIndex = 12;
            this.Back_Lecturer.Text = "Back";
            this.Back_Lecturer.UseVisualStyleBackColor = false;
            this.Back_Lecturer.Click += new System.EventHandler(this.Back_Lecturer_Click);
            // 
            // Next_Lecturer
            // 
            this.Next_Lecturer.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Lecturer.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Lecturer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Lecturer.Location = new System.Drawing.Point(179, 206);
            this.Next_Lecturer.Name = "Next_Lecturer";
            this.Next_Lecturer.Size = new System.Drawing.Size(75, 32);
            this.Next_Lecturer.TabIndex = 13;
            this.Next_Lecturer.Text = "Next";
            this.Next_Lecturer.UseVisualStyleBackColor = false;
            this.Next_Lecturer.Click += new System.EventHandler(this.Next_Lecturer_Click);
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next_Lecturer);
            this.Controls.Add(this.Back_Lecturer);
            this.Controls.Add(this.dataGridView777);
            this.Controls.Add(this.Delete_Lacturer);
            this.Controls.Add(this.Update_Lectuers);
            this.Controls.Add(this.Add_Lecturer);
            this.Controls.Add(this.comboBox44);
            this.Controls.Add(this.User);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView777)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L_Name;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.ComboBox comboBox44;
        private System.Windows.Forms.Button Add_Lecturer;
        private System.Windows.Forms.Button Update_Lectuers;
        private System.Windows.Forms.Button Delete_Lacturer;
        private System.Windows.Forms.DataGridView dataGridView777;
        private System.Windows.Forms.Button Back_Lecturer;
        private System.Windows.Forms.Button Next_Lecturer;
    }
}