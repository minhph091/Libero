namespace LibraryManagement
{
    partial class UC_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Book));
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            cboxGenre = new ComboBox();
            label3 = new Label();
            txtTitle = new TextBox();
            dataGridView = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            txtYear = new TextBox();
            label6 = new Label();
            txtPages = new TextBox();
            label7 = new Label();
            txtQuantity = new TextBox();
            label8 = new Label();
            cboxAuthor = new ComboBox();
            label9 = new Label();
            cboxStatus = new ComboBox();
            label10 = new Label();
            txtPublisher = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelControl = new Panel();
            pBoxSearch = new PictureBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Book ID:";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(13, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 32);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 199);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 0;
            label2.Text = "Genre:";
            // 
            // cboxGenre
            // 
            cboxGenre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxGenre.FormattingEnabled = true;
            cboxGenre.Location = new Point(15, 233);
            cboxGenre.Name = "cboxGenre";
            cboxGenre.Size = new Size(150, 31);
            cboxGenre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 119);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 0;
            label3.Text = "Book Title:";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(13, 156);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(310, 32);
            txtTitle.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ActiveCaption;
            dataGridView.Location = new Point(374, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(757, 520);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(582, 15);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 0;
            label4.Text = "Manage Books";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 284);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 0;
            label5.Text = "Year:";
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(15, 321);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 32);
            txtYear.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(196, 199);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 0;
            label6.Text = "Pages:";
            // 
            // txtPages
            // 
            txtPages.BorderStyle = BorderStyle.FixedSingle;
            txtPages.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPages.Location = new Point(196, 236);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(119, 32);
            txtPages.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 444);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 0;
            label7.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(13, 481);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 32);
            txtQuantity.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(140, 33);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 0;
            label8.Text = "Author:";
            // 
            // cboxAuthor
            // 
            cboxAuthor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxAuthor.FormattingEnabled = true;
            cboxAuthor.Location = new Point(140, 69);
            cboxAuthor.Name = "cboxAuthor";
            cboxAuthor.Size = new Size(183, 31);
            cboxAuthor.TabIndex = 2;
            cboxAuthor.SelectedIndexChanged += cboxAuthor_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(145, 444);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 0;
            label9.Text = "Status:";
            // 
            // cboxStatus
            // 
            cboxStatus.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxStatus.FormattingEnabled = true;
            cboxStatus.Location = new Point(145, 482);
            cboxStatus.Name = "cboxStatus";
            cboxStatus.Size = new Size(166, 31);
            cboxStatus.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 361);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 0;
            label10.Text = "Publisher:";
            // 
            // txtPublisher
            // 
            txtPublisher.BorderStyle = BorderStyle.FixedSingle;
            txtPublisher.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublisher.Location = new Point(15, 398);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(298, 32);
            txtPublisher.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(116, 86, 174);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(11, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 35);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(116, 86, 174);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(116, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 35);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(116, 86, 174);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(231, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 35);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelControl
            // 
            panelControl.Controls.Add(btnAdd);
            panelControl.Controls.Add(btnDelete);
            panelControl.Controls.Add(btnUpdate);
            panelControl.Location = new Point(3, 543);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(336, 46);
            panelControl.TabIndex = 17;
            // 
            // pBoxSearch
            // 
            pBoxSearch.BackColor = Color.White;
            pBoxSearch.Image = (Image)resources.GetObject("pBoxSearch.Image");
            pBoxSearch.Location = new Point(1068, 12);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(52, 34);
            pBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxSearch.TabIndex = 19;
            pBoxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(809, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 27);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // UC_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearch);
            Controls.Add(panelControl);
            Controls.Add(dataGridView);
            Controls.Add(cboxStatus);
            Controls.Add(cboxAuthor);
            Controls.Add(cboxGenre);
            Controls.Add(txtQuantity);
            Controls.Add(txtPages);
            Controls.Add(txtYear);
            Controls.Add(txtPublisher);
            Controls.Add(txtTitle);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "UC_Book";
            Size = new Size(1148, 639);
            Load += UC_Book_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Label label2;
        private ComboBox cboxGenre;
        private Label label3;
        private TextBox txtTitle;
        private DataGridView dataGridView;
        private Label label4;
        private Label label5;
        private TextBox txtYear;
        private Label label6;
        private TextBox txtPages;
        private Label label7;
        private TextBox txtQuantity;
        private Label label8;
        private ComboBox cboxAuthor;
        private Label label9;
        private ComboBox cboxStatus;
        private Button btnEdit;
        private Label label10;
        private TextBox txtPublisher;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelControl;
        private PictureBox pBoxSearch;
        private TextBox txtSearch;
    }
}
