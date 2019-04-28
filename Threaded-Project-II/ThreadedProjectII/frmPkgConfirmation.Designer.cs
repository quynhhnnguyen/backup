namespace ThreadedProjectII
{
    partial class frmPkgConfirmation
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelPkg = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstPckProducts = new System.Windows.Forms.ListBox();
            this.txtPkgComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackPkg = new System.Windows.Forms.Button();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.txtPkgStartDate = new System.Windows.Forms.TextBox();
            this.txtPkgEndDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(390, 42);
            this.label10.TabIndex = 49;
            this.label10.Text = "Create New Package";
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(402, 459);
            this.btnCancelPkg.Name = "btnCancelPkg";
            this.btnCancelPkg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPkg.TabIndex = 48;
            this.btnCancelPkg.Text = "&Cancel";
            this.btnCancelPkg.UseVisualStyleBackColor = true;
            this.btnCancelPkg.Click += new System.EventHandler(this.btnCancelPkg_Click);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPkg.Location = new System.Drawing.Point(221, 459);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(75, 23);
            this.btnAddPkg.TabIndex = 47;
            this.btnAddPkg.Text = "&Add";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Products Selected:";
            // 
            // lstPckProducts
            // 
            this.lstPckProducts.Enabled = false;
            this.lstPckProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPckProducts.FormattingEnabled = true;
            this.lstPckProducts.ItemHeight = 16;
            this.lstPckProducts.Items.AddRange(new object[] {
            "Product A",
            "Product B"});
            this.lstPckProducts.Location = new System.Drawing.Point(348, 167);
            this.lstPckProducts.Name = "lstPckProducts";
            this.lstPckProducts.Size = new System.Drawing.Size(129, 260);
            this.lstPckProducts.TabIndex = 44;
            // 
            // txtPkgComision
            // 
            this.txtPkgComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgComision.Location = new System.Drawing.Point(108, 405);
            this.txtPkgComision.Name = "txtPkgComision";
            this.txtPkgComision.ReadOnly = true;
            this.txtPkgComision.Size = new System.Drawing.Size(200, 22);
            this.txtPkgComision.TabIndex = 40;
            this.txtPkgComision.Text = "$500.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Comision:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Agency:";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgBasePrice.Location = new System.Drawing.Point(109, 321);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.ReadOnly = true;
            this.txtPkgBasePrice.Size = new System.Drawing.Size(200, 22);
            this.txtPkgBasePrice.TabIndex = 34;
            this.txtPkgBasePrice.Text = "$1,500.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Base Price:";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(108, 248);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.ReadOnly = true;
            this.txtPkgDesc.Size = new System.Drawing.Size(201, 54);
            this.txtPkgDesc.TabIndex = 32;
            this.txtPkgDesc.Text = "Demo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Start Date:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(109, 128);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.ReadOnly = true;
            this.txtPkgName.Size = new System.Drawing.Size(200, 22);
            this.txtPkgName.TabIndex = 28;
            this.txtPkgName.Text = "Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(454, 54);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Please check the information below and press \"Add\" to finish the process. Otherwi" +
    "se, press \"Back\" to change the information. Press \"Cancel\" to delete all.";
            // 
            // btnBackPkg
            // 
            this.btnBackPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPkg.Location = new System.Drawing.Point(311, 459);
            this.btnBackPkg.Name = "btnBackPkg";
            this.btnBackPkg.Size = new System.Drawing.Size(75, 23);
            this.btnBackPkg.TabIndex = 50;
            this.btnBackPkg.Text = "&Back";
            this.btnBackPkg.UseVisualStyleBackColor = true;
            this.btnBackPkg.Click += new System.EventHandler(this.btnBackPkg_Click);
            // 
            // txtAgency
            // 
            this.txtAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgency.Location = new System.Drawing.Point(108, 367);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.ReadOnly = true;
            this.txtAgency.Size = new System.Drawing.Size(200, 22);
            this.txtAgency.TabIndex = 51;
            this.txtAgency.Text = "Calgary";
            // 
            // txtPkgStartDate
            // 
            this.txtPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgStartDate.Location = new System.Drawing.Point(108, 168);
            this.txtPkgStartDate.Name = "txtPkgStartDate";
            this.txtPkgStartDate.ReadOnly = true;
            this.txtPkgStartDate.Size = new System.Drawing.Size(200, 22);
            this.txtPkgStartDate.TabIndex = 52;
            this.txtPkgStartDate.Text = "December 1, 2018";
            // 
            // txtPkgEndDate
            // 
            this.txtPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgEndDate.Location = new System.Drawing.Point(108, 207);
            this.txtPkgEndDate.Name = "txtPkgEndDate";
            this.txtPkgEndDate.ReadOnly = true;
            this.txtPkgEndDate.Size = new System.Drawing.Size(200, 22);
            this.txtPkgEndDate.TabIndex = 53;
            this.txtPkgEndDate.Text = "January 31, 2019";
            // 
            // frmPkgConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 502);
            this.Controls.Add(this.txtPkgEndDate);
            this.Controls.Add(this.txtPkgStartDate);
            this.Controls.Add(this.txtAgency);
            this.Controls.Add(this.btnBackPkg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelPkg);
            this.Controls.Add(this.btnAddPkg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstPckProducts);
            this.Controls.Add(this.txtPkgComision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPkgConfirmation";
            this.Text = "Comfirm the information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelPkg;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstPckProducts;
        private System.Windows.Forms.TextBox txtPkgComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackPkg;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.TextBox txtPkgStartDate;
        private System.Windows.Forms.TextBox txtPkgEndDate;
    }
}