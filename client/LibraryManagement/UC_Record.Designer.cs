namespace LibraryManagement
{
    partial class UC_Record
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
            txtName = new TextBox();
            txtTitle = new TextBox();
            txtAccountID = new TextBox();
            txtBorrowID = new TextBox();
            txtBookID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerBorrow = new DateTimePicker();
            label1 = new Label();
            dateTimePickerReturn = new DateTimePicker();
            dfsdf = new Label();
            dgvRecord = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelControl = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(19, 316);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 32);
            txtName.TabIndex = 27;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(141, 149);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(176, 32);
            txtTitle.TabIndex = 26;
            // 
            // txtAccountID
            // 
            txtAccountID.BorderStyle = BorderStyle.FixedSingle;
            txtAccountID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountID.Location = new Point(19, 237);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(126, 32);
            txtAccountID.TabIndex = 25;
            // 
            // txtBorrowID
            // 
            txtBorrowID.BorderStyle = BorderStyle.FixedSingle;
            txtBorrowID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorrowID.Location = new Point(142, 67);
            txtBorrowID.Name = "txtBorrowID";
            txtBorrowID.Size = new Size(175, 32);
            txtBorrowID.TabIndex = 24;
            // 
            // txtBookID
            // 
            txtBookID.BorderStyle = BorderStyle.FixedSingle;
            txtBookID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookID.Location = new Point(19, 149);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(88, 32);
            txtBookID.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 277);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 21;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(141, 112);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 20;
            label4.Text = "Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 200);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 22;
            label6.Text = "Account ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 69);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 19;
            label7.Text = "Borrow ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 112);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 18;
            label2.Text = "Book ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 364);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 17;
            label3.Text = "Borrowed Date";
            // 
            // dateTimePickerBorrow
            // 
            dateTimePickerBorrow.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBorrow.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBorrow.Location = new Point(19, 403);
            dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            dateTimePickerBorrow.Size = new Size(172, 32);
            dateTimePickerBorrow.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 452);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 16;
            label1.Text = "Return Date";
            // 
            // dateTimePickerReturn
            // 
            dateTimePickerReturn.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerReturn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerReturn.Location = new Point(19, 495);
            dateTimePickerReturn.Name = "dateTimePickerReturn";
            dateTimePickerReturn.Size = new Size(172, 32);
            dateTimePickerReturn.TabIndex = 14;
            // 
            // dfsdf
            // 
            dfsdf.AutoSize = true;
            dfsdf.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dfsdf.Location = new Point(464, 11);
            dfsdf.Name = "dfsdf";
            dfsdf.Size = new Size(113, 34);
            dfsdf.TabIndex = 12;
            dfsdf.Text = "Record";
            // 
            // dgvRecord
            // 
            dgvRecord.BackgroundColor = Color.White;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(363, 69);
            dgvRecord.Name = "dgvRecord";
            dgvRecord.RowHeadersWidth = 51;
            dgvRecord.RowTemplate.Height = 29;
            dgvRecord.Size = new Size(770, 544);
            dgvRecord.TabIndex = 11;
            dgvRecord.CellClick += dgvRecord_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(0, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 57);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(163, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 57);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelControl
            // 
            panelControl.Controls.Add(btnUpdate);
            panelControl.Controls.Add(btnDelete);
            panelControl.Location = new Point(19, 560);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(312, 67);
            panelControl.TabIndex = 32;
            // 
            // UC_Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelControl);
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
            Controls.Add(dfsdf);
            Controls.Add(dgvRecord);
            Name = "UC_Record";
            Size = new Size(1148, 639);
            Load += UC_Record_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            panelControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtTitle;
        private TextBox txtAccountID;
        private TextBox txtBorrowID;
        private TextBox txtBookID;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerBorrow;
        private Label label1;
        private DateTimePicker dateTimePickerReturn;
        private Label dfsdf;
        private DataGridView dgvRecord;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelControl;
    }
}
