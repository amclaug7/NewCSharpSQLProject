using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NewDatabaseProject
{
    public partial class NewAccountCreation : Form
    {
        public NewAccountCreation()
        {
            InitializeComponent();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbxPassword.Text;

            var regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");

            if (regex.IsMatch(password))
            {
                lblPasswordQuality.Text = "✓";
                lblPasswordQuality.ForeColor = Color.Green;
            }
            else
            {
                lblPasswordQuality.Text = "X";
                lblPasswordQuality.ForeColor = Color.Red;
            }

            if (tbxPassword.Text != tbxConfirmPassword.Text)
            {
                lblPasswordMatching.Text = "X";
                lblPasswordMatching.ForeColor = Color.Red;
            }
            else
            {
                lblPasswordMatching.Text = "✓";
                lblPasswordMatching.ForeColor = Color.Green;
            }
        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbxPassword.Text != tbxConfirmPassword.Text)
            {
                lblPasswordMatching.Text = "X";
                lblPasswordMatching.ForeColor = Color.Red;
            }
            else
            {
                lblPasswordMatching.Text = "✓";
                lblPasswordMatching.ForeColor = Color.Green;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            string queryUsername = $"select username from account " +
                                        $"where username = '{username}';";

            DataTable Usernamedtbl = Filler.DataTableFiller(queryUsername);

            if (Usernamedtbl.Rows.Count != 0)
            {
                MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (lblPasswordQuality.ForeColor != Color.Green)
                {
                    MessageBox.Show("Create Stronger Password", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (tbxPassword.Text != tbxConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords Do Not Match", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Account g = new Account(username, password);

                    string queryCreateAccount = $"insert into account values('{g.GetUsername()}','{Encryption.sha256(g.GetPassword())}');";

                    DataTable Accountdtbl = Filler.DataTableFiller(queryCreateAccount);

                    MessageBox.Show("Account Created", "New", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    var f = new LogIn();

                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var f = new LogIn();

            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
