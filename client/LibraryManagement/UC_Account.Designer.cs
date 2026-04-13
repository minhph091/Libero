namespace LibraryManagement
{
    partial class UC_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            dobDateTimePicker = new DateTimePicker();
            cboxGender = new ComboBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            lbPassword = new Label();
            lbUser = new Label();
            dataGridView = new DataGridView();
            label8 = new Label();
            cboxRole = new ComboBox();
            checkBoxActive = new CheckBox();
            btnUpdate = new PictureBox();
            btnAdd = new PictureBox();
            btnDelete = new PictureBox();
            label1 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            SuspendLayout();
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Location = new Point(262, 129);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(180, 27);
            dobDateTimePicker.TabIndex = 26;
            // 
            // cboxGender
            // 
            cboxGender.BackColor = Color.FromArgb(230, 231, 233);
            cboxGender.FormattingEnabled = true;
            cboxGender.Location = new Point(537, 211);
            cboxGender.Name = "cboxGender";
            cboxGender.Size = new Size(101, 28);
            cboxGender.TabIndex = 25;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(230, 231, 233);
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(533, 133);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 28);
            txtPhone.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(21, 133);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 20;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(230, 231, 233);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Cursor = Cursors.IBeam;
            txtLastName.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(207, 52);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(152, 28);
            txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(230, 231, 233);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Cursor = Cursors.IBeam;
            txtFirstName.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(21, 52);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(152, 28);
            txtFirstName.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(230, 231, 233);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(21, 212);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(490, 28);
            txtAddress.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(533, 48);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 28);
            txtEmail.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 175);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 15;
            label5.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 96);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 14;
            label3.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 96);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 13;
            label6.Text = "Date Of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 16);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 11;
            label4.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 10;
            label2.Text = "First name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 175);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 9;
            label7.Text = "Address:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(21, 96);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 16;
            lbPassword.Text = "Password:";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(533, 16);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(49, 20);
            lbUser.TabIndex = 8;
            lbUser.Text = "Email:";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(21, 290);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(1107, 334);
            dataGridView.TabIndex = 27;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(694, 175);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 15;
            label8.Text = "Role";
            // 
            // cboxRole
            // 
            cboxRole.BackColor = Color.FromArgb(230, 231, 233);
            cboxRole.FormattingEnabled = true;
            cboxRole.Location = new Point(694, 211);
            cboxRole.Name = "cboxRole";
            cboxRole.Size = new Size(101, 28);
            cboxRole.TabIndex = 25;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(747, 137);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(72, 24);
            checkBoxActive.TabIndex = 28;
            checkBoxActive.Text = "Active";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(1062, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 69);
            btnUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdate.TabIndex = 29;
            btnUpdate.TabStop = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(866, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 69);
            btnAdd.SizeMode = PictureBoxSizeMode.Zoom;
            btnAdd.TabIndex = 30;
            btnAdd.TabStop = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseDown += btnAdd_MouseDown;
            btnAdd.MouseUp += btnAdd_MouseUp;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(961, 171);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 69);
            btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btnDelete.TabIndex = 31;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 16);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 11;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(230, 231, 233);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Cursor = Cursors.IBeam;
            txtID.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(374, 52);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(68, 28);
            txtID.TabIndex = 19;
            // 
            // UC_Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(checkBoxActive);
            Controls.Add(dataGridView);
            Controls.Add(dobDateTimePicker);
            Controls.Add(cboxRole);
            Controls.Add(cboxGender);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtID);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Name = "UC_Account";
            Size = new Size(1148, 639);
            Load += UC_Account_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dobDateTimePicker;
        private ComboBox cboxGender;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label lbPassword;
        private Label lbUser;
        private DataGridView dataGridView;
        private Label label8;
        private ComboBox cboxRole;
        private CheckBox checkBoxActive;
        private PictureBox btnUpdate;
        private PictureBox btnAdd;
        private PictureBox btnDelete;
        private Label label1;
        private TextBox txtID;
    }
}
