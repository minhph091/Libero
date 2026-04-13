namespace LibraryManagement
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnDashboard = new Button();
            btnLogout = new Button();
            btnReturnBook = new Button();
            btnRecord = new Button();
            btnIssueBook = new Button();
            btnBook = new Button();
            btnAccount = new Button();
            panelMain = new Panel();
            panel2 = new Panel();
            lbAccountName = new Label();
            lbRole = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(26, 37, 40);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReturnBook);
            panel1.Controls.Add(btnRecord);
            panel1.Controls.Add(btnIssueBook);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(btnAccount);
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 643);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(26, 37, 40);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(-7, 220);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(276, 49);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseEnter += btnDashboard_MouseEnter;
            btnDashboard.MouseLeave += btnDashboard_MouseLeave;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(26, 37, 40);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(101, 568);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(158, 42);
            btnLogout.TabIndex = 0;
            btnLogout.Text = " Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.FromArgb(26, 37, 40);
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatStyle = FlatStyle.Flat;
            btnReturnBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnBook.ForeColor = Color.White;
            btnReturnBook.Image = (Image)resources.GetObject("btnReturnBook.Image");
            btnReturnBook.Location = new Point(-6, 448);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(275, 49);
            btnReturnBook.TabIndex = 0;
            btnReturnBook.Text = "  Return Book";
            btnReturnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.FromArgb(26, 37, 40);
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.ForeColor = Color.White;
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.Location = new Point(-4, 503);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(273, 49);
            btnRecord.TabIndex = 0;
            btnRecord.Text = "View Record";
            btnRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnIssueBook
            // 
            btnIssueBook.BackColor = Color.FromArgb(26, 37, 40);
            btnIssueBook.FlatAppearance.BorderSize = 0;
            btnIssueBook.FlatStyle = FlatStyle.Flat;
            btnIssueBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.ForeColor = Color.White;
            btnIssueBook.Image = (Image)resources.GetObject("btnIssueBook.Image");
            btnIssueBook.Location = new Point(-4, 391);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(273, 49);
            btnIssueBook.TabIndex = 0;
            btnIssueBook.Text = " Issue Book";
            btnIssueBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(26, 37, 40);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.ForeColor = Color.White;
            btnBook.Image = (Image)resources.GetObject("btnBook.Image");
            btnBook.Location = new Point(-23, 277);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(292, 49);
            btnBook.TabIndex = 0;
            btnBook.Text = "  Books";
            btnBook.TextAlign = ContentAlignment.MiddleLeft;
            btnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(26, 37, 40);
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.Location = new Point(-16, 334);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(289, 49);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "  Account";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(268, 93);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1148, 639);
            panelMain.TabIndex = 4;
            panelMain.Paint += panelMain_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(lbAccountName);
            panel2.Controls.Add(lbRole);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1416, 92);
            panel2.TabIndex = 5;
            // 
            // lbAccountName
            // 
            lbAccountName.AutoSize = true;
            lbAccountName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAccountName.ForeColor = Color.White;
            lbAccountName.Location = new Point(117, 33);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new Size(142, 23);
            lbAccountName.TabIndex = 2;
            lbAccountName.Text = "Name of User";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbRole.ForeColor = SystemColors.ButtonHighlight;
            lbRole.Location = new Point(117, 65);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(56, 18);
            lbRole.TabIndex = 1;
            lbRole.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1355, 28);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 28);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 19;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 734);
            Controls.Add(panel1);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnReturnBook;
        private Button btnIssueBook;
        private Button btnBook;
        private Button btnAccount;
        private Panel panelMain;
        private Panel panel2;
        private Label lbAccountName;
        private Label lbRole;
        private PictureBox pictureBox1;
        private Button btnRecord;
        private PictureBox btnExit;
    }
}