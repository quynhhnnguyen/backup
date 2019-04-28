using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProjectLib;

namespace ThreadedProjectII
{
    public partial class frmPackage : Form
    {
        /*From to manage Packages and Packages products
         * Author: Muhammad Islam
         Created: Jan, 2019*/
        public frmPackage()
        {
            InitializeComponent();
        }
        int pkgUpdateSuppId = 0;
        //Atuomatic buttons created for dialogues buttons
        // User pressed OK during step 1 for adding packages
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPkgConfirmation form1 = new frmPkgConfirmation();
            form1.Activate();
            form1.Show();
        }

        // User pressed CANCEL during step 1 for adding packages
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Adding \"Packages\"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }


        //add packages, based on the criteria
        private void btnAddPackage_Click_1(object sender, EventArgs e)
        {
            if (validaterClass.isProvided(txtPkgName, "Package Name can not be empty")
               && (validaterClass.validateDate(Convert.ToDateTime(dtPkgStartDate.Text), Convert.ToDateTime(dtPkgEndDate.Text))
               && (validaterClass.isProvided(txtPkgDesc, "Package Description can not be empty"))
               && (validaterClass.isProvided(txtPkgBasePrice, "Package Base Price can not be empty"))
               && (validaterClass.isNonNegativeDoub(txtPkgBasePrice, "Package Price must be a Positive Whole number"))
               && (validaterClass.isProvided(txtPkgComision, "Agency Comm can not be empty"))
               && (validaterClass.isNonNegativeDoub(txtPkgComision, "Agency Comm must be a positive whole number")
               &&(validaterClass.isValidateComm(txtPkgBasePrice,txtPkgComision)))))
            {
                try
                {
                    PackageDB addPkgObj = new PackageDB();
                    string pkgName = Convert.ToString(txtPkgName.Text);
                    DateTime pkgStartDate = Convert.ToDateTime(dtPkgStartDate.Text);
                    DateTime pkgEndDate = Convert.ToDateTime(dtPkgEndDate.Text);
                    string pkgDesc = Convert.ToString(txtPkgDesc.Text);
                    decimal pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    decimal pkgAgencyComm = Convert.ToDecimal(txtPkgComision.Text);
               
                addPkgObj.addPackage(pkgName, pkgStartDate, pkgEndDate, pkgDesc, pkgBasePrice, pkgAgencyComm);
                if (addPkgObj.FillDataGrid())
                {

                    pkgDataGrid.DataSource = addPkgObj.dt;
                }
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Clear_Form();
            }
        }
        //on form load populate data into grid views
        private void frmPackage_Load(object sender, EventArgs e)
        {
           
            PackageDB productsObj = new PackageDB();
            if (productsObj.FillDataGrid())
            {

                pkgDataGrid.DataSource = productsObj.dt;
            }
            if (productsObj.fetchProducts())
            {
                while (productsObj.reader.Read())
                {
                    cmbProducts.Items.Add(Convert.ToString(productsObj.reader.GetValue(0)));
                }
                productsObj.reader.Close();
            }
            Load_PkgProducts();           
            Customize_GridView();
            CustomizeProductGrid();
            Clear_Form();
        }
        //On combo box selected index changed event populate data into list box
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageDB supplierObj = new PackageDB();
            int getPkgId = 0;

            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];

                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
                Package_AddProduct_DB getSupIdobj = new Package_AddProduct_DB();
                getSupIdobj.GetSupplierId(getPkgId);
                pkgProductGrid.DataSource = getSupIdobj.getPackageProduct();

            }
            if (supplierObj.FetchSuppliers(Convert.ToString(cmbProducts.Text), getPkgId))
            {
                lstSuppliers.Items.Clear();
                while (supplierObj.reader.Read())
                {
                    lstSuppliers.Items.Add(supplierObj.reader.GetValue(0));
                }
                supplierObj.reader.Close();
            }
        }
        //On gridview click refresh the data
        private void pkgDataGrid_Click(object sender, EventArgs e)
        {
            int getPkgId = 0;           

            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];

                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);                
                Package_AddProduct_DB getSupIdobj = new Package_AddProduct_DB();
                getSupIdobj.GetSupplierId(getPkgId);
                pkgProductGrid.DataSource = getSupIdobj.getPackageProduct();

            }
          

        }
        //Function to load the package products into grid on call
        private void Load_PkgProducts()
        {
            int getPkgId;
            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];

                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);                
                Package_AddProduct_DB loadPkgProdObj = new Package_AddProduct_DB();
                loadPkgProdObj.GetSupplierId(getPkgId);
                pkgProductGrid.DataSource = loadPkgProdObj.getPackageProduct();
            }
        }
        //Add product to database on click
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cmbProducts.Text == "" || lstSuppliers.Text == "")
            {
                MessageBox.Show("Please choose a Product and a Supplier");
            }
            else
            {
                Package_AddProduct_DB addProdObj = new Package_AddProduct_DB();
                int getPkgId = 0;
                string prodName = Convert.ToString(cmbProducts.Text);
                string supName = Convert.ToString(lstSuppliers.Text);
                if (pkgDataGrid.SelectedCells.Count > 0)
                {
                    int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];

                    getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
                }
                if (addProdObj.AddPackageProduct(supName, prodName, getPkgId))
                {
                    MessageBox.Show("Product added Successfully");
                }
                Load_PkgProducts();
                ClearProductForm();               

            }

        }
        //Customize and format the package data gridview on call
        void Customize_GridView()
        {
            pkgDataGrid.Columns[0].Visible = false;
            pkgDataGrid.Columns[1].HeaderText = "Product Name";
            pkgDataGrid.Columns[2].HeaderText = "Starting Date";
            pkgDataGrid.Columns[3].HeaderText = "Ending Date";
            pkgDataGrid.Columns[4].HeaderText = "Description";
            pkgDataGrid.Columns[5].HeaderText = "Base Price";
            pkgDataGrid.Columns[6].HeaderText = "Agency Comm";
            pkgProductGrid.Columns[0].HeaderText = "Product Name";
            pkgProductGrid.Columns[1].HeaderText = "Supp Name";
            pkgDataGrid.Columns[5].DefaultCellStyle.Format = "0.00##";
            pkgDataGrid.Columns[6].DefaultCellStyle.Format = "0.00##";
            pkgDataGrid.AutoResizeColumns();
            pkgDataGrid.EnableHeadersVisualStyles = false;
            pkgDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Wheat;
            pkgDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
           pkgDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

        }
        //Cusomize and format products gridview on call
        void CustomizeProductGrid()
        {
           pkgProductGrid.AutoResizeColumns();
            pkgProductGrid.EnableHeadersVisualStyles = false;
            pkgProductGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Wheat;
            pkgProductGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
            pkgProductGrid.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int getPkgId = 0;
            string pkgName = "";
            DateTime strDate;
            DateTime endDate;
            string description;
            decimal basePrice = 0;
            decimal agencyComm = 0;
            dtPkgStartDate.Format = DateTimePickerFormat.Long;
            dtPkgEndDate.Format = DateTimePickerFormat.Long;

            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];
                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
                pkgName = Convert.ToString(selectedRow.Cells["PkgName"].Value);
                strDate = Convert.ToDateTime(selectedRow.Cells["PkgStartDate"].Value);
                endDate = Convert.ToDateTime(selectedRow.Cells["PkgEndDate"].Value);
                description = Convert.ToString(selectedRow.Cells["PkgDesc"].Value);
                basePrice = Convert.ToDecimal(selectedRow.Cells["PkgBasePrice"].Value);
                agencyComm = Convert.ToDecimal(selectedRow.Cells["PkgAgencyCommission"].Value);
                txtPkgName.Text = pkgName;
                dtPkgStartDate.Text = Convert.ToString(strDate);
                dtPkgEndDate.Text = Convert.ToString(endDate);
                txtPkgDesc.Text = description;
                txtPkgBasePrice.Text = Convert.ToString(basePrice);
                txtPkgComision.Text = Convert.ToString(agencyComm);
                btnSaveUpdate.Enabled = true;
                btnAddPackage.Enabled = false;
                btnPkgDelete.Enabled = false;


            }
        }
        //Save update package products on click
        private void pkgSaveUpdate_Click(object sender, EventArgs e)
        {
            if (validaterClass.isProvided(txtPkgName, "Package Name can not be empty")
              && (validaterClass.validateDate(Convert.ToDateTime(dtPkgStartDate.Text), Convert.ToDateTime(dtPkgEndDate.Text))
              && (validaterClass.isProvided(txtPkgDesc, "Package Description can not be empty"))
              && (validaterClass.isProvided(txtPkgBasePrice, "Package Base Price can not be empty"))
              && (validaterClass.isNonNegativeDoub(txtPkgBasePrice, "Package Price must be a Positive Whole number"))
              && (validaterClass.isProvided(txtPkgComision, "Agency Comm can not be empty"))
              && (validaterClass.isNonNegativeDoub(txtPkgComision, "Agency Comm must be a positive whole number")
              && (validaterClass.isValidateComm(txtPkgBasePrice, txtPkgComision)))))
            {
                int getPkgId = 0;
                string pkgName = txtPkgName.Text;
                DateTime pkgStrdDate = Convert.ToDateTime(dtPkgStartDate.Text);
                DateTime pkgEndDate = Convert.ToDateTime(dtPkgEndDate.Text);
                string description = txtPkgDesc.Text;
                decimal basePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                decimal agencyComm = Convert.ToDecimal(txtPkgComision.Text);

                if (pkgDataGrid.SelectedCells.Count > 0)
                {
                    int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];

                    getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
                }

                Package_AddProduct_DB updatePackageObj = new Package_AddProduct_DB();
                if (updatePackageObj.UpdatePackages(getPkgId, pkgName, pkgStrdDate, pkgEndDate, description, basePrice, agencyComm))
                {
                    MessageBox.Show("Package Updated Successfully");
                    pkgDataGrid.Focus();
                    pkgDataGrid.Columns[0].Selected = true;

                }
               //format the form
                Clear_Form();
                btnSaveUpdate.Enabled = false;
                btnAddPackage.Enabled = true;
                btnPkgDelete.Enabled = true;

                PackageDB productsObj = new PackageDB();
                if (productsObj.FillDataGrid())
                {

                    pkgDataGrid.DataSource = productsObj.dt;
                    
                }
                Refresh_Products_Onupdate();


            }
        }
        //Function to clear and fromat the packages form
        void Clear_Form()
        {
            txtPkgName.Text = "";
            dtPkgStartDate.Text = "";
            dtPkgEndDate.Text = "";
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgComision.Text = "";
            dtPkgStartDate.Format = DateTimePickerFormat.Custom;
            dtPkgStartDate.CustomFormat = " ";
            dtPkgEndDate.Format = DateTimePickerFormat.Custom;
            dtPkgEndDate.CustomFormat = " ";
        }
        //update specific package products
        private void btnUpdatSpecificPkg_Click(object sender, EventArgs e)
        {
            string pkgProdName = "";
            string pkgSuppName = "";            
            pkgProductGrid.Refresh();
            if (pkgProductGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgProductGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pkgProductGrid.Rows[selectedrowindex];
                pkgProdName = Convert.ToString(selectedRow.Cells[0].Value);
                pkgSuppName = Convert.ToString(selectedRow.Cells[1].Value);
                cmbProducts.SelectedItem = pkgProdName;
                lstSuppliers.SelectedItem = pkgSuppName;
                Package_AddProduct_DB updatePackagesPordObj = new Package_AddProduct_DB();
                pkgUpdateSuppId = updatePackagesPordObj.Get_Package_Product_SupplierId(pkgProdName, pkgSuppName);                
                btnUpdatPackageProduct.Enabled = true;
                btnAddProduct.Enabled = false;
                cmbProducts.Enabled = false;
                btnDeletePkgProduct.Enabled = false;
                btnClearproductForm.Enabled = false;
                btnPkgDelete.Enabled = false;

            }
        }
        //update products of a specific package
        private void btnUpdatPackageProduct_Click(object sender, EventArgs e)
        {
            string prodName = cmbProducts.Text;
            string suppName = lstSuppliers.Text;
            int getPkgId = 0;
            if (lstSuppliers.Text == "")
            {
                 MessageBox.Show("Please choose a Supplier");
            }
            else {
                if (pkgDataGrid.SelectedCells.Count > 0)
                {
                    int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];
                    getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
                    Package_AddProduct_DB pkgUpdateProductObj = new Package_AddProduct_DB();
                    if (pkgUpdateProductObj.Update_Package_Product(suppName, prodName, getPkgId, pkgUpdateSuppId))
                    {
                        MessageBox.Show("Packages products updated Successfully");
                        btnAddProduct.Enabled = true;
                        cmbProducts.Enabled = true;
                        btnClearproductForm.Enabled = true;
                        btnUpdatPackageProduct.Enabled = false;
                        btnDeletePkgProduct.Enabled = true;
                        btnPkgDelete.Enabled = true;
                        
                    }
                    Load_PkgProducts();
                    cmbProducts.SelectedIndex = -1;
                }
                
            }

        }
        //Delete Package
        private void btnPkgDelete_Click(object sender, EventArgs e)
        {
            int getPkgId = 0;
            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];
                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
                Package_AddProduct_DB pkgDeleteObj = new Package_AddProduct_DB();
                string message = "Do you want to delete this Record?";
                string caption = "Delete Info";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    pkgDeleteObj.Pkg_Products_Delete(getPkgId);

                    if (pkgDeleteObj.DeletePackage(getPkgId))
                    {
                        MessageBox.Show("Package Deleted");
                    }
                    PackageDB ObjDeletePkg = new PackageDB();
                    if (ObjDeletePkg.FillDataGrid())
                    {

                        pkgDataGrid.DataSource = ObjDeletePkg.dt;
                    }
                    Load_PkgProducts();
                    cmbProducts.SelectedIndex = -1;
                }
            }
        }
        //Clear form 
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            Clear_Form();
            btnAddPackage.Enabled = true;
           btnPkgDelete.Enabled = true;
            btnSaveUpdate.Enabled = false;


        }
        //On date time picker close up custom format date time picker
        private void dtPkgStartDate_CloseUp(object sender, EventArgs e)
        {
            dtPkgStartDate.Format = DateTimePickerFormat.Long;
            dtPkgEndDate.Format = DateTimePickerFormat.Long;
        }
        //on text change custom format the date time picker
        private void txtPkgName_TextChanged(object sender, EventArgs e)
        {
            dtPkgStartDate.Format = DateTimePickerFormat.Long;
            dtPkgEndDate.Format = DateTimePickerFormat.Long;
        }
        //Delete product
        private void btnDeletePkgProduct_Click(object sender, EventArgs e)
        {
            string pkgProdName = "";
            string pkgSuppName = "";
            int getPkgId = 0;
            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];
                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);
            }
            if (pkgProductGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgProductGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = pkgProductGrid.Rows[selectedrowindex];
                pkgProdName = Convert.ToString(selectedRow.Cells[0].Value);
                pkgSuppName = Convert.ToString(selectedRow.Cells[1].Value);
                cmbProducts.SelectedItem = pkgProdName;
                lstSuppliers.SelectedItem = pkgSuppName;
                Package_AddProduct_DB deletePackagesPordObj = new Package_AddProduct_DB();
                string message = "Do you want to delete this Record?";
                string caption = "Delete Info";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (deletePackagesPordObj.Delete_Package_Product(pkgSuppName, pkgProdName, getPkgId))
                    {
                        MessageBox.Show("Package product deleted successfully");
                    }
                }
            }
            Load_PkgProducts();
            ClearProductForm();
        }
        //Clear the product form
        private void btnClearproductForm_Click(object sender, EventArgs e)
        {
            ClearProductForm();
            Refresh_Products_Onupdate();
        }
        void ClearProductForm()
        {
            cmbProducts.SelectedIndex = -1;       
        }
        //Refresh product grid view on update
        private void Refresh_Products_Onupdate()
        {
            int getPkgId;
            if (pkgDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = pkgDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = pkgDataGrid.Rows[selectedrowindex];

                getPkgId = Convert.ToInt32(selectedRow.Cells["PackageId"].Value);                
                Package_AddProduct_DB getSupidobj = new Package_AddProduct_DB();
                getSupidobj.GetSupplierId(getPkgId);
                pkgProductGrid.DataSource = getSupidobj.getPackageProduct();

            }
        }
    }
}