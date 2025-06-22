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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Main_Subject = new System.Windows.Forms.Button();
            this.Main_Course = new System.Windows.Forms.Button();
            this.Main_Exam = new System.Windows.Forms.Button();
            this.Main_Mark = new System.Windows.Forms.Button();
            this.Studet_Main = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Main_Subject);
            this.panel1.Controls.Add(this.Main_Course);
            this.panel1.Controls.Add(this.Main_Exam);
            this.panel1.Controls.Add(this.Main_Mark);
            this.panel1.Controls.Add(this.Studet_Main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(44, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "TimeTable";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Subject
            // 
            this.Main_Subject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Main_Subject.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Subject.Location = new System.Drawing.Point(44, 344);
            this.Main_Subject.Name = "Main_Subject";
            this.Main_Subject.Size = new System.Drawing.Size(101, 44);
            this.Main_Subject.TabIndex = 4;
            this.Main_Subject.Text = "Subject";
            this.Main_Subject.UseVisualStyleBackColor = false;
            this.Main_Subject.Click += new System.EventHandler(this.Main_Subject_Click);
            // 
            // Main_Course
            // 
            this.Main_Course.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Main_Course.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Course.Location = new System.Drawing.Point(44, 220);
            this.Main_Course.Name = "Main_Course";
            this.Main_Course.Size = new System.Drawing.Size(101, 39);
            this.Main_Course.TabIndex = 3;
            this.Main_Course.Text = "Course";
            this.Main_Course.UseVisualStyleBackColor = false;
            this.Main_Course.Click += new System.EventHandler(this.Main_Course_Click);
            // 
            // Main_Exam
            // 
            this.Main_Exam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Main_Exam.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Exam.Location = new System.Drawing.Point(44, 98);
            this.Main_Exam.Name = "Main_Exam";
            this.Main_Exam.Size = new System.Drawing.Size(101, 37);
            this.Main_Exam.TabIndex = 2;
            this.Main_Exam.Text = "Exam";
            this.Main_Exam.UseVisualStyleBackColor = false;
            this.Main_Exam.Click += new System.EventHandler(this.Main_Exam_Click);
            // 
            // Main_Mark
            // 
            this.Main_Mark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Main_Mark.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Mark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main_Mark.Location = new System.Drawing.Point(44, 162);
            this.Main_Mark.Name = "Main_Mark";
            this.Main_Mark.Size = new System.Drawing.Size(101, 38);
            this.Main_Mark.TabIndex = 1;
            this.Main_Mark.Text = "Mark";
            this.Main_Mark.UseVisualStyleBackColor = false;
            this.Main_Mark.Click += new System.EventHandler(this.Main_Mark_Click);
            // 
            // Studet_Main
            // 
            this.Studet_Main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Studet_Main.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studet_Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Studet_Main.Location = new System.Drawing.Point(44, 24);
            this.Studet_Main.Name = "Studet_Main";
            this.Studet_Main.Size = new System.Drawing.Size(101, 43);
            this.Studet_Main.TabIndex = 0;
            this.Studet_Main.Text = "Student";
            this.Studet_Main.UseVisualStyleBackColor = false;
            this.Studet_Main.Click += new System.EventHandler(this.Studet_Main_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 547);
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
            this.dataGridView1.Size = new System.Drawing.Size(855, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 547);
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
        private System.Windows.Forms.Button button2;
    }
}