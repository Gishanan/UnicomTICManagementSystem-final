namespace UnicomTICManagementSystem.View
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.AdminAge = new System.Windows.Forms.TextBox();
            this.AdminPhone = new System.Windows.Forms.TextBox();
            this.Add_Admin = new System.Windows.Forms.Button();
            this.Update_Admin = new System.Windows.Forms.Button();
            this.Delete_Admin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Next_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PhoneNumber";
            // 
            // AdminName
            // 
            this.AdminName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminName.Location = new System.Drawing.Point(147, 28);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(160, 22);
            this.AdminName.TabIndex = 3;
            // 
            // AdminAge
            // 
            this.AdminAge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminAge.Location = new System.Drawing.Point(147, 74);
            this.AdminAge.Name = "AdminAge";
            this.AdminAge.Size = new System.Drawing.Size(160, 22);
            this.AdminAge.TabIndex = 4;
            // 
            // AdminPhone
            // 
            this.AdminPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminPhone.Location = new System.Drawing.Point(147, 115);
            this.AdminPhone.Name = "AdminPhone";
            this.AdminPhone.Size = new System.Drawing.Size(160, 22);
            this.AdminPhone.TabIndex = 5;
            // 
            // Add_Admin
            // 
            this.Add_Admin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Add_Admin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Admin.Location = new System.Drawing.Point(514, 156);
            this.Add_Admin.Name = "Add_Admin";
            this.Add_Admin.Size = new System.Drawing.Size(75, 36);
            this.Add_Admin.TabIndex = 6;
            this.Add_Admin.Text = "Add";
            this.Add_Admin.UseVisualStyleBackColor = false;
            this.Add_Admin.Click += new System.EventHandler(this.Add_Admin_Click);
            // 
            // Update_Admin
            // 
            this.Update_Admin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update_Admin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_Admin.Location = new System.Drawing.Point(403, 156);
            this.Update_Admin.Name = "Update_Admin";
            this.Update_Admin.Size = new System.Drawing.Size(75, 36);
            this.Update_Admin.TabIndex = 7;
            this.Update_Admin.Text = "Update";
            this.Update_Admin.UseVisualStyleBackColor = false;
            this.Update_Admin.Click += new System.EventHandler(this.Update_Admin_Click);
            // 
            // Delete_Admin
            // 
            this.Delete_Admin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete_Admin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Admin.Location = new System.Drawing.Point(291, 156);
            this.Delete_Admin.Name = "Delete_Admin";
            this.Delete_Admin.Size = new System.Drawing.Size(75, 36);
            this.Delete_Admin.TabIndex = 8;
            this.Delete_Admin.Text = "Delete";
            this.Delete_Admin.UseVisualStyleBackColor = false;
            this.Delete_Admin.Click += new System.EventHandler(this.Delete_Admin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 249);
            this.dataGridView1.TabIndex = 9;
            // 
            // Next_Admin
            // 
            this.Next_Admin.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_Admin.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Admin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Next_Admin.Location = new System.Drawing.Point(147, 156);
            this.Next_Admin.Name = "Next_Admin";
            this.Next_Admin.Size = new System.Drawing.Size(75, 36);
            this.Next_Admin.TabIndex = 10;
            this.Next_Admin.Text = "Next";
            this.Next_Admin.UseVisualStyleBackColor = false;
            this.Next_Admin.Click += new System.EventHandler(this.Next_Admin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next_Admin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_Admin);
            this.Controls.Add(this.Update_Admin);
            this.Controls.Add(this.Add_Admin);
            this.Controls.Add(this.AdminPhone);
            this.Controls.Add(this.AdminAge);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.TextBox AdminAge;
        private System.Windows.Forms.TextBox AdminPhone;
        private System.Windows.Forms.Button Add_Admin;
        private System.Windows.Forms.Button Update_Admin;
        private System.Windows.Forms.Button Delete_Admin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Next_Admin;
    }
}