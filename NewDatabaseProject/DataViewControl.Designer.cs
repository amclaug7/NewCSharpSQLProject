namespace NewDatabaseProject
{
    partial class DataViewControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogOut = new System.Windows.Forms.Button();
            this.inventoryPage = new System.Windows.Forms.TabPage();
            this.btnDeleteInv = new System.Windows.Forms.Button();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.salesPage = new System.Windows.Forms.TabPage();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.salesGrid = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.customerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.salesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(53, 288);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // inventoryPage
            // 
            this.inventoryPage.Controls.Add(this.btnDeleteInv);
            this.inventoryPage.Controls.Add(this.btnAddInventory);
            this.inventoryPage.Controls.Add(this.inventoryGrid);
            this.inventoryPage.Location = new System.Drawing.Point(4, 22);
            this.inventoryPage.Name = "inventoryPage";
            this.inventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryPage.Size = new System.Drawing.Size(654, 243);
            this.inventoryPage.TabIndex = 1;
            this.inventoryPage.Text = "Inventory";
            this.inventoryPage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInv
            // 
            this.btnDeleteInv.Location = new System.Drawing.Point(320, 210);
            this.btnDeleteInv.Name = "btnDeleteInv";
            this.btnDeleteInv.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteInv.TabIndex = 3;
            this.btnDeleteInv.Text = "Delete";
            this.btnDeleteInv.UseVisualStyleBackColor = true;
            this.btnDeleteInv.Click += new System.EventHandler(this.btnDeleteInv_Click);
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(182, 210);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 23);
            this.btnAddInventory.TabIndex = 2;
            this.btnAddInventory.Text = "Add Inventory";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.AllowUserToAddRows = false;
            this.inventoryGrid.AllowUserToDeleteRows = false;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vin,
            this.Color,
            this.Year,
            this.Make,
            this.Model,
            this.Trim,
            this.Mileage});
            this.inventoryGrid.Location = new System.Drawing.Point(6, 6);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            this.inventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryGrid.Size = new System.Drawing.Size(643, 198);
            this.inventoryGrid.TabIndex = 1;
            // 
            // vin
            // 
            this.vin.HeaderText = "VIN";
            this.vin.Name = "vin";
            this.vin.ReadOnly = true;
            this.vin.Visible = false;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            this.Make.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Trim
            // 
            this.Trim.HeaderText = "Trim";
            this.Trim.Name = "Trim";
            this.Trim.ReadOnly = true;
            // 
            // Mileage
            // 
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            this.Mileage.Width = 83;
            // 
            // customerPage
            // 
            this.customerPage.Controls.Add(this.btnDeleteCus);
            this.customerPage.Controls.Add(this.btnAddCustomer);
            this.customerPage.Controls.Add(this.customerGrid);
            this.customerPage.Location = new System.Drawing.Point(4, 22);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(654, 243);
            this.customerPage.TabIndex = 0;
            this.customerPage.Text = "Customers";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Location = new System.Drawing.Point(311, 211);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCus.TabIndex = 2;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(138, 211);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AllowUserToDeleteRows = false;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.telephone,
            this.email});
            this.customerGrid.Location = new System.Drawing.Point(7, 7);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(643, 198);
            this.customerGrid.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Phone No.";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email Address";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inventoryPage);
            this.tabControl1.Controls.Add(this.customerPage);
            this.tabControl1.Controls.Add(this.salesPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 269);
            this.tabControl1.TabIndex = 2;
            // 
            // salesPage
            // 
            this.salesPage.Controls.Add(this.btnAddSales);
            this.salesPage.Controls.Add(this.salesGrid);
            this.salesPage.Location = new System.Drawing.Point(4, 22);
            this.salesPage.Name = "salesPage";
            this.salesPage.Size = new System.Drawing.Size(654, 243);
            this.salesPage.TabIndex = 2;
            this.salesPage.Text = "Sales";
            this.salesPage.UseVisualStyleBackColor = true;
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(83, 208);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(75, 23);
            this.btnAddSales.TabIndex = 1;
            this.btnAddSales.Text = "Add";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // salesGrid
            // 
            this.salesGrid.AllowUserToAddRows = false;
            this.salesGrid.AllowUserToDeleteRows = false;
            this.salesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.car,
            this.price});
            this.salesGrid.Location = new System.Drawing.Point(4, 4);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.ReadOnly = true;
            this.salesGrid.Size = new System.Drawing.Size(643, 198);
            this.salesGrid.TabIndex = 0;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 150;
            // 
            // car
            // 
            this.car.HeaderText = "Car";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            this.car.Width = 250;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // DataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 326);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogOut);
            this.Name = "DataViewControl";
            this.Text = "Dealership";
            this.Load += new System.EventHandler(this.DataViewControl_Load);
            this.inventoryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.customerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.salesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Button btnAddCustomer;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage customerPage;
        public System.Windows.Forms.TabPage inventoryPage;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.DataGridView salesGrid;
        public System.Windows.Forms.TabPage salesPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnDeleteInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

