namespace ThreadedProjectII
{
    partial class frmProductsComfirmation
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
            this.btnCancelProd = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.txtConfProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(327, 39);
            this.label10.TabIndex = 47;
            this.label10.Text = "Confirm Your Edits";
            // 
            // btnCancelProd
            // 
            this.btnCancelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProd.Location = new System.Drawing.Point(297, 412);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProd.TabIndex = 46;
            this.btnCancelProd.Text = "&Cancel";
            this.btnCancelProd.UseVisualStyleBackColor = true;
            this.btnCancelProd.Click += new System.EventHandler(this.btnCancelProd_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProd.Location = new System.Drawing.Point(109, 412);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProd.TabIndex = 45;
            this.btnUpdateProd.Text = "&Update";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            this.btnUpdateProd.Click += new System.EventHandler(this.btnUpdateProd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Suppliers Selected:";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.Enabled = false;
            this.lstSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 16;
            this.lstSuppliers.Location = new System.Drawing.Point(154, 178);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(318, 196);
            this.lstSuppliers.TabIndex = 43;
            // 
            // txtConfProdName
            // 
            this.txtConfProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfProdName.Location = new System.Drawing.Point(107, 126);
            this.txtConfProdName.Name = "txtConfProdName";
            this.txtConfProdName.Size = new System.Drawing.Size(363, 22);
            this.txtConfProdName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(487, 44);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Please check all the information below and click \"Update\" ";
            // 
            // btnBackProd
            // 
            this.btnBackProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackProd.Location = new System.Drawing.Point(205, 412);
            this.btnBackProd.Name = "btnBackProd";
            this.btnBackProd.Size = new System.Drawing.Size(75, 23);
            this.btnBackProd.TabIndex = 48;
            this.btnBackProd.Text = "&Back";
            this.btnBackProd.UseVisualStyleBackColor = true;
            this.btnBackProd.Click += new System.EventHandler(this.btnBackProd_Click);
            // 
            // frmProductsComfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.btnBackProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelProd);
            this.Controls.Add(this.btnUpdateProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstSuppliers);
            this.Controls.Add(this.txtConfProdName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmProductsComfirmation";
            this.Text = "ProductsComfirmation";
            this.Load += new System.EventHandler(this.frmProductsComfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelProd;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.TextBox txtConfProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackProd;
    }
}