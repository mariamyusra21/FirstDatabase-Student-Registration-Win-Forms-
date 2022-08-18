namespace FirstDatabase
{
    partial class StudentInfoForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.IsCSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.IsFlutterCheckBox = new System.Windows.Forms.CheckBox();
            this.IsJavaCheckBox = new System.Windows.Forms.CheckBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PhNumberLabel = new System.Windows.Forms.Label();
            this.PhNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhValidatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(47, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(149, 28);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(357, 31);
            this.NameTextBox.TabIndex = 0;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(47, 94);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(58, 20);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(149, 86);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(357, 31);
            this.EmailTextBox.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(374, 394);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 31);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestLabel.Location = new System.Drawing.Point(55, 268);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(104, 17);
            this.InterestLabel.TabIndex = 0;
            this.InterestLabel.Text = "Interested In:";
            // 
            // IsCSharpCheckBox
            // 
            this.IsCSharpCheckBox.AutoSize = true;
            this.IsCSharpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsCSharpCheckBox.Location = new System.Drawing.Point(180, 269);
            this.IsCSharpCheckBox.Name = "IsCSharpCheckBox";
            this.IsCSharpCheckBox.Size = new System.Drawing.Size(46, 21);
            this.IsCSharpCheckBox.TabIndex = 4;
            this.IsCSharpCheckBox.Text = "C#";
            this.IsCSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsFlutterCheckBox
            // 
            this.IsFlutterCheckBox.AutoSize = true;
            this.IsFlutterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsFlutterCheckBox.Location = new System.Drawing.Point(302, 269);
            this.IsFlutterCheckBox.Name = "IsFlutterCheckBox";
            this.IsFlutterCheckBox.Size = new System.Drawing.Size(74, 21);
            this.IsFlutterCheckBox.TabIndex = 5;
            this.IsFlutterCheckBox.Text = "Flutter";
            this.IsFlutterCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsJavaCheckBox
            // 
            this.IsJavaCheckBox.AutoSize = true;
            this.IsJavaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsJavaCheckBox.Location = new System.Drawing.Point(435, 268);
            this.IsJavaCheckBox.Name = "IsJavaCheckBox";
            this.IsJavaCheckBox.Size = new System.Drawing.Size(61, 21);
            this.IsJavaCheckBox.TabIndex = 6;
            this.IsJavaCheckBox.Text = "Java";
            this.IsJavaCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(55, 318);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(81, 17);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platforms:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // PhNumberLabel
            // 
            this.PhNumberLabel.AutoSize = true;
            this.PhNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNumberLabel.Location = new System.Drawing.Point(47, 149);
            this.PhNumberLabel.Name = "PhNumberLabel";
            this.PhNumberLabel.Size = new System.Drawing.Size(50, 20);
            this.PhNumberLabel.TabIndex = 0;
            this.PhNumberLabel.Text = "Ph #:";
            // 
            // PhNumberTextBox
            // 
            this.PhNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNumberTextBox.Location = new System.Drawing.Point(149, 138);
            this.PhNumberTextBox.MaxLength = 11;
            this.PhNumberTextBox.Multiline = true;
            this.PhNumberTextBox.Name = "PhNumberTextBox";
            this.PhNumberTextBox.Size = new System.Drawing.Size(357, 31);
            this.PhNumberTextBox.TabIndex = 1;
            this.PhNumberTextBox.TextChanged += new System.EventHandler(this.PhNumberTextBox_TextChanged);
            this.PhNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhNumberTextBox_KeyPress);
            // 
            // PhValidatorButton
            // 
            this.PhValidatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhValidatorButton.Location = new System.Drawing.Point(543, 138);
            this.PhValidatorButton.Name = "PhValidatorButton";
            this.PhValidatorButton.Size = new System.Drawing.Size(132, 31);
            this.PhValidatorButton.TabIndex = 3;
            this.PhValidatorButton.Text = "Validate Ph #";
            this.PhValidatorButton.UseVisualStyleBackColor = true;
            this.PhValidatorButton.Click += new System.EventHandler(this.PhValidatorButton_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 463);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.IsJavaCheckBox);
            this.Controls.Add(this.IsFlutterCheckBox);
            this.Controls.Add(this.IsCSharpCheckBox);
            this.Controls.Add(this.PhValidatorButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhNumberTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PlatformLabel);
            this.Controls.Add(this.InterestLabel);
            this.Controls.Add(this.PhNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Info Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.CheckBox IsCSharpCheckBox;
        private System.Windows.Forms.CheckBox IsFlutterCheckBox;
        private System.Windows.Forms.CheckBox IsJavaCheckBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PhNumberLabel;
        private System.Windows.Forms.TextBox PhNumberTextBox;
        private System.Windows.Forms.Button PhValidatorButton;
    }
}