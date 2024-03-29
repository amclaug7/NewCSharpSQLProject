﻿using System;
using System.Data;
using System.Windows.Forms;

namespace NewDatabaseProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            NewAccountCreation nac = new NewAccountCreation();

            this.Hide();
            nac.ShowDialog();
            nac.Dispose();
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            string queryUsername = $"select username, password from account " +
                                        $"where username = '{username}';";
            
            DataTable Usernamedtbl = Filler.DataTableFiller(queryUsername);

            if (Usernamedtbl.Rows.Count == 0)
            {
                MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow row in Usernamedtbl.Rows)
                {
                    if (row["password"].ToString().Trim() != Encryption.sha256(password))
                    {
                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataViewControl dvc = new DataViewControl();

                        this.Hide();
                        dvc.ShowDialog();
                        dvc.Dispose();
                        this.Close();
                    }
                }
            }
        }
    }
}
