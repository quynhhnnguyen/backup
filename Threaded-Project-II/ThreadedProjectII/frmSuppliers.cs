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
    /* Load data and build Adding Supplier Page.
     * Author: Jonathan Pirca
     * Helper: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018     
     */
    public partial class frmSuppliers : Form
    {
        // used in case of editing form
        public Supplier editedSupplier = null;
        
        // form construction - Jonathan
        public frmSuppliers()
        {
            InitializeComponent();
        }

        // Next Action Handling - Quynh Nguyen (Queenie)
        private void btnNextSup_Click(object sender, EventArgs e)
        {
            string message = "";
            string messageBoxTitle = "";


            if (validaterClass.isProvided(txtSupplierName, "The field \"Supplier Name\" must be provided"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to create/update the supplier with Name - \"" + txtSupplierName.Text + "\"?",
                "Create/ Update Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) // User wants to insert/ update Supplier
                {
                    SupplierDB ado = new SupplierDB();

                    try
                    {
                        if (this.editedSupplier == null || editedSupplier.SupplierId == -1) // insert supplier
                        {
                            editedSupplier = new Supplier(-1, txtSupplierName.Text);
                            messageBoxTitle = "Adding Supplier";
                            if (ado.InsertSuppliers(editedSupplier))
                                message = "The supplier \"" + txtSupplierName.Text + "\" was created sussccefully";
                            else
                                message = "The supplier \"" + txtSupplierName.Text + "\" was not created sussccefully";
                        }
                        else //update supplier
                        {
                            editedSupplier.SupName = txtSupplierName.Text; // set new supplier name supplier object
                            messageBoxTitle = "Updating Supplier";
                            if (ado.UpdateSupplier(editedSupplier))
                                message = "The supplier \"" + txtSupplierName.Text + "\" was updated sussccefully";
                            else
                                message = "The supplier \"" + txtSupplierName.Text + "\" was not updated sussccefully";

                        }

                        if (!String.IsNullOrEmpty(message))
                            MessageBox.Show(message, messageBoxTitle);
                    }
                    catch (Exception ex)
                    {
                        message = ex.Message;
                        messageBoxTitle = "Update Supplier Error";

                    }

                    this.Close();
                }
            }
           


        }

        // Cancel button clicked - Jonathan Pirca
        private void btnCancelSup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Adding \"Supplier\"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        // Edit Supplier
        public void setEditedSupplier(Supplier supplier)
        {
            this.editedSupplier = supplier;
        }

        // Supplier Form loaded - Quynh Nguyen (Queenie)
        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            if(editedSupplier != null)
            {
                txtSupplierName.Text = editedSupplier.SupName;
            }
        }
    }
}
