using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDatabaseProject
{
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        int customerID;
        int inventoryID;
        int price;

        private void AddSale_Load(object sender, EventArgs e)
        {
            fillInventoryDataTable();
            fillCustomerDataTable();
        }

        private void fillInventoryDataTable()
        {
            string query = "select vin, color, make, model, modeltrim, modelyear, mileage " +
                            "from inventory " +
                            "where sold = 0;";

            DataTable Inventorydtbl = Filler.DataTableFiller(query);

            foreach (DataRow row in Inventorydtbl.Rows)
            {
                string[] rowarray = {row["vin"].ToString().Trim(),
                    row["color"].ToString().Trim(),
                    row["modelyear"].ToString().Trim(),
                    row["make"].ToString().Trim(),
                    row["model"].ToString().Trim(),
                    row["modeltrim"].ToString().Trim(),
                    row["mileage"].ToString().Trim()};

                inventoryGrid.Rows.Add(rowarray);
            }
        }

        private void fillCustomerDataTable()
        {
            string query = "select firstname, lastname, telephone, email " +
                            "from customer;";

            DataTable Customerdtbl = Filler.DataTableFiller(query);

            foreach (DataRow row in Customerdtbl.Rows)
            {
                string[] rowarray = {row["firstname"].ToString().Trim(),
                    row["lastname"].ToString().Trim(),
                    row["telephone"].ToString().Trim(),
                    row["email"].ToString().Trim()};

                customerGrid.Rows.Add(rowarray);
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string vin = this.inventoryGrid.CurrentRow.Cells[0].Value.ToString();
                    Int64 telephone = Int64.Parse(this.customerGrid.CurrentRow.Cells[2].Value.ToString());
                    decimal price = decimal.Parse(tbxPrice.Text);

                    string query = "select inventoryID " +
                                   "from inventory " +
                                   $"where vin = '{vin}';";

                    DataTable idtbl = Filler.DataTableFiller(query);

                    foreach (DataRow row in idtbl.Rows)
                    {
                        inventoryID = int.Parse(row["inventoryID"].ToString().Trim());
                    }

                    string query2 = "select customerID " +
                                    "from customer " +
                                    $"where telephone = {telephone};";

                    DataTable cdtbl = Filler.DataTableFiller(query2);

                    foreach (DataRow row in cdtbl.Rows)
                    {
                        customerID = int.Parse(row["customerID"].ToString().Trim());
                    }

                    string salesquery = $"insert into sales values({inventoryID},{customerID},{price}); " +
                                        $"update inventory set sold = 1 where inventoryID = {inventoryID};";

                    DataTable sdtbl = Filler.DataTableFiller(salesquery);

                    DataViewControl dvc = new DataViewControl();
                    this.Hide();
                    dvc.tabControl1.SelectedTab = dvc.salesPage;
                    dvc.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DataViewControl dvc = new DataViewControl();
            this.Hide();
            dvc.tabControl1.SelectedTab = dvc.salesPage;
            dvc.ShowDialog();
            this.Close();
        }
    }
}
