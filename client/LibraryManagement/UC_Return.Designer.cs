namespace LibraryManagement
{
    partial class UC_Return
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
            dgvBorrowedBooks = new DataGridView();
            dfsdf = new Label();
            btnReturn = new Button();
            dateTimePickerReturn = new DateTimePicker();
            label1 = new Label();
            txtBookID = new TextBox();
            label2 = new Label();
            dateTimePickerBorrow = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtAccountID = new TextBox();
            label7 = new Label();
            txtBorrowID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.BackgroundColor = Color.White;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(16, 268);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.RowTemplate.Height = 29;
            dgvBorrowedBooks.Size = new Size(1113, 371);
            dgvBorrowedBooks.TabIndex = 0;
            dgvBorrowedBooks.CellClick += dgvBorrowedBooks_CellClick;
            // 
            // dfsdf
            // 
            dfsdf.AutoSize = true;
            dfsdf.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dfsdf.Location = new Point(447, 13);
            dfsdf.Name = "dfsdf";
            dfsdf.Size = new Size(176, 34);
            dfsdf.TabIndex = 1;
            dfsdf.Text = "Return Book";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.Location = new Point(870, 177);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(172, 66);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateTimePickerReturn
            // 
            dateTimePickerReturn.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerReturn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerReturn.Location = new Point(870, 127);
            dateTimePickerReturn.Name = "dateTimePickerReturn";
            dateTimePickerReturn.Size = new Size(172, 32);
            dateTimePickerReturn.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(870, 84);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 8;
            label1.Text = "Return Date";
            // 
            // txtBookID
            // 
            txtBookID.BorderStyle = BorderStyle.FixedSingle;
            txtBookID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookID.Location = new Point(16, 121);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(100, 32);
            txtBookID.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 84);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 9;
            label2.Text = "Book ID:";
            // 
            // dateTimePickerBorrow
            // 
            dateTimePickerBorrow.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBorrow.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBorrow.Location = new Point(16, 211);
            dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            dateTimePickerBorrow.Size = new Size(172, 32);
            dateTimePickerBorrow.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 172);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 8;
            label3.Text = "Borrowed Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 84);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 9;
            label4.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(138, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(176, 32);
            txtTitle.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(332, 172);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 9;
            label5.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(332, 209);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 32);
            txtName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(332, 84);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 9;
            label6.Text = "Account ID:";
            // 
            // txtAccountID
            // 
            txtAccountID.BorderStyle = BorderStyle.FixedSingle;
            txtAccountID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountID.Location = new Point(332, 121);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(126, 32);
            txtAccountID.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 24);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 9;
            label7.Text = "Borrow ID:";
            // 
            // txtBorrowID
            // 
            txtBorrowID.BorderStyle = BorderStyle.FixedSingle;
            txtBorrowID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorrowID.Location = new Point(138, 20);
            txtBorrowID.Name = "txtBorrowID";
            txtBorrowID.Size = new Size(176, 32);
            txtBorrowID.TabIndex = 10;
            // 
            // UC_Return
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtName);
            Controls.Add(txtTitle);
            Controls.Add(txtAccountID);
            Controls.Add(txtBorrowID);
            Controls.Add(txtBookID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dateTimePickerBorrow);
            Controls.Add(label1);
            Controls.Add(dateTimePickerReturn);
            Controls.Add(btnReturn);
            Controls.Add(dfsdf);
            Controls.Add(dgvBorrowedBooks);
            Name = "UC_Return";
            Size = new Size(1148, 639);
            Load += UC_Return_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Label dfsdf;
        private Button btnReturn;
        private DateTimePicker dateTimePickerReturn;
        private Label label1;
        private TextBox txtBookID;
        private Label label2;
        private DateTimePicker dateTimePickerBorrow;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private TextBox txtAccountID;
        private Label label7;
        private TextBox txtBorrowID;
    }
}
