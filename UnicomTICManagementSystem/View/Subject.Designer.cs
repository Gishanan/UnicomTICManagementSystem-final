namespace UnicomTICManagementSystem.View
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.Add_Subject = new System.Windows.Forms.Button();
            this.Update_subject = new System.Windows.Forms.Button();
            this.Delete_Subject = new System.Windows.Forms.Button();
            this.dataGridView24 = new System.Windows.Forms.DataGridView();
            this.Next_Subject = new System.Windows.Forms.Button();
            this.Back_Subject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView24)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SujbectName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "CourseName";
            // 
            // SubjectName
            // 
            this.SubjectName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SubjectName.Location = new System.Drawing.Point(178, 26);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(240, 22);
            this.SubjectName.TabIndex = 3;
            // 
            // comboBox11
            // 
            this.comboBox11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(178, 66);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 24);
            this.comboBox11.TabIndex = 5;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // Add_Subject
            // 
            this.Add_Subject.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Subject.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Subject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Subject.Location = new System.Drawing.Point(446, 127);
            this.Add_Subject.Name = "Add_Subject";
            this.Add_Subject.Size = new System.Drawing.Size(75, 30);
            this.Add_Subject.TabIndex = 6;
            this.Add_Subject.Text = "Add";
            this.Add_Subject.UseVisualStyleBackColor = false;
            this.Add_Subject.Click += new System.EventHandler(this.Add_Subject_Click);
            // 
            // Update_subject
            // 
            this.Update_subject.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_subject.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_subject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_subject.Location = new System.Drawing.Point(334, 127);
            this.Update_subject.Name = "Update_subject";
            this.Update_subject.Size = new System.Drawing.Size(75, 30);
            this.Update_subject.TabIndex = 7;
            this.Update_subject.Text = "Update";
            this.Update_subject.UseVisualStyleBackColor = false;
            this.Update_subject.Click += new System.EventHandler(this.Update_subject_Click);
            // 
            // Delete_Subject
            // 
            this.Delete_Subject.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete_Subject.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Subject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Subject.Location = new System.Drawing.Point(224, 127);
            this.Delete_Subject.Name = "Delete_Subject";
            this.Delete_Subject.Size = new System.Drawing.Size(75, 30);
            this.Delete_Subject.TabIndex = 8;
            this.Delete_Subject.Text = "Delete";
            this.Delete_Subject.UseVisualStyleBackColor = false;
            this.Delete_Subject.Click += new System.EventHandler(this.Delete_Subject_Click);
            // 
            // dataGridView24
            // 
            this.dataGridView24.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView24.Location = new System.Drawing.Point(31, 213);
            this.dataGridView24.Name = "dataGridView24";
            this.dataGridView24.RowHeadersWidth = 51;
            this.dataGridView24.RowTemplate.Height = 24;
            this.dataGridView24.Size = new System.Drawing.Size(490, 225);
            this.dataGridView24.TabIndex = 9;
            // 
            // Next_Subject
            // 
            this.Next_Subject.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Subject.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Subject.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Subject.Location = new System.Drawing.Point(147, 166);
            this.Next_Subject.Name = "Next_Subject";
            this.Next_Subject.Size = new System.Drawing.Size(75, 31);
            this.Next_Subject.TabIndex = 10;
            this.Next_Subject.Text = "Next";
            this.Next_Subject.UseVisualStyleBackColor = false;
            this.Next_Subject.Click += new System.EventHandler(this.Next_Subject_Click);
            // 
            // Back_Subject
            // 
            this.Back_Subject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Subject.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Subject.Location = new System.Drawing.Point(31, 166);
            this.Back_Subject.Name = "Back_Subject";
            this.Back_Subject.Size = new System.Drawing.Size(75, 31);
            this.Back_Subject.TabIndex = 11;
            this.Back_Subject.Text = "Back";
            this.Back_Subject.UseVisualStyleBackColor = false;
            this.Back_Subject.Click += new System.EventHandler(this.Back_Subject_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.Back_Subject);
            this.Controls.Add(this.Next_Subject);
            this.Controls.Add(this.dataGridView24);
            this.Controls.Add(this.Delete_Subject);
            this.Controls.Add(this.Update_subject);
            this.Controls.Add(this.Add_Subject);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SubjectForm";
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Button Add_Subject;
        private System.Windows.Forms.Button Update_subject;
        private System.Windows.Forms.Button Delete_Subject;
        private System.Windows.Forms.DataGridView dataGridView24;
        private System.Windows.Forms.Button Next_Subject;
        private System.Windows.Forms.Button Back_Subject;
    }
}