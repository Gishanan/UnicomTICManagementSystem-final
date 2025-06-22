namespace UnicomTICManagementSystem.View
{
    partial class MarkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox55 = new System.Windows.Forms.ComboBox();
            this.Mark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Mark = new System.Windows.Forms.Button();
            this.Update_Mark = new System.Windows.Forms.Button();
            this.Delete_Mark = new System.Windows.Forms.Button();
            this.dataGridView123 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView123)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ExamID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(132, 25);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 24);
            this.comboBox11.TabIndex = 3;
            // 
            // comboBox55
            // 
            this.comboBox55.FormattingEnabled = true;
            this.comboBox55.Location = new System.Drawing.Point(132, 70);
            this.comboBox55.Name = "comboBox55";
            this.comboBox55.Size = new System.Drawing.Size(121, 24);
            this.comboBox55.TabIndex = 4;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(132, 139);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(121, 22);
            this.Mark.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "score";
            // 
            // Add_Mark
            // 
            this.Add_Mark.Location = new System.Drawing.Point(539, 204);
            this.Add_Mark.Name = "Add_Mark";
            this.Add_Mark.Size = new System.Drawing.Size(75, 23);
            this.Add_Mark.TabIndex = 7;
            this.Add_Mark.Text = "Add";
            this.Add_Mark.UseVisualStyleBackColor = true;
            this.Add_Mark.Click += new System.EventHandler(this.Add_Mark_Click);
            // 
            // Update_Mark
            // 
            this.Update_Mark.Location = new System.Drawing.Point(438, 204);
            this.Update_Mark.Name = "Update_Mark";
            this.Update_Mark.Size = new System.Drawing.Size(75, 23);
            this.Update_Mark.TabIndex = 8;
            this.Update_Mark.Text = "Update";
            this.Update_Mark.UseVisualStyleBackColor = true;
            this.Update_Mark.Click += new System.EventHandler(this.Update_Mark_Click);
            // 
            // Delete_Mark
            // 
            this.Delete_Mark.Location = new System.Drawing.Point(340, 203);
            this.Delete_Mark.Name = "Delete_Mark";
            this.Delete_Mark.Size = new System.Drawing.Size(75, 23);
            this.Delete_Mark.TabIndex = 9;
            this.Delete_Mark.Text = "Delete";
            this.Delete_Mark.UseVisualStyleBackColor = true;
            this.Delete_Mark.Click += new System.EventHandler(this.Delete_Mark_Click);
            // 
            // dataGridView123
            // 
            this.dataGridView123.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView123.Location = new System.Drawing.Point(33, 264);
            this.dataGridView123.Name = "dataGridView123";
            this.dataGridView123.RowHeadersWidth = 51;
            this.dataGridView123.RowTemplate.Height = 24;
            this.dataGridView123.Size = new System.Drawing.Size(670, 174);
            this.dataGridView123.TabIndex = 10;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView123);
            this.Controls.Add(this.Delete_Mark);
            this.Controls.Add(this.Update_Mark);
            this.Controls.Add(this.Add_Mark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.comboBox55);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView123)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox55;
        private System.Windows.Forms.TextBox Mark;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button Add_Mark;
        private System.Windows.Forms.Button Update_Mark;
        private System.Windows.Forms.Button Delete_Mark;
        private System.Windows.Forms.DataGridView dataGridView123;
    }
}