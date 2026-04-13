using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class UC_Record : UserControl
    {
        SqlConnection conn;
        private int role;
        private int account_id;
        public UC_Record(int role, int account_id)
        {
            InitializeComponent();
            CreateConnection();
            dgvRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtBorrowID.ReadOnly = true;
            this.role = role;
            this.account_id = account_id;
        }
        private void UC_Record_Load(object sender, EventArgs e)
        {
            if (role == 1)
            {
                DisplayRecords();
            }
            else if (role == 0)
            {
                DisplayUserRecords();
                panelControl.Enabled = false;
                panelControl.Visible = false;
            }
        }

        private void CreateConnection()
        {
            try
            {
                String stringConnection = "Server=LAPTOP-7P2N97JR; Database = LibraryManagement; Integrated Security = true";
                conn = new SqlConnection(stringConnection);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayUserRecords()
        {
            try
            {
                conn.Open();

                string query = @"SELECT borrows.borrow_id,books.book_id, Books.title,accounts.account_id, CONCAT(Accounts.first_name,' ', Accounts.last_name) AS name,borrows.borrow_date,borrows.return_date
                                FROM borrows
                                INNER JOIN Accounts ON borrows.account_id = Accounts.account_id
                                INNER JOIN Books ON borrows.book_id = Books.book_id
                                WHERE accounts.account_id = @Account_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Account_id", account_id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable borrowedBooksData = new DataTable();
                adapter.Fill(borrowedBooksData);

                dgvRecord.DataSource = borrowedBooksData;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayRecords()
        {
            try
            {
                conn.Open();

                string query = @"SELECT borrows.borrow_id,books.book_id, Books.title,accounts.account_id, CONCAT(Accounts.first_name,' ', Accounts.last_name) AS name,borrows.borrow_date,borrows.return_date
                                FROM borrows
                                INNER JOIN Accounts ON borrows.account_id = Accounts.account_id
                                INNER JOIN Books ON borrows.book_id = Books.book_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable borrowedBooksData = new DataTable();
                adapter.Fill(borrowedBooksData);

                dgvRecord.DataSource = borrowedBooksData;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int borrowID;
            int bookID;
            int accountID;
            DateTime borrowDate;
            DateTime returnDate;

            if (!int.TryParse(txtBorrowID.Text, out borrowID) ||
                !int.TryParse(txtBookID.Text, out bookID) ||
                !int.TryParse(txtAccountID.Text, out accountID))
            {
                MessageBox.Show("Please enter valid numeric values for Borrow ID, Book ID, and Account ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            borrowDate = dateTimePickerBorrow.Value;
            returnDate = dateTimePickerReturn.Value;

            try
            {
                conn.Open();

                string query = @"UPDATE borrows 
                         SET book_id = @BookID, account_id = @AccountID, borrow_date = @BorrowDate, return_date = @ReturnDate 
                         WHERE borrow_id = @BorrowID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@AccountID", accountID);
                cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmd.Parameters.AddWithValue("@BorrowID", borrowID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            int borrowID;

            if (!int.TryParse(txtBorrowID.Text, out borrowID))
            {
                MessageBox.Show("Please enter a valid numeric value for Borrow ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                string query = @"DELETE FROM borrows WHERE borrow_id = @BorrowID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BorrowID", borrowID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                ClearTextBoxes();
                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearTextBoxes()
        {
            txtBorrowID.Clear();
            txtBookID.Clear();
            txtTitle.Clear();
            txtAccountID.Clear();
            txtName.Clear();
            dateTimePickerBorrow.Value = DateTime.Now;
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvRecord.Rows[e.RowIndex];

                    txtBorrowID.Text = row.Cells["borrow_id"].Value.ToString();
                    txtBookID.Text = row.Cells["book_id"].Value.ToString();
                    txtTitle.Text = row.Cells["title"].Value.ToString();
                    txtAccountID.Text = row.Cells["account_id"].Value.ToString();
                    txtName.Text = row.Cells["name"].Value.ToString();
                    dateTimePickerBorrow.Value = Convert.ToDateTime(row.Cells["borrow_date"].Value);
                    dateTimePickerReturn.Value = Convert.ToDateTime(row.Cells["return_date"].Value);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }


}
