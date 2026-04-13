using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement
{
    public partial class FormMenu : Form
    {
        private string role;
        private int role_INT;
        private string account_name;
        private FormLogin formLogin;
        private int account_id;
        public FormMenu(string role, string account_name, FormLogin formLogin, int account_id)
        {
            InitializeComponent();
            this.role = role;
            this.account_name = account_name;
            this.formLogin = formLogin;
            this.account_id = account_id;

            this.ControlBox = false; // Tat ControlBox
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lbAccountName.Text = account_name;
            if (role.Equals("admin"))
            {
                role_INT = 1;
                addUserControl(new UC_Dashboard());
                lbRole.Text = "Admin";
            }
            else
            {
                role_INT = 0;
                lbRole.Text = "User";
                addUserControl(new UC_Book(role_INT));
                btnDashboard.Visible = false;
                btnDashboard.Enabled = false;
                btnAccount.Visible = false;
                btnAccount.Enabled = false;
                btnReturnBook.Visible = false;
                btnReturnBook.Enabled = false;
                btnIssueBook.Visible = false;
                btnIssueBook.Enabled = false;

                btnRecord.Location = new Point(btnDashboard.Location.X, btnDashboard.Location.Y);
                btnRecord.Text = "History";

                //btnAccount.Location = new Point(289, 49);
            }
        }



        private void addUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Close();
        }

        private Button currentButtonWithBlue = null;

        private void CheckAndChangeOtherButtonColor(Button currentButton)
        {


            if (currentButtonWithBlue != null && currentButtonWithBlue != currentButton)
            {
                currentButtonWithBlue.BackColor = Color.FromArgb(26, 37, 40);
                currentButtonWithBlue = null;
            }

            currentButtonWithBlue = currentButton;
            currentButtonWithBlue.BackColor = Color.SkyBlue;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            CheckAndChangeOtherButtonColor(btnDashboard);
            addUserControl(new UC_Dashboard());

        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            CheckAndChangeOtherButtonColor(btnAccount);
            addUserControl(new UC_Account());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            CheckAndChangeOtherButtonColor(btnBook);
            addUserControl(new UC_Book(role_INT));
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.SkyBlue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            if (btnDashboard != currentButtonWithBlue)
            {
                btnDashboard.BackColor = Color.FromArgb(26, 37, 40);
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            CheckAndChangeOtherButtonColor(btnIssueBook);
            addUserControl(new UC_BorrowBook());
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            CheckAndChangeOtherButtonColor(btnReturnBook);
            addUserControl(new UC_Return());
        }



        private void btnRecord_Click(object sender, EventArgs e)
        {
            CheckAndChangeOtherButtonColor(btnRecord);
            addUserControl(new UC_Record(role_INT, account_id));
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
