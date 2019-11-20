using System;
using System.Data;
using System.Windows.Forms;

namespace NewDatabaseProject
{
    public partial class DataViewControl : Form
    {
        public DataViewControl()
        {
            InitializeComponent();
        }

        private void DataViewControl_Load(object sender, EventArgs e)
        {
            fillInventoryDataTable();
            fillCustomerDataTable();
            fillSalesDataTable();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();

            this.Hide();
            li.ShowDialog();
            li.Dispose();
            this.Close();
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

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            AddInv av = new AddInv();

            this.Hide();
            av.ShowDialog();
            av.Dispose();
            this.Close();
        }

        private void btnDeleteInv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Wish To Delete", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string vin = inventoryGrid.CurrentRow.Cells[0].Value.ToString();

                string query = $"delete from inventory where vin = '{vin}';";
                Filler.InserterDeleter(query);

                inventoryGrid.Rows.Clear();
                fillInventoryDataTable();
            }
            else if (dialogResult == DialogResult.No)
            {

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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCus ac = new AddCus();

            this.Hide();
            ac.ShowDialog();
            ac.Dispose();
            this.Close();
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Wish To Delete", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string no = customerGrid.CurrentRow.Cells[2].Value.ToString();

                string query = $"delete from customer where telephone = {no};";
                Filler.InserterDeleter(query);

                customerGrid.Rows.Clear();
                fillCustomerDataTable();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void fillSalesDataTable()
        {
            string query = "select firstname, lastname, modelyear, make, model, modeltrim, price " +
                           "from customer, inventory, sales " +
                           "where sales.customerID = customer.customerID " +
                           "and sales.inventoryID = inventory.inventoryID;";

            DataTable Salesdtbl = Filler.DataTableFiller(query);

            foreach (DataRow row in Salesdtbl.Rows)
            {
                string[] rowarray = {row["firstname"].ToString().Trim() + " " + row["lastname"].ToString().Trim(),
                    row["modelyear"].ToString().Trim() + " " + row["make"].ToString().Trim() + " " + row["model"].ToString().Trim() + " " + row["modeltrim"].ToString().Trim(),
                    row["price"].ToString().Trim()};

                salesGrid.Rows.Add(rowarray);
            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            AddSale adds = new AddSale();

            this.Hide();
            adds.ShowDialog();
            adds.Dispose();
            this.Close();
        }
    }
}
