namespace UnicomTICManagementSystem.View
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.comboBox009 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ree = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name.Location = new System.Drawing.Point(336, 24);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(261, 22);
            this.Name.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Pass.Location = new System.Drawing.Point(336, 68);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(261, 22);
            this.Pass.TabIndex = 4;
            // 
            // comboBox009
            // 
            this.comboBox009.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox009.FormattingEnabled = true;
            this.comboBox009.Location = new System.Drawing.Point(336, 154);
            this.comboBox009.Name = "comboBox009";
            this.comboBox009.Size = new System.Drawing.Size(261, 24);
            this.comboBox009.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // Cpass
            // 
            this.Cpass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cpass.Location = new System.Drawing.Point(336, 112);
            this.Cpass.Name = "Cpass";
            this.Cpass.Size = new System.Drawing.Size(261, 22);
            this.Cpass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reference Id";
            // 
            // Ree
            // 
            this.Ree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Ree.Location = new System.Drawing.Point(336, 196);
            this.Ree.Name = "Ree";
            this.Ree.Size = new System.Drawing.Size(261, 22);
            this.Ree.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox009);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ////////////////this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.ComboBox comboBox009;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ree;
        private System.Windows.Forms.Button button1;
    }
}