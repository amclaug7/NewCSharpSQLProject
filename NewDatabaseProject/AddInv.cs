using System;
using System.Data;
using System.Windows.Forms;

namespace NewDatabaseProject
{
    public partial class AddInv : Form
    {
        public AddInv()
        {
            InitializeComponent();
        }

        string vin;
        int year;
        string make;
        string model;
        string trim;
        string color;
        int mileage;

        private void AddInv_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i >= 1900; i--)
            {
                cbxYear.Items.Add(i);
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (tbxVin.Text.Length == 17)
            {
                if (String.IsNullOrEmpty(tbxMake.Text) == false)
                {
                    if (String.IsNullOrEmpty(tbxModel.Text) == false)
                    {
                        if (String.IsNullOrEmpty(tbxTrim.Text) == false)
                        {
                            if (String.IsNullOrEmpty(tbxColor.Text) == false)
                            {
                                try
                                {
                                    vin = tbxVin.Text;
                                    year = int.Parse(cbxYear.Text);
                                    make = tbxMake.Text;
                                    model = tbxModel.Text;
                                    trim = tbxTrim.Text;
                                    color = tbxColor.Text;
                                    mileage = int.Parse(tbxMileage.Text);

                                    string query = $"insert into inventory values('{vin}','{color}','{make}','{model}','{trim}',{year},{mileage},0);";
                                    DataTable newCarTable = Filler.DataTableFiller(query);

                                    DataViewControl dvc = new DataViewControl();
                                    this.Hide();
                                    dvc.tabControl1.SelectedTab = dvc.inventoryPage;
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
                                MessageBox.Show("Please Enter Color");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Trim");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Model");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Make");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Vin");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataViewControl dvc = new DataViewControl();
            this.Hide();
            dvc.tabControl1.SelectedTab = dvc.inventoryPage;
            dvc.ShowDialog();
            this.Close();
        }
    }
}
