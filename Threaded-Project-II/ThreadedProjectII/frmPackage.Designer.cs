namespace ThreadedProjectII
{
    partial class frmPackage
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
            this.lblManagePkges = new System.Windows.Forms.Label();
            this.grpAddPackages = new System.Windows.Forms.GroupBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnPkgDelete = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pkgDataGrid = new System.Windows.Forms.DataGridView();
            this.dtPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.txtPkgComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPkgDetails = new System.Windows.Forms.GroupBox();
            this.btnClearproductForm = new System.Windows.Forms.Button();
            this.btnDeletePkgProduct = new System.Windows.Forms.Button();
            this.btnUpdatPackageProduct = new System.Windows.Forms.Button();
            this.btnUpdatSpecificPkg = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pkgProductGrid = new System.Windows.Forms.DataGridView();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblPackagesMangaeProd = new System.Windows.Forms.Label();
            this.grpAddPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgDataGrid)).BeginInit();
            this.grpPkgDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagePkges
            // 
            this.lblManagePkges.AutoSize = true;
            this.lblManagePkges.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePkges.Location = new System.Drawing.Point(323, 7);
            this.lblManagePkges.Name = "lblManagePkges";
            this.lblManagePkges.Size = new System.Drawing.Size(253, 31);
            this.lblManagePkges.TabIndex = 25;
            this.lblManagePkges.Text = "Manage Packages";
            // 
            // grpAddPackages
            // 
            this.grpAddPackages.Controls.Add(this.btnClearForm);
            this.grpAddPackages.Controls.Add(this.btnPkgDelete);
            this.grpAddPackages.Controls.Add(this.btnSaveUpdate);
            this.grpAddPackages.Controls.Add(this.btnUpdate);
            this.grpAddPackages.Controls.Add(this.pkgDataGrid);
            this.grpAddPackages.Controls.Add(this.dtPkgEndDate);
            this.grpAddPackages.Controls.Add(this.dtPkgStartDate);
            this.grpAddPackages.Controls.Add(this.btnAddPackage);
            this.grpAddPackages.Controls.Add(this.txtPkgComision);
            this.grpAddPackages.Controls.Add(this.label7);
            this.grpAddPackages.Controls.Add(this.txtPkgBasePrice);
            this.grpAddPackages.Controls.Add(this.label5);
            this.grpAddPackages.Controls.Add(this.txtPkgDesc);
            this.grpAddPackages.Controls.Add(this.label4);
            this.grpAddPackages.Controls.Add(this.label3);
            this.grpAddPackages.Controls.Add(this.label2);
            this.grpAddPackages.Controls.Add(this.txtPkgName);
            this.grpAddPackages.Controls.Add(this.label1);
            this.grpAddPackages.Controls.Add(this.lblTitle);
            this.grpAddPackages.Location = new System.Drawing.Point(26, 41);
            this.grpAddPackages.Name = "grpAddPackages";
            this.grpAddPackages.Size = new System.Drawing.Size(888, 298);
            this.grpAddPackages.TabIndex = 26;
            this.grpAddPackages.TabStop = false;
            this.grpAddPackages.Text = "Add Packages";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(99, 253);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(201, 32);
            this.btnClearForm.TabIndex = 49;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnPkgDelete
            // 
            this.btnPkgDelete.Location = new System.Drawing.Point(200, 219);
            this.btnPkgDelete.Name = "btnPkgDelete";
            this.btnPkgDelete.Size = new System.Drawing.Size(100, 28);
            this.btnPkgDelete.TabIndex = 48;
            this.btnPkgDelete.Text = "Delete Package";
            this.btnPkgDelete.UseVisualStyleBackColor = true;
            this.btnPkgDelete.Click += new System.EventHandler(this.btnPkgDelete_Click);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Enabled = false;
            this.btnSaveUpdate.Location = new System.Drawing.Point(599, 254);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(261, 31);
            this.btnSaveUpdate.TabIndex = 47;
            this.btnSaveUpdate.Text = "Save Upadate to Package";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.pkgSaveUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(320, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(273, 31);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update Package";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pkgDataGrid
            // 
            this.pkgDataGrid.AllowUserToAddRows = false;
            this.pkgDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkgDataGrid.Location = new System.Drawing.Point(320, 21);
            this.pkgDataGrid.Name = "pkgDataGrid";
            this.pkgDataGrid.ReadOnly = true;
            this.pkgDataGrid.Size = new System.Drawing.Size(540, 226);
            this.pkgDataGrid.TabIndex = 45;
            this.pkgDataGrid.Click += new System.EventHandler(this.pkgDataGrid_Click);
            // 
            // dtPkgEndDate
            // 
            this.dtPkgEndDate.Location = new System.Drawing.Point(100, 75);
            this.dtPkgEndDate.Name = "dtPkgEndDate";
            this.dtPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtPkgEndDate.TabIndex = 44;
            // 
            // dtPkgStartDate
            // 
            this.dtPkgStartDate.Location = new System.Drawing.Point(100, 49);
            this.dtPkgStartDate.Name = "dtPkgStartDate";
            this.dtPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtPkgStartDate.TabIndex = 43;
            this.dtPkgStartDate.CloseUp += new System.EventHandler(this.dtPkgStartDate_CloseUp);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(99, 219);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(95, 28);
            this.btnAddPackage.TabIndex = 42;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click_1);
            // 
            // txtPkgComision
            // 
            this.txtPkgComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgComision.Location = new System.Drawing.Point(99, 191);
            this.txtPkgComision.Name = "txtPkgComision";
            this.txtPkgComision.Size = new System.Drawing.Size(200, 22);
            this.txtPkgComision.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Comision:";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgBasePrice.Location = new System.Drawing.Point(100, 163);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(200, 22);
            this.txtPkgBasePrice.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Base Price:";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(99, 103);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(201, 54);
            this.txtPkgDesc.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Start Date:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(100, 21);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(200, 22);
            this.txtPkgName.TabIndex = 31;
            this.txtPkgName.TextChanged += new System.EventHandler(this.txtPkgName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(159, -49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 16);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Please insert all the information require to create a \"Package\":";
            // 
            // grpPkgDetails
            // 
            this.grpPkgDetails.Controls.Add(this.btnClearproductForm);
            this.grpPkgDetails.Controls.Add(this.btnDeletePkgProduct);
            this.grpPkgDetails.Controls.Add(this.btnUpdatPackageProduct);
            this.grpPkgDetails.Controls.Add(this.btnUpdatSpecificPkg);
            this.grpPkgDetails.Controls.Add(this.btnAddProduct);
            this.grpPkgDetails.Controls.Add(this.pkgProductGrid);
            this.grpPkgDetails.Controls.Add(this.lblSuppliers);
            this.grpPkgDetails.Controls.Add(this.lstSuppliers);
            this.grpPkgDetails.Controls.Add(this.lblProducts);
            this.grpPkgDetails.Controls.Add(this.cmbProducts);
            this.grpPkgDetails.Location = new System.Drawing.Point(26, 378);
            this.grpPkgDetails.Name = "grpPkgDetails";
            this.grpPkgDetails.Size = new System.Drawing.Size(888, 252);
            this.grpPkgDetails.TabIndex = 27;
            this.grpPkgDetails.TabStop = false;
            this.grpPkgDetails.Text = "Package Details";
            // 
            // btnClearproductForm
            // 
            this.btnClearproductForm.Location = new System.Drawing.Point(83, 210);
            this.btnClearproductForm.Name = "btnClearproductForm";
            this.btnClearproductForm.Size = new System.Drawing.Size(199, 32);
            this.btnClearproductForm.TabIndex = 50;
            this.btnClearproductForm.Text = "Clear Form";
            this.btnClearproductForm.UseVisualStyleBackColor = true;
            this.btnClearproductForm.Click += new System.EventHandler(this.btnClearproductForm_Click);
            // 
            // btnDeletePkgProduct
            // 
            this.btnDeletePkgProduct.Location = new System.Drawing.Point(184, 179);
            this.btnDeletePkgProduct.Name = "btnDeletePkgProduct";
            this.btnDeletePkgProduct.Size = new System.Drawing.Size(98, 27);
            this.btnDeletePkgProduct.TabIndex = 49;
            this.btnDeletePkgProduct.Text = "Delete Product";
            this.btnDeletePkgProduct.UseVisualStyleBackColor = true;
            this.btnDeletePkgProduct.Click += new System.EventHandler(this.btnDeletePkgProduct_Click);
            // 
            // btnUpdatPackageProduct
            // 
            this.btnUpdatPackageProduct.Enabled = false;
            this.btnUpdatPackageProduct.Location = new System.Drawing.Point(524, 179);
            this.btnUpdatPackageProduct.Name = "btnUpdatPackageProduct";
            this.btnUpdatPackageProduct.Size = new System.Drawing.Size(215, 31);
            this.btnUpdatPackageProduct.TabIndex = 48;
            this.btnUpdatPackageProduct.Text = "Save Update to Package Product";
            this.btnUpdatPackageProduct.UseVisualStyleBackColor = true;
            this.btnUpdatPackageProduct.Click += new System.EventHandler(this.btnUpdatPackageProduct_Click);
            // 
            // btnUpdatSpecificPkg
            // 
            this.btnUpdatSpecificPkg.Location = new System.Drawing.Point(303, 180);
            this.btnUpdatSpecificPkg.Name = "btnUpdatSpecificPkg";
            this.btnUpdatSpecificPkg.Size = new System.Drawing.Size(215, 31);
            this.btnUpdatSpecificPkg.TabIndex = 47;
            this.btnUpdatSpecificPkg.Text = "Update Package Product";
            this.btnUpdatSpecificPkg.UseVisualStyleBackColor = true;
            this.btnUpdatSpecificPkg.Click += new System.EventHandler(this.btnUpdatSpecificPkg_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(84, 180);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(98, 27);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pkgProductGrid
            // 
            this.pkgProductGrid.AllowUserToAddRows = false;
            this.pkgProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkgProductGrid.Location = new System.Drawing.Point(303, 19);
            this.pkgProductGrid.Name = "pkgProductGrid";
            this.pkgProductGrid.ReadOnly = true;
            this.pkgProductGrid.Size = new System.Drawing.Size(436, 150);
            this.pkgProductGrid.TabIndex = 4;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(5, 41);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(50, 13);
            this.lblSuppliers.TabIndex = 3;
            this.lblSuppliers.Text = "Suppliers";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(84, 41);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(199, 134);
            this.lstSuppliers.TabIndex = 2;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(6, 22);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(84, 14);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(199, 21);
            this.cmbProducts.TabIndex = 0;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // lblPackagesMangaeProd
            // 
            this.lblPackagesMangaeProd.AutoSize = true;
            this.lblPackagesMangaeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackagesMangaeProd.Location = new System.Drawing.Point(323, 342);
            this.lblPackagesMangaeProd.Name = "lblPackagesMangaeProd";
            this.lblPackagesMangaeProd.Size = new System.Drawing.Size(377, 31);
            this.lblPackagesMangaeProd.TabIndex = 28;
            this.lblPackagesMangaeProd.Text = "Manage Packages Products";
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 640);
            this.Controls.Add(this.lblPackagesMangaeProd);
            this.Controls.Add(this.grpPkgDetails);
            this.Controls.Add(this.grpAddPackages);
            this.Controls.Add(this.lblManagePkges);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPackage";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.grpAddPackages.ResumeLayout(false);
            this.grpAddPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgDataGrid)).EndInit();
            this.grpPkgDetails.ResumeLayout(false);
            this.grpPkgDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgProductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblManagePkges;
        private System.Windows.Forms.GroupBox grpAddPackages;
        private System.Windows.Forms.DateTimePicker dtPkgEndDate;
        private System.Windows.Forms.DateTimePicker dtPkgStartDate;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.TextBox txtPkgComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView pkgDataGrid;
        private System.Windows.Forms.GroupBox grpPkgDetails;
        private System.Windows.Forms.DataGridView pkgProductGrid;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnUpdatSpecificPkg;
        private System.Windows.Forms.Button btnUpdatPackageProduct;
        private System.Windows.Forms.Button btnPkgDelete;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnDeletePkgProduct;
        private System.Windows.Forms.Button btnClearproductForm;
        private System.Windows.Forms.Label lblPackagesMangaeProd;
    }
}