namespace ThreadedProjectII
{
    partial class frmEditProducts
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
            this.btnCancelPkg = new System.Windows.Forms.Button();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSelectProduct = new System.Windows.Forms.ComboBox();
            this.lstAssocSupplier = new System.Windows.Forms.ListBox();
            this.lstAvailSuppliers = new System.Windows.Forms.ListBox();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.RemSupp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(416, 465);
            this.btnCancelPkg.Name = "btnCancelPkg";
            this.btnCancelPkg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPkg.TabIndex = 41;
            this.btnCancelPkg.Text = "&Cancel";
            this.btnCancelPkg.UseVisualStyleBackColor = true;
            this.btnCancelPkg.Click += new System.EventHandler(this.btnCancelPkg_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProducts.Location = new System.Drawing.Point(319, 465);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(75, 23);
            this.btnEditProducts.TabIndex = 40;
            this.btnEditProducts.Text = "&Edit";
            this.btnEditProducts.UseVisualStyleBackColor = true;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Available Suppliers";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "Suppliers Asociated with the Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 42);
            this.label10.TabIndex = 35;
            this.label10.Text = "Edit Products";
            // 
            // cmbSelectProduct
            // 
            this.cmbSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectProduct.FormattingEnabled = true;
            this.cmbSelectProduct.Location = new System.Drawing.Point(9, 28);
            this.cmbSelectProduct.Name = "cmbSelectProduct";
            this.cmbSelectProduct.Size = new System.Drawing.Size(236, 21);
            this.cmbSelectProduct.TabIndex = 42;
            this.cmbSelectProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSelectProduct_SelectedIndexChanged);
            // 
            // lstAssocSupplier
            // 
            this.lstAssocSupplier.FormattingEnabled = true;
            this.lstAssocSupplier.Location = new System.Drawing.Point(29, 121);
            this.lstAssocSupplier.Name = "lstAssocSupplier";
            this.lstAssocSupplier.Size = new System.Drawing.Size(139, 186);
            this.lstAssocSupplier.TabIndex = 43;
            // 
            // lstAvailSuppliers
            // 
            this.lstAvailSuppliers.FormattingEnabled = true;
            this.lstAvailSuppliers.Location = new System.Drawing.Point(299, 121);
            this.lstAvailSuppliers.Name = "lstAvailSuppliers";
            this.lstAvailSuppliers.Size = new System.Drawing.Size(147, 186);
            this.lstAvailSuppliers.TabIndex = 44;
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(194, 167);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupp.TabIndex = 45;
            this.btnAddSupp.Text = "Add";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // RemSupp
            // 
            this.RemSupp.Location = new System.Drawing.Point(194, 227);
            this.RemSupp.Name = "RemSupp";
            this.RemSupp.Size = new System.Drawing.Size(75, 23);
            this.RemSupp.TabIndex = 46;
            this.RemSupp.Text = "Remove";
            this.RemSupp.UseVisualStyleBackColor = true;
            this.RemSupp.Click += new System.EventHandler(this.RemSupp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAvailSuppliers);
            this.groupBox1.Controls.Add(this.lstAssocSupplier);
            this.groupBox1.Controls.Add(this.RemSupp);
            this.groupBox1.Controls.Add(this.cmbSelectProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddSupp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 333);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the Product and Press edit";
            // 
            // frmEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelPkg);
            this.Controls.Add(this.btnEditProducts);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProducts";
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.frmEditProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPkg;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSelectProduct;
        private System.Windows.Forms.ListBox lstAssocSupplier;
        private System.Windows.Forms.ListBox lstAvailSuppliers;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.Button RemSupp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}