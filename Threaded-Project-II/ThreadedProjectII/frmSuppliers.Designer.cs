namespace ThreadedProjectII
{
    partial class frmSuppliers
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
            this.btnCancelSup = new System.Windows.Forms.Button();
            this.btnNextSup = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(103, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 31);
            this.label10.TabIndex = 51;
            this.label10.Text = "Manage Supplier";
            // 
            // btnCancelSup
            // 
            this.btnCancelSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSup.Location = new System.Drawing.Point(331, 185);
            this.btnCancelSup.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancelSup.Name = "btnCancelSup";
            this.btnCancelSup.Size = new System.Drawing.Size(71, 26);
            this.btnCancelSup.TabIndex = 50;
            this.btnCancelSup.Text = "&Cancel";
            this.btnCancelSup.UseVisualStyleBackColor = true;
            this.btnCancelSup.Click += new System.EventHandler(this.btnCancelSup_Click);
            // 
            // btnNextSup
            // 
            this.btnNextSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSup.Location = new System.Drawing.Point(236, 185);
            this.btnNextSup.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNextSup.Name = "btnNextSup";
            this.btnNextSup.Size = new System.Drawing.Size(71, 26);
            this.btnNextSup.TabIndex = 49;
            this.btnNextSup.Text = "&Next";
            this.btnNextSup.UseVisualStyleBackColor = true;
            this.btnNextSup.Click += new System.EventHandler(this.btnNextSup_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(81, 44);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(312, 22);
            this.txtSupplierName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 87);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please fill all the required information";
            // 
            // frmSuppliers
            // 
            this.AcceptButton = this.btnNextSup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSup;
            this.ClientSize = new System.Drawing.Size(425, 222);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelSup);
            this.Controls.Add(this.btnNextSup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliers";
            this.Text = "Add New Supplier";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelSup;
        private System.Windows.Forms.Button btnNextSup;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}