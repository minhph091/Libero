using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class UC_Book : UserControl
    {
        SqlConnection conn;
        private int author_id = -1;
        private int role;
        public UC_Book(int role)
        {
            InitializeComponent();
            CreateConnection();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cboxAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.role = role;
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
        private void display()
        {
            try
            {
                conn.Open();
                string query = @"SELECT 
                    Books.book_id AS id,
                    Books.title,
                    Books.publisher,
                    Books.quantity,
                    Books.released_year AS year,
                    Books.pages,
                    Books.status,
                    Books.genre,
                    CONCAT(Authors.author_lname, ' ', Authors.author_fName) AS author_name
                    FROM
                    Books
                    LEFT JOIN
                    Authors ON Books.author_id = Authors.author_id;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView.DataSource = dt;
                if (cboxAuthor.SelectedIndex != -1)
                {
                    query = "SELECT author_id FROM Authors WHERE CONCAT(author_lname, ' ', author_fName) = @AuthorName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AuthorName", cboxAuthor.SelectedItem.ToString());
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        author_id = Convert.ToInt32(result);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UC_Book_Load(object sender, EventArgs e)
        {
            if (role == 0) // ROLE IS USER
            {
                panelControl.Enabled = false;
                panelControl.Visible = false;
            }
            display();
            loadAuthors();
            txtID.ReadOnly = true;
            cboxGenre.Items.Add("Science Fiction");
            cboxGenre.Items.Add("Romance");
            cboxGenre.Items.Add("Mystery");
            cboxGenre.Items.Add("Fantasy");
            cboxGenre.Items.Add("Thriller");
            cboxGenre.Items.Add("Horror");

            cboxStatus.Items.Add("Available");
            cboxStatus.Items.Add("Unavailable");

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtID.Text = row.Cells["id"].Value.ToString();
                txtTitle.Text = row.Cells["title"].Value.ToString();
                cboxAuthor.Text = row.Cells["author_name"].Value.ToString();

                cboxGenre.Text = row.Cells["genre"].Value.ToString();
                txtYear.Text = row.Cells["year"].Value.ToString();
                txtPages.Text = row.Cells["pages"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                cboxStatus.Text = row.Cells["status"].Value.ToString();
                txtPublisher.Text = row.Cells["publisher"].Value.ToString();
            }
        }
        private void loadAuthors()
        {
            try
            {
                conn.Open();
                string query = "SELECT CONCAT(author_lname, ' ', author_fName) AS author_name FROM Authors";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cboxAuthor.Items.Clear();

                while (reader.Read())
                {
                    string authorName = reader["author_name"].ToString();
                    cboxAuthor.Items.Add(authorName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string authorName = cboxAuthor.SelectedItem?.ToString();
                string genre = cboxGenre.SelectedItem?.ToString();
                int year = int.Parse(txtYear.Text);
                int pages = int.Parse(txtPages.Text);
                int quantity = int.Parse(txtQuantity.Text);
                string status = cboxStatus.SelectedItem?.ToString();
                string publisher = txtPublisher.Text;

                if (!IsValidInput())
                {
                    return;
                }

                int authorId = author_id;

                if (authorId == -1)
                {
                    MessageBox.Show("Author not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Open();

                string query = @"INSERT INTO Books (title, author_id, genre, released_year, pages, quantity, status, publisher)
                         VALUES (@Title, @AuthorId, @Genre, @Year, @Pages, @Quantity, @Status, @Publisher)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@AuthorId", authorId);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Pages", pages);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Publisher", publisher);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPublisher.Text))
            {
                MessageBox.Show("Please enter a publisher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtYear.Text, out _))
            {
                MessageBox.Show("Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtPages.Text, out _) || int.Parse(txtPages.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid number of pages.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboxStatus.Text))
            {
                MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboxGenre.Text))
            {
                MessageBox.Show("Please select a genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboxAuthor.Text))
            {
                MessageBox.Show("Please select an author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInput())
                    return;
                conn.Open();
                if (author_id == -1)
                {
                    MessageBox.Show("Author not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = @"UPDATE Books
                            SET title = @title,
                                author_id = @author_id,
                                genre = @genre,
                                released_year = @year,
                                pages = @pages,
                                quantity = @quantity,
                                status = @status,
                                publisher = @publisher
                            WHERE book_id = @book_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@author_id", author_id);
                cmd.Parameters.AddWithValue("@genre", cboxGenre.Text);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtYear.Text));
                cmd.Parameters.AddWithValue("@pages", Convert.ToInt32(txtPages.Text));
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@status", cboxStatus.Text);
                cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@book_id", Convert.ToInt32(txtID.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void cboxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "SELECT author_id FROM Authors WHERE CONCAT(author_lname, ' ', author_fName) = @AuthorName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AuthorName", cboxAuthor.SelectedItem.ToString());
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    author_id = Convert.ToInt32(result);
                }
                conn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Please choose a book to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Open();
                string query = "DELETE FROM Books WHERE book_id = @Book_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_id", Convert.ToInt32(txtID.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTitle = txtSearch.Text.Trim();

                conn.Open();
                string query = @"SELECT 
                            Books.book_id AS id,
                            Books.title,
                            Books.publisher,
                            Books.quantity,
                            Books.released_year AS year,
                            Books.pages,
                            Books.status,
                            Books.genre,
                            CONCAT(Authors.author_lname, ' ', Authors.author_fName) AS author_name
                        FROM
                            Books
                        LEFT JOIN
                            Authors ON Books.author_id = Authors.author_id
                        WHERE
                            Books.title LIKE @SearchTitle";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@SearchTitle", "%" + searchTitle + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }

}
