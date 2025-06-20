namespace UnicomTICManagementSystem.View
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.Staffage = new System.Windows.Forms.TextBox();
            this.SfattPhonenumber = new System.Windows.Forms.TextBox();
            this.Add_Staff = new System.Windows.Forms.Button();
            this.Updata_Staff = new System.Windows.Forms.Button();
            this.Delete_Staff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Next_Staff = new System.Windows.Forms.Button();
            this.Back_Staff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PhoneNumber";
            // 
            // StaffName
            // 
            this.StaffName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StaffName.Location = new System.Drawing.Point(141, 22);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(171, 22);
            this.StaffName.TabIndex = 3;
            // 
            // Staffage
            // 
            this.Staffage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Staffage.Location = new System.Drawing.Point(141, 75);
            this.Staffage.Name = "Staffage";
            this.Staffage.Size = new System.Drawing.Size(171, 22);
            this.Staffage.TabIndex = 4;
            // 
            // SfattPhonenumber
            // 
            this.SfattPhonenumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SfattPhonenumber.Location = new System.Drawing.Point(141, 122);
            this.SfattPhonenumber.Name = "SfattPhonenumber";
            this.SfattPhonenumber.Size = new System.Drawing.Size(171, 22);
            this.SfattPhonenumber.TabIndex = 5;
            // 
            // Add_Staff
            // 
            this.Add_Staff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Staff.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Staff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Staff.Location = new System.Drawing.Point(452, 167);
            this.Add_Staff.Name = "Add_Staff";
            this.Add_Staff.Size = new System.Drawing.Size(75, 30);
            this.Add_Staff.TabIndex = 6;
            this.Add_Staff.Text = "Add";
            this.Add_Staff.UseVisualStyleBackColor = false;
            this.Add_Staff.Click += new System.EventHandler(this.Add_Staff_Click);
            // 
            // Updata_Staff
            // 
            this.Updata_Staff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Updata_Staff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updata_Staff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updata_Staff.Location = new System.Drawing.Point(345, 167);
            this.Updata_Staff.Name = "Updata_Staff";
            this.Updata_Staff.Size = new System.Drawing.Size(75, 30);
            this.Updata_Staff.TabIndex = 7;
            this.Updata_Staff.Text = "Upadate";
            this.Updata_Staff.UseVisualStyleBackColor = false;
            this.Updata_Staff.Click += new System.EventHandler(this.Updata_Staff_Click);
            // 
            // Delete_Staff
            // 
            this.Delete_Staff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete_Staff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Staff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Staff.Location = new System.Drawing.Point(237, 167);
            this.Delete_Staff.Name = "Delete_Staff";
            this.Delete_Staff.Size = new System.Drawing.Size(75, 30);
            this.Delete_Staff.TabIndex = 8;
            this.Delete_Staff.Text = "Delete";
            this.Delete_Staff.UseVisualStyleBackColor = false;
            this.Delete_Staff.Click += new System.EventHandler(this.Delete_Staff_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 212);
            this.dataGridView1.TabIndex = 9;
            // 
            // Next_Staff
            // 
            this.Next_Staff.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Staff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Staff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Staff.Location = new System.Drawing.Point(111, 193);
            this.Next_Staff.Name = "Next_Staff";
            this.Next_Staff.Size = new System.Drawing.Size(75, 33);
            this.Next_Staff.TabIndex = 10;
            this.Next_Staff.Text = "Next";
            this.Next_Staff.UseVisualStyleBackColor = false;
            this.Next_Staff.Click += new System.EventHandler(this.Next_Staff_Click);
            // 
            // Back_Staff
            // 
            this.Back_Staff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Back_Staff.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Staff.Location = new System.Drawing.Point(21, 193);
            this.Back_Staff.Name = "Back_Staff";
            this.Back_Staff.Size = new System.Drawing.Size(75, 33);
            this.Back_Staff.TabIndex = 11;
            this.Back_Staff.Text = "Back";
            this.Back_Staff.UseVisualStyleBackColor = false;
            this.Back_Staff.Click += new System.EventHandler(this.Back_Staff_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_Staff);
            this.Controls.Add(this.Next_Staff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_Staff);
            this.Controls.Add(this.Updata_Staff);
            this.Controls.Add(this.Add_Staff);
            this.Controls.Add(this.SfattPhonenumber);
            this.Controls.Add(this.Staffage);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.TextBox Staffage;
        private System.Windows.Forms.TextBox SfattPhonenumber;
        private System.Windows.Forms.Button Add_Staff;
        private System.Windows.Forms.Button Updata_Staff;
        private System.Windows.Forms.Button Delete_Staff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Next_Staff;
        private System.Windows.Forms.Button Back_Staff;
    }
}