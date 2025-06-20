namespace UnicomTICManagementSystem.View
{
    partial class StudentMainForm
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
            this.Main_Subject = new System.Windows.Forms.Button();
            this.Main_Course = new System.Windows.Forms.Button();
            this.Main_Exam = new System.Windows.Forms.Button();
            this.Main_Mark = new System.Windows.Forms.Button();
            this.Studet_Main = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Main_Subject);
            this.panel1.Controls.Add(this.Main_Course);
            this.panel1.Controls.Add(this.Main_Exam);
            this.panel1.Controls.Add(this.Main_Mark);
            this.panel1.Controls.Add(this.Studet_Main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main_Subject
            // 
            this.Main_Subject.Location = new System.Drawing.Point(44, 244);
            this.Main_Subject.Name = "Main_Subject";
            this.Main_Subject.Size = new System.Drawing.Size(75, 23);
            this.Main_Subject.TabIndex = 4;
            this.Main_Subject.Text = "Subject";
            this.Main_Subject.UseVisualStyleBackColor = true;
            this.Main_Subject.Click += new System.EventHandler(this.Main_Subject_Click);
            // 
            // Main_Course
            // 
            this.Main_Course.Location = new System.Drawing.Point(44, 178);
            this.Main_Course.Name = "Main_Course";
            this.Main_Course.Size = new System.Drawing.Size(75, 23);
            this.Main_Course.TabIndex = 3;
            this.Main_Course.Text = "Course";
            this.Main_Course.UseVisualStyleBackColor = true;
            this.Main_Course.Click += new System.EventHandler(this.Main_Course_Click);
            // 
            // Main_Exam
            // 
            this.Main_Exam.Location = new System.Drawing.Point(44, 71);
            this.Main_Exam.Name = "Main_Exam";
            this.Main_Exam.Size = new System.Drawing.Size(75, 23);
            this.Main_Exam.TabIndex = 2;
            this.Main_Exam.Text = "Exam";
            this.Main_Exam.UseVisualStyleBackColor = true;
            this.Main_Exam.Click += new System.EventHandler(this.Main_Exam_Click);
            // 
            // Main_Mark
            // 
            this.Main_Mark.Location = new System.Drawing.Point(44, 124);
            this.Main_Mark.Name = "Main_Mark";
            this.Main_Mark.Size = new System.Drawing.Size(75, 23);
            this.Main_Mark.TabIndex = 1;
            this.Main_Mark.Text = "Mark";
            this.Main_Mark.UseVisualStyleBackColor = true;
            this.Main_Mark.Click += new System.EventHandler(this.Main_Mark_Click);
            // 
            // Studet_Main
            // 
            this.Studet_Main.Location = new System.Drawing.Point(44, 24);
            this.Studet_Main.Name = "Studet_Main";
            this.Studet_Main.Size = new System.Drawing.Size(75, 23);
            this.Studet_Main.TabIndex = 0;
            this.Studet_Main.Text = "Student";
            this.Studet_Main.UseVisualStyleBackColor = true;
            this.Studet_Main.Click += new System.EventHandler(this.Studet_Main_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Studet_Main;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Main_Exam;
        private System.Windows.Forms.Button Main_Mark;
        private System.Windows.Forms.Button Main_Subject;
        private System.Windows.Forms.Button Main_Course;
        private System.Windows.Forms.Button button1;
    }
}