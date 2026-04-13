namespace LibraryManagement
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAddress = new TextBox();
            lbStarter = new Label();
            lbUser = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbConfirmPassoword = new Label();
            txtConfirmPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            btnSignUp = new Button();
            btnClear = new Button();
            label1 = new Label();
            lbLogin = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            cboxGender = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dobDateTimePicker = new DateTimePicker();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(230, 231, 233);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(277, 279);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(490, 28);
            txtAddress.TabIndex = 2;
            // 
            // lbStarter
            // 
            lbStarter.AutoSize = true;
            lbStarter.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbStarter.Location = new Point(30, 35);
            lbStarter.Name = "lbStarter";
            lbStarter.Size = new Size(163, 28);
            lbStarter.TabIndex = 0;
            lbStarter.Text = "Get Started";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(277, 163);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(59, 23);
            lbUser.TabIndex = 1;
            lbUser.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(277, 200);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 28);
            txtEmail.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(30, 163);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(89, 23);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(30, 200);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 2;
            // 
            // lbConfirmPassoword
            // 
            lbConfirmPassoword.AutoSize = true;
            lbConfirmPassoword.Location = new Point(30, 242);
            lbConfirmPassoword.Name = "lbConfirmPassoword";
            lbConfirmPassoword.Size = new Size(160, 23);
            lbConfirmPassoword.TabIndex = 1;
            lbConfirmPassoword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(30, 279);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(216, 28);
            txtConfirmPassword.TabIndex = 2;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(84, 313);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(151, 27);
            checkBoxShowPassword.TabIndex = 3;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(116, 86, 174);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(30, 360);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(216, 35);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(116, 86, 174);
            btnClear.Location = new Point(30, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(216, 35);
            btnClear.TabIndex = 4;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 464);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 5;
            label1.Text = "Already have an account ";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Cursor = Cursors.Hand;
            lbLogin.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.ForeColor = Color.FromArgb(116, 86, 174);
            lbLogin.Location = new Point(44, 496);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(111, 20);
            lbLogin.TabIndex = 5;
            lbLogin.Text = "Back to LOGIN";
            lbLogin.Click += lbLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 83);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(595, 163);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 1;
            label3.Text = "Phone:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(230, 231, 233);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Cursor = Cursors.IBeam;
            txtFirstName.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(30, 119);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(152, 28);
            txtFirstName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(230, 231, 233);
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(595, 200);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 28);
            txtPhone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 83);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 1;
            label4.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(230, 231, 233);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Cursor = Cursors.IBeam;
            txtLastName.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(216, 119);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(152, 28);
            txtLastName.TabIndex = 2;
            // 
            // cboxGender
            // 
            cboxGender.BackColor = Color.FromArgb(230, 231, 233);
            cboxGender.FormattingEnabled = true;
            cboxGender.Location = new Point(595, 117);
            cboxGender.Name = "cboxGender";
            cboxGender.Size = new Size(101, 31);
            cboxGender.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 83);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 1;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 83);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 1;
            label6.Text = "Date Of Birth:";
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Location = new Point(403, 116);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(180, 30);
            dobDateTimePicker.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 242);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 1;
            label7.Text = "Address:";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 544);
            Controls.Add(dobDateTimePicker);
            Controls.Add(cboxGender);
            Controls.Add(lbLogin);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnSignUp);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(lbConfirmPassoword);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Controls.Add(lbStarter);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStarter;
        private Label lbUser;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbConfirmPassoword;
        private TextBox txtConfirmPassword;
        private CheckBox checkBoxShowPassword;
        private Button btnSignUp;
        private Button btnClear;
        private Label label1;
        private Label lbLogin;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtLastName;
        private ComboBox cboxGender;
        private Label label5;
        private Label label6;
        private DateTimePicker dobDateTimePicker;
        private Label label7;
        private TextBox txtAddress;
    }
}