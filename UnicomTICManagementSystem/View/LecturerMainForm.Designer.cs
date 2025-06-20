namespace UnicomTICManagementSystem.View
{
    partial class LecturerMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_Course = new System.Windows.Forms.Button();
            this.Main_TimeTable = new System.Windows.Forms.Button();
            this.Main_Exam = new System.Windows.Forms.Button();
            this.Main_Mark = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1660 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1660)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Main_Course);
            this.panel1.Controls.Add(this.Main_TimeTable);
            this.panel1.Controls.Add(this.Main_Exam);
            this.panel1.Controls.Add(this.Main_Mark);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // Main_Course
            // 
            this.Main_Course.Location = new System.Drawing.Point(61, 208);
            this.Main_Course.Name = "Main_Course";
            this.Main_Course.Size = new System.Drawing.Size(75, 23);
            this.Main_Course.TabIndex = 3;
            this.Main_Course.Text = "Course";
            this.Main_Course.UseVisualStyleBackColor = true;
            this.Main_Course.Click += new System.EventHandler(this.Main_Course_Click);
            // 
            // Main_TimeTable
            // 
            this.Main_TimeTable.Location = new System.Drawing.Point(61, 147);
            this.Main_TimeTable.Name = "Main_TimeTable";
            this.Main_TimeTable.Size = new System.Drawing.Size(75, 23);
            this.Main_TimeTable.TabIndex = 2;
            this.Main_TimeTable.Text = "TimeTable";
            this.Main_TimeTable.UseVisualStyleBackColor = true;
            this.Main_TimeTable.Click += new System.EventHandler(this.Main_TimeTable_Click);
            // 
            // Main_Exam
            // 
            this.Main_Exam.Location = new System.Drawing.Point(61, 88);
            this.Main_Exam.Name = "Main_Exam";
            this.Main_Exam.Size = new System.Drawing.Size(75, 23);
            this.Main_Exam.TabIndex = 1;
            this.Main_Exam.Text = "Exam";
            this.Main_Exam.UseVisualStyleBackColor = true;
            this.Main_Exam.Click += new System.EventHandler(this.Main_Exam_Click);
            // 
            // Main_Mark
            // 
            this.Main_Mark.Location = new System.Drawing.Point(61, 259);
            this.Main_Mark.Name = "Main_Mark";
            this.Main_Mark.Size = new System.Drawing.Size(75, 23);
            this.Main_Mark.TabIndex = 0;
            this.Main_Mark.Text = "Mark";
            this.Main_Mark.UseVisualStyleBackColor = true;
            this.Main_Mark.Click += new System.EventHandler(this.Main_Mark_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1660);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1660
            // 
            this.dataGridView1660.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1660.Location = new System.Drawing.Point(67, 35);
            this.dataGridView1660.Name = "dataGridView1660";
            this.dataGridView1660.RowHeadersWidth = 51;
            this.dataGridView1660.RowTemplate.Height = 24;
            this.dataGridView1660.Size = new System.Drawing.Size(490, 372);
            this.dataGridView1660.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LecturerMainForm";
            this.Text = "LecturerMainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1660)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Main_Course;
        private System.Windows.Forms.Button Main_TimeTable;
        private System.Windows.Forms.Button Main_Exam;
        private System.Windows.Forms.Button Main_Mark;
        private System.Windows.Forms.DataGridView dataGridView1660;
        private System.Windows.Forms.Button button1;
    }
}