namespace UnicomTICManagementSystem.View
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.Add_Course = new System.Windows.Forms.Button();
            this.Update_Course = new System.Windows.Forms.Button();
            this.Delete_Course = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Next_Course = new System.Windows.Forms.Button();
            this.Back_Course = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CourseName";
            // 
            // CourseName
            // 
            this.CourseName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CourseName.Location = new System.Drawing.Point(254, 28);
            this.CourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(277, 22);
            this.CourseName.TabIndex = 1;
            this.CourseName.TextChanged += new System.EventHandler(this.CourseName_TextChanged);
            // 
            // Add_Course
            // 
            this.Add_Course.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Course.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Course.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Course.Location = new System.Drawing.Point(456, 68);
            this.Add_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Course.Name = "Add_Course";
            this.Add_Course.Size = new System.Drawing.Size(75, 32);
            this.Add_Course.TabIndex = 2;
            this.Add_Course.Text = "Add";
            this.Add_Course.UseVisualStyleBackColor = false;
            this.Add_Course.Click += new System.EventHandler(this.Add_Course_Click);
            // 
            // Update_Course
            // 
            this.Update_Course.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_Course.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Course.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_Course.Location = new System.Drawing.Point(360, 68);
            this.Update_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Course.Name = "Update_Course";
            this.Update_Course.Size = new System.Drawing.Size(75, 32);
            this.Update_Course.TabIndex = 3;
            this.Update_Course.Text = "Update";
            this.Update_Course.UseVisualStyleBackColor = false;
            this.Update_Course.Click += new System.EventHandler(this.Update_Course_Click);
            // 
            // Delete_Course
            // 
            this.Delete_Course.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete_Course.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Course.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Course.Location = new System.Drawing.Point(254, 68);
            this.Delete_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Course.Name = "Delete_Course";
            this.Delete_Course.Size = new System.Drawing.Size(75, 32);
            this.Delete_Course.TabIndex = 4;
            this.Delete_Course.Text = "Delete";
            this.Delete_Course.UseVisualStyleBackColor = false;
            this.Delete_Course.Click += new System.EventHandler(this.Delete_Course_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(358, 245);
            this.dataGridView1.TabIndex = 5;
            // 
            // Next_Course
            // 
            this.Next_Course.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Course.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Course.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Course.Location = new System.Drawing.Point(226, 126);
            this.Next_Course.Name = "Next_Course";
            this.Next_Course.Size = new System.Drawing.Size(75, 35);
            this.Next_Course.TabIndex = 6;
            this.Next_Course.Text = "Next";
            this.Next_Course.UseVisualStyleBackColor = false;
            this.Next_Course.Click += new System.EventHandler(this.Next_Course_Click);
            // 
            // Back_Course
            // 
            this.Back_Course.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Course.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Course.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back_Course.Location = new System.Drawing.Point(110, 126);
            this.Back_Course.Name = "Back_Course";
            this.Back_Course.Size = new System.Drawing.Size(75, 35);
            this.Back_Course.TabIndex = 7;
            this.Back_Course.Text = "Back";
            this.Back_Course.UseVisualStyleBackColor = false;
            this.Back_Course.Click += new System.EventHandler(this.Back_Course_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 480);
            this.Controls.Add(this.Back_Course);
            this.Controls.Add(this.Next_Course);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_Course);
            this.Controls.Add(this.Update_Course);
            this.Controls.Add(this.Add_Course);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.Button Add_Course;
        private System.Windows.Forms.Button Update_Course;
        private System.Windows.Forms.Button Delete_Course;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Next_Course;
        private System.Windows.Forms.Button Back_Course;
    }
}