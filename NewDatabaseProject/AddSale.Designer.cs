namespace NewDatabaseProject
{
    partial class AddSale
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
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.SuspendLayout();
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
            this.inventoryGrid.Location = new System.Drawing.Point(12, 12);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.ReadOnly = true;
            this.inventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryGrid.Size = new System.Drawing.Size(643, 198);
            this.inventoryGrid.TabIndex = 2;
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
            this.customerGrid.Location = new System.Drawing.Point(12, 216);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(643, 198);
            this.customerGrid.TabIndex = 3;
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
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(303, 426);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 23);
            this.btnAddSale.TabIndex = 4;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(101, 429);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 7;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 476);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.inventoryGrid);
            this.Name = "AddSale";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrice;
    }
}