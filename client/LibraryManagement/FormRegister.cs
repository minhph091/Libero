using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormRegister : Form
    {
        public event EventHandler ReturnToLogin; // Tạo sự kiện quay về form đăng nhập
        SqlConnection conn;
        public FormRegister()
        {
            InitializeComponent();
            CreateConnection();
            this.ControlBox = false;
            cboxGender.Items.Add("Male");
            cboxGender.Items.Add("Female");
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            cboxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            dobDateTimePicker.Value = new DateTime(2000, 1, 1);
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
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
        protected virtual void OnReturnToLogin()
        {
            ReturnToLogin?.Invoke(this, EventArgs.Empty);
        }

        // Kiem tra de quay tro ve form dang ky
        public void CheckAndClose()
        {
            if (this.Visible)
                this.Close();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            OnReturnToLogin();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
        }
        private bool IsValidInput()
        {

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter your first name and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime dob = dobDateTimePicker.Value;
            if (dob >= DateTime.Now)
            {
                MessageBox.Show("Invalid date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if (string.IsNullOrWhiteSpace(password) || password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match or are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string email = txtEmail.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string phone = txtPhone.Text;
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Please enter your address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return !phone.Any(char.IsLetter);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                DateTime dob = dobDateTimePicker.Value;
                string gender = cboxGender.SelectedItem.ToString();
                if (gender.Equals("Male")) gender = "M";
                else gender = "F";
                string password = txtPassword.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;

                if (IsEmailExists(email))
                {
                    MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (AddAccount(firstName, lastName, email, gender, phone, dob, address, "user", password))
                {
                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnReturnToLogin();
                }
                else
                {
                    MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsEmailExists(string email)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Accounts WHERE email = @Email";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Email", email);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                conn.Close();
            }
        }


        private bool AddAccount(string firstName, string lastName, string email, string gender, string phone,
            DateTime dob, string address, string role, string password)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO Accounts (first_name, last_name, email, gender, phone, dateOfBirth, address, role, password) 
                         VALUES (@FirstName, @LastName, @Email, @Gender, @Phone, @DateOfBirth, @Address, @Role, @Password)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@DateOfBirth", dob);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Password", password);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            cboxGender.SelectedIndex = -1;
            dobDateTimePicker.Value = new DateTime(2000, 1, 1);
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            checkBoxShowPassword.Checked = false;
        }
    }
}