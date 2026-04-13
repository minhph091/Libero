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
    public partial class UC_Dashboard : UserControl
    {
        SqlConnection conn;
        public UC_Dashboard()
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
        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            UpdateDashboard();
        }
        private void UpdateDashboard()
        {
            try
            {
                conn.Open();
                String query = "SELECT COUNT(*) FROM accounts";
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = (int)cmd.ExecuteScalar();
                labelTotalAccount.Text = count.ToString();

                query = "SELECT SUM(quantity) FROM books";
                cmd = new SqlCommand(query, conn);
                count = (int)cmd.ExecuteScalar();
                lbTotalBook.Text = count.ToString();


                query = "SELECT COUNT(*) FROM borrows WHERE return_date IS NULL";
                cmd = new SqlCommand(query, conn);
                count = (int)cmd.ExecuteScalar();
                lbIssuedBook.Text = count.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
