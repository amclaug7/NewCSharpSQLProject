using System;
using System.Data;
using System.Windows.Forms;

namespace NewDatabaseProject
{
    public partial class AddCus : Form
    {
        public AddCus()
        {
            InitializeComponent();
        }

        string firstname;
        string lastname;
        Int64 phoneno;
        string email;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (tbxAreaCode.Text.Length == 3)
            {
                if (tbxPhoneNo.Text.Length == 7)
                {
                    if (String.IsNullOrEmpty(tbxFirstname.Text) == false)
                    {
                        if (String.IsNullOrEmpty(tbxLastname.Text) == false)
                        {
                            if (String.IsNullOrEmpty(tbxEmail.Text) == false)
                            {
                                try
                                {
                                    firstname = tbxFirstname.Text;
                                    lastname = tbxLastname.Text;
                                    email = tbxEmail.Text;
                                    phoneno = Int64.Parse(tbxAreaCode.Text + tbxPhoneNo.Text);

                                    string query = $"insert into customer values('{lastname}','{firstname}','{email}',{phoneno});";                                   
                                    Filler.InserterDeleter(query);

                                    DataViewControl dvc = new DataViewControl();
                                    this.Hide();
                                    dvc.tabControl1.SelectedTab = dvc.customerPage;
                                    dvc.ShowDialog();
                                    this.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Email");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Last Name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter First Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Phone Number");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Phone Number");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataViewControl dvc = new DataViewControl();
            this.Hide();
            dvc.tabControl1.SelectedTab = dvc.customerPage;
            dvc.ShowDialog();
            this.Close();
        }
    }
}
