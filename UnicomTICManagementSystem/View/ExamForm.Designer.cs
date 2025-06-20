namespace UnicomTICManagementSystem.View
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.TextBox();
            this.comboBox88 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker88 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker22 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker33 = new System.Windows.Forms.DateTimePicker();
            this.Add_Exam = new System.Windows.Forms.Button();
            this.Update_Exam = new System.Windows.Forms.Button();
            this.Delete_Exam = new System.Windows.Forms.Button();
            this.dataGridView109 = new System.Windows.Forms.DataGridView();
            this.Back_Exam = new System.Windows.Forms.Button();
            this.Next_Exam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView109)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ExamName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubjectName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "StartTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "CloseTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // Names
            // 
            this.Names.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Names.Location = new System.Drawing.Point(137, 30);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(100, 22);
            this.Names.TabIndex = 5;
            // 
            // comboBox88
            // 
            this.comboBox88.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox88.FormattingEnabled = true;
            this.comboBox88.Location = new System.Drawing.Point(137, 77);
            this.comboBox88.Name = "comboBox88";
            this.comboBox88.Size = new System.Drawing.Size(121, 24);
            this.comboBox88.TabIndex = 6;
            // 
            // dateTimePicker88
            // 
            this.dateTimePicker88.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker88.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker88.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker88.Location = new System.Drawing.Point(534, 40);
            this.dateTimePicker88.Name = "dateTimePicker88";
            this.dateTimePicker88.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker88.TabIndex = 7;
            // 
            // dateTimePicker22
            // 
            this.dateTimePicker22.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker22.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker22.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker22.Location = new System.Drawing.Point(534, 92);
            this.dateTimePicker22.Name = "dateTimePicker22";
            this.dateTimePicker22.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker22.TabIndex = 8;
            // 
            // dateTimePicker33
            // 
            this.dateTimePicker33.Location = new System.Drawing.Point(534, 138);
            this.dateTimePicker33.Name = "dateTimePicker33";
            this.dateTimePicker33.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker33.TabIndex = 9;
            // 
            // Add_Exam
            // 
            this.Add_Exam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Exam.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Exam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Exam.Location = new System.Drawing.Point(701, 184);
            this.Add_Exam.Name = "Add_Exam";
            this.Add_Exam.Size = new System.Drawing.Size(75, 33);
            this.Add_Exam.TabIndex = 10;
            this.Add_Exam.Text = "Add";
            this.Add_Exam.UseVisualStyleBackColor = false;
            this.Add_Exam.Click += new System.EventHandler(this.Add_Exam_Click);
            // 
            // Update_Exam
            // 
            this.Update_Exam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_Exam.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Exam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_Exam.Location = new System.Drawing.Point(606, 184);
            this.Update_Exam.Name = "Update_Exam";
            this.Update_Exam.Size = new System.Drawing.Size(75, 33);
            this.Update_Exam.TabIndex = 11;
            this.Update_Exam.Text = "Update";
            this.Update_Exam.UseVisualStyleBackColor = false;
            this.Update_Exam.Click += new System.EventHandler(this.Update_Exam_Click);
            // 
            // Delete_Exam
            // 
            this.Delete_Exam.BackColor = System.Drawing.SystemColors.GrayText;
            this.Delete_Exam.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Exam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Exam.Location = new System.Drawing.Point(512, 184);
            this.Delete_Exam.Name = "Delete_Exam";
            this.Delete_Exam.Size = new System.Drawing.Size(75, 33);
            this.Delete_Exam.TabIndex = 12;
            this.Delete_Exam.Text = "Delete";
            this.Delete_Exam.UseVisualStyleBackColor = false;
            this.Delete_Exam.Click += new System.EventHandler(this.Delete_Exam_Click);
            // 
            // dataGridView109
            // 
            this.dataGridView109.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView109.Location = new System.Drawing.Point(44, 234);
            this.dataGridView109.Name = "dataGridView109";
            this.dataGridView109.RowHeadersWidth = 51;
            this.dataGridView109.RowTemplate.Height = 24;
            this.dataGridView109.Size = new System.Drawing.Size(732, 204);
            this.dataGridView109.TabIndex = 13;
            // 
            // Back_Exam
            // 
            this.Back_Exam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Exam.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Exam.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back_Exam.Location = new System.Drawing.Point(75, 184);
            this.Back_Exam.Name = "Back_Exam";
            this.Back_Exam.Size = new System.Drawing.Size(75, 33);
            this.Back_Exam.TabIndex = 14;
            this.Back_Exam.Text = "Back";
            this.Back_Exam.UseVisualStyleBackColor = false;
            this.Back_Exam.Click += new System.EventHandler(this.Back_Exam_Click);
            // 
            // Next_Exam
            // 
            this.Next_Exam.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Exam.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Exam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Exam.Location = new System.Drawing.Point(173, 184);
            this.Next_Exam.Name = "Next_Exam";
            this.Next_Exam.Size = new System.Drawing.Size(75, 33);
            this.Next_Exam.TabIndex = 15;
            this.Next_Exam.Text = "Next";
            this.Next_Exam.UseVisualStyleBackColor = false;
            this.Next_Exam.Click += new System.EventHandler(this.Next_Exam_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next_Exam);
            this.Controls.Add(this.Back_Exam);
            this.Controls.Add(this.dataGridView109);
            this.Controls.Add(this.Delete_Exam);
            this.Controls.Add(this.Update_Exam);
            this.Controls.Add(this.Add_Exam);
            this.Controls.Add(this.dateTimePicker33);
            this.Controls.Add(this.dateTimePicker22);
            this.Controls.Add(this.dateTimePicker88);
            this.Controls.Add(this.comboBox88);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView109)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.ComboBox comboBox88;
        private System.Windows.Forms.DateTimePicker dateTimePicker88;
        private System.Windows.Forms.DateTimePicker dateTimePicker22;
        private System.Windows.Forms.DateTimePicker dateTimePicker33;
        private System.Windows.Forms.Button Add_Exam;
        private System.Windows.Forms.Button Update_Exam;
        private System.Windows.Forms.Button Delete_Exam;
        private System.Windows.Forms.DataGridView dataGridView109;
        private System.Windows.Forms.Button Back_Exam;
        private System.Windows.Forms.Button Next_Exam;
    }
}