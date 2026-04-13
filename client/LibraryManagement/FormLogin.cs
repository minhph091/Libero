using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class FormLogin : Form
    {
        SqlConnection conn;
        private string _roles;
        private FormRegister formRegister;
        public FormLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
            formRegister = new FormRegister();
            formRegister.ReturnToLogin += FormRegister_ReturnToLogin;
            createConnection();

        }
        private void createConnection()
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

        private void FormRegister_ReturnToLogin(object sender, EventArgs e)
        {
            formRegister.CheckAndClose(); 
            this.Show();
        }


        private void lbSignUp_Click(object sender, EventArgs e)
        {
            if (formRegister == null || formRegister.IsDisposed)
            {
                formRegister = new FormRegister();
                formRegister.ReturnToLogin += FormRegister_ReturnToLogin;
            }
            formRegister.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
            }
            else txtPassword.PasswordChar = '\0';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLabel();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                conn.Open();
                string query = @"SELECT * FROM Accounts WHERE email = @Email AND password = @Password AND active = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    string accountName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    int id  = Convert.ToInt32(reader["account_id"]);
                    this.Hide();

                    FormMenu formMenu = new FormMenu(role, accountName, this,id);
                    formMenu.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password, or account is inactive.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                ClearLabel();
            }
        }

        private void ClearLabel()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }

}
