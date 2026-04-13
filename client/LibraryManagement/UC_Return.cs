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
    public partial class UC_Return : UserControl
    {
        SqlConnection conn;

        public UC_Return()
        {
            InitializeComponent();
            CreateConnection();
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void DisplayBorrowedBooks()
        {
            try
            {
                conn.Open();

                string query = @"SELECT borrows.borrow_id,books.book_id, Books.title,accounts.account_id, CONCAT(Accounts.first_name,' ', Accounts.last_name) AS name,borrows.borrow_date,borrows.return_date
                                FROM borrows
                                INNER JOIN Accounts ON borrows.account_id = Accounts.account_id
                                INNER JOIN Books ON borrows.book_id = Books.book_id
                                WHERE return_date IS NULL";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable borrowedBooksData = new DataTable();
                adapter.Fill(borrowedBooksData);

                dgvBorrowedBooks.DataSource = borrowedBooksData;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_Return_Load(object sender, EventArgs e)
        {
            DisplayBorrowedBooks();
            LockControls();
        }

        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvBorrowedBooks.Rows[e.RowIndex];

                    txtBorrowID.Text = row.Cells["borrow_id"].Value.ToString();
                    txtBookID.Text = row.Cells["book_id"].Value.ToString();
                    txtTitle.Text = row.Cells["title"].Value.ToString();
                    txtAccountID.Text = row.Cells["account_id"].Value.ToString();
                    txtName.Text = row.Cells["name"].Value.ToString();
                    dateTimePickerBorrow.Value = Convert.ToDateTime(row.Cells["borrow_date"].Value);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void LockControls()
        {
            txtBorrowID.ReadOnly = true;
            txtBookID.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtAccountID.ReadOnly = true;
            txtName.ReadOnly = true;
            dateTimePickerBorrow.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBorrowID.Text))
                {
                    MessageBox.Show("Please select a row in the borrowed books list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime borrowDate = dateTimePickerBorrow.Value;
                DateTime returnDate = dateTimePickerReturn.Value;
                if (returnDate <= borrowDate)
                {
                    MessageBox.Show("The return date of the book must be greater than the date the book was borrowed.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                conn.Open();

                string query = @"UPDATE borrows SET return_date = @ReturnDate WHERE borrow_id = @BorrowID";
                int borrowID = Convert.ToInt32(txtBorrowID.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmd.Parameters.AddWithValue("@BorrowID", borrowID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Success", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                DisplayBorrowedBooks();
                ClearTextBoxes();

            }
            catch(Exception ex)
            {

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
    }
}
