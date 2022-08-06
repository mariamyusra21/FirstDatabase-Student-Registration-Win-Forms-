namespace FirstDatabase
{
    partial class ManageStudentsForm
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
            this.AddNewStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewStudentButton
            // 
            this.AddNewStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewStudentButton.Location = new System.Drawing.Point(29, 38);
            this.AddNewStudentButton.Name = "AddNewStudentButton";
            this.AddNewStudentButton.Size = new System.Drawing.Size(184, 49);
            this.AddNewStudentButton.TabIndex = 0;
            this.AddNewStudentButton.Text = "Add New Student";
            this.AddNewStudentButton.UseVisualStyleBackColor = true;
            this.AddNewStudentButton.Click += new System.EventHandler(this.AddNewStudentButton_Click);
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 382);
            this.Controls.Add(this.AddNewStudentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Students Info Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewStudentButton;
    }
}

