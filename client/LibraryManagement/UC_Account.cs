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
    public partial class UC_Account : UserControl
    {
        SqlConnection conn;
        public UC_Account()
        {
            InitializeComponent();
            CreateConnection();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtID.ReadOnly = true;
            cboxGender.Items.Add("Male");
            cboxGender.Items.Add("Female");
            cboxRole.Items.Add("admin");
            cboxRole.Items.Add("user");

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

                string query = "SELECT * FROM Accounts";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                    txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                    txtLastName.Text = row.Cells["last_name"].Value.ToString();
                    txtID.Text = row.Cells["account_id"].Value.ToString();
                    txtEmail.Text = row.Cells["email"].Value.ToString();
                    if (row.Cells["gender"].Value.ToString() == "M")
                        cboxGender.Text = "Male";
                    else cboxGender.Text = "Female";
                    txtPhone.Text = row.Cells["phone"].Value.ToString();
                    dobDateTimePicker.Value = Convert.ToDateTime(row.Cells["dateOfBirth"].Value);

                    txtAddress.Text = row.Cells["address"].Value.ToString();
                    cboxRole.Text = row.Cells["role"].Value.ToString();
                    checkBoxActive.Checked = Convert.ToBoolean(row.Cells["active"].Value);
                    txtPassword.Text = row.Cells["password"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        // Sự kiện tạo hiệu ứng button
        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btnAdd.Size = new Size(btnAdd.Width + 5, btnAdd.Height + 5);
        }

        private void btnAdd_MouseDown(object sender, MouseEventArgs e)
        {
            btnAdd.Size = new Size(btnAdd.Width - 5, btnAdd.Height - 5);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInput())
                {
                    return;
                }

                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string gender = cboxGender.SelectedItem.ToString() == "Male" ? "M" : "F";
                string phone = txtPhone.Text;
                DateTime dateOfBirth = dobDateTimePicker.Value;
                string address = txtAddress.Text;
                string role = cboxRole.Text;
                bool active = checkBoxActive.Checked;
                string password = txtPassword.Text;

                if (IsEmailExits(email))
                {
                    MessageBox.Show("Email is existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Open();

                string query = @"INSERT INTO Accounts (first_name, last_name, email, gender, phone, dateOfBirth, address, role, active, password)
                 VALUES (@FirstName, @LastName, @Email, @Gender, @Phone, @DateOfBirth, @Address, @Role, @Active, @Password)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Active", active);
                cmd.Parameters.AddWithValue("@Password", password);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboxGender.SelectedItem == null)
            {
                MessageBox.Show("Please select gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in txtPhone.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Phone number must contain only digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(cboxRole.Text))
            {
                MessageBox.Show("Please select role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dobDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsEmailExits(String email)
        {
            try
            {
                conn.Open();
                String query = "SELECT COUNT(*) FROM Accounts WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0;

            }
            catch (Exception ex)
            {
                return true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInput())
                {
                    return;
                }

                int accountId = int.Parse(txtID.Text);
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string gender = cboxGender.SelectedItem.ToString() == "Male" ? "M" : "F";
                string phone = txtPhone.Text;
                DateTime dateOfBirth = dobDateTimePicker.Value;
                string address = txtAddress.Text;
                string role = cboxRole.Text;
                bool active = checkBoxActive.Checked;
                string password = txtPassword.Text;

                conn.Open();
                String query = "SELECT COUNT(*) FROM Accounts WHERE email = @Email AND account_id != @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ID", accountId);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Email is Exited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                query = @"UPDATE Accounts 
                         SET first_name = @FirstName, 
                             last_name = @LastName, 
                             email = @Email, 
                             gender = @Gender, 
                             phone = @Phone, 
                             dateOfBirth = @DateOfBirth, 
                             address = @Address, 
                             role = @Role, 
                             active = @Active, 
                             password = @Password 
                         WHERE account_id = @AccountId";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Active", active);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@AccountId", accountId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please choose an account to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Open();
                string query = "DELETE FROM Accounts WHERE account_id = @AccountID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", Convert.ToInt32(txtID.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }

}
