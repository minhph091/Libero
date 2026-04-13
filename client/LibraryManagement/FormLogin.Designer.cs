namespace LibraryManagement
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lbSignUp = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            checkBoxShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lbPassword = new Label();
            lbUser = new Label();
            lbStarter = new Label();
            btnExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.Cursor = Cursors.Hand;
            lbSignUp.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSignUp.ForeColor = Color.FromArgb(116, 86, 174);
            lbSignUp.Location = new Point(89, 488);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(116, 20);
            lbSignUp.TabIndex = 16;
            lbSignUp.Text = "Create Account";
            lbSignUp.Click += lbSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 458);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 17;
            label1.Text = "Dont have an Account";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(116, 86, 174);
            btnClear.Location = new Point(56, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(216, 35);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(116, 86, 174);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(56, 347);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 35);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(110, 300);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(151, 27);
            checkBoxShowPassword.TabIndex = 13;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(54, 257);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(54, 178);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 28);
            txtEmail.TabIndex = 12;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(54, 220);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(89, 23);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password:";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.Location = new Point(54, 141);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(94, 23);
            lbUser.TabIndex = 9;
            lbUser.Text = "Username:";
            // 
            // lbStarter
            // 
            lbStarter.AutoSize = true;
            lbStarter.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbStarter.Location = new Point(54, 87);
            lbStarter.Name = "lbStarter";
            lbStarter.Size = new Size(163, 28);
            lbStarter.TabIndex = 6;
            lbStarter.Text = "Get Started";
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(277, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 28);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 18;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(325, 562);
            Controls.Add(btnExit);
            Controls.Add(lbSignUp);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Controls.Add(lbStarter);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSignUp;
        private Label label1;
        private Button btnClear;
        private Button btnLogin;
        private CheckBox checkBoxShowPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lbPassword;
        private Label lbUser;
        private Label lbStarter;
        private PictureBox btnExit;
    }
}