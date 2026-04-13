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
    public partial class UC_BorrowBook : UserControl
    {
        SqlConnection conn;
        public UC_BorrowBook()
        {
            InitializeComponent();
            CreateConnection();
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

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    ClearLabels(); 
                    return;
                }

                int bookID;
          
                if (!int.TryParse(txtBookID.Text, out bookID))
                {
                    ClearLabels(); 
                    return;
                }

                conn.Open();

                string query = @"SELECT b.title, CONCAT(a.author_lname, ' ', a.author_fname) AS author_name, 
                                b.quantity, b.status 
                         FROM Books b 
                         INNER JOIN Authors a ON b.author_id = a.author_id 
                         WHERE b.book_id = @BookID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbBookID.Text = bookID.ToString();
                    lbTitle.Text = reader["title"].ToString();
                    lbAuthor.Text = reader["author_name"].ToString();
                    lbQuantity.Text = reader["quantity"].ToString();
                    lbStatus.Text = reader["status"].ToString();
                }
                else
                {
                    ClearLabels(); 
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearLabels()
        {
            lbBookID.Text = "";
            lbTitle.Text = "";
            lbAuthor.Text = "";
            lbQuantity.Text = "";
            lbStatus.Text = "";
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAccountID.Text))
                {
                    ClearAccountLabels();
                    return;
                }

                int accountID;
                if (!int.TryParse(txtAccountID.Text, out accountID))
                {
                    ClearAccountLabels();
                    return;
                }

                conn.Open();

                string query = @"SELECT first_name + ' ' + last_name AS full_name, 
                                gender, dateOfBirth, email, phone 
                         FROM Accounts 
                         WHERE account_id = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbAccountID.Text = accountID.ToString();
                    lbFullName.Text = reader["full_name"].ToString();
                    lbGender.Text = reader["gender"].ToString();
                    lbDob.Text = Convert.ToDateTime(reader["dateOfBirth"]).ToShortDateString();
                    lbEmail.Text = reader["email"].ToString();
                    lbPhone.Text = reader["phone"].ToString();
                }
                else
                {
                    ClearAccountLabels();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAccountLabels()
        {
            lbAccountID.Text = "";
            lbFullName.Text = "";
            lbGender.Text = "";
            lbDob.Text = "";
            lbEmail.Text = "";
            lbPhone.Text = "";
        }

        private void UC_BorrowBook_Load(object sender, EventArgs e)
        {
            ClearAccountLabels();
            ClearLabels();
        }
        private bool IsAccountActive(int accountID)
        {
            try
            {
                conn.Open();
                string query = "SELECT active FROM Accounts WHERE account_id = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountID);
                int isActive = (int)cmd.ExecuteScalar();
                conn.Close();
                return isActive == 1;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Is Account Active: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private int GetBorrowedQuantity(int bookID)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM borrows WHERE book_id = @BookID AND return_date IS NULL";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                int borrowedQuantity = (int)cmd.ExecuteScalar();
                conn.Close();
                return borrowedQuantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private int GetQuantityOfBook(int bookID)
        {
            try
            {
                conn.Open();
                string query = "SELECT quantity FROM books WHERE book_id = @BookID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                int borrowedQuantity = (int)cmd.ExecuteScalar();
                conn.Close();
                return borrowedQuantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lbAccountID.Text) || string.IsNullOrWhiteSpace(lbBookID.Text))
                {
                    MessageBox.Show("Please select both account and book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int accountID = int.Parse(lbAccountID.Text);
                int bookID = int.Parse(lbBookID.Text);

                if (!IsAccountActive(accountID))
                {
                    MessageBox.Show("The selected account is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int borrowedQuantity = GetBorrowedQuantity(bookID);
                if (borrowedQuantity >= GetQuantityOfBook(bookID))
                {
                    MessageBox.Show("The selected book has reached the maximum borrow limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime borrowDate = dateTimePickerBorrow.Value.Date;
                conn.Open();
                string query = "INSERT INTO borrows (account_id, book_id, borrow_date) VALUES (@AccountID, @BookID, @BorrowDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", accountID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
