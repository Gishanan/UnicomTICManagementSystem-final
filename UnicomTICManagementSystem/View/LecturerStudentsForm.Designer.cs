namespace UnicomTICManagementSystem.View
{
    partial class LecturerStudentControllersForm
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
            this.dataGridView100 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView100)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView100
            // 
            this.dataGridView100.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView100.Location = new System.Drawing.Point(56, 96);
            this.dataGridView100.Name = "dataGridView100";
            this.dataGridView100.RowHeadersWidth = 51;
            this.dataGridView100.RowTemplate.Height = 24;
            this.dataGridView100.Size = new System.Drawing.Size(470, 277);
            this.dataGridView100.TabIndex = 0;
            this.dataGridView100.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView100_CellContentClick);
            // 
            // LecturerStudentControllersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView100);
            this.Name = "LecturerStudentControllersForm";
            this.Text = "LecturerStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView100)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView100;
    }
}