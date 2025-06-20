namespace UnicomTICManagementSystem.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Paas = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.sign_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.Location = new System.Drawing.Point(164, 120);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(130, 24);
            this.PassWord.TabIndex = 1;
            this.PassWord.Text = "PassWord";
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name.Location = new System.Drawing.Point(328, 47);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(204, 22);
            this.Name.TabIndex = 2;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Paas
            // 
            this.Paas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Paas.Location = new System.Drawing.Point(328, 123);
            this.Paas.Name = "Paas";
            this.Paas.Size = new System.Drawing.Size(204, 22);
            this.Paas.TabIndex = 3;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Login_button.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_button.Location = new System.Drawing.Point(445, 207);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 33);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // sign_add
            // 
            this.sign_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sign_add.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sign_add.Location = new System.Drawing.Point(298, 207);
            this.sign_add.Name = "sign_add";
            this.sign_add.Size = new System.Drawing.Size(75, 33);
            this.sign_add.TabIndex = 5;
            this.sign_add.Text = "Sign";
            this.sign_add.UseVisualStyleBackColor = false;
            this.sign_add.Click += new System.EventHandler(this.sign_add_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_add);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Paas);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.label1);
            //////this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Paas;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button sign_add;
    }
}