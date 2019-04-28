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
    /* Load data and build Editing Supplier Page
     * Author: Jonathan Pirca
     * Helper: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     */
    public partial class frmEditSuppliers : Form
    {
        // initialize Edit Supplier Form - Quynh Nguyen
        public frmEditSuppliers()
        {
            try
            {
                InitializeComponent();
                SupplierDB supADO = new SupplierDB();
                List<Supplier> suppliers = supADO.GetSuppliers(); // get Suppliers from Database
                this.listSupplier.Items.Clear();
                this.listSupplier.DataSource = suppliers; // set Suppliers to list control
            }
            catch (Exception ex)
            {
                Utils.ErrorManager(ex, "", "frmEditSuppliers.frmEditSuppliers()");
            }
            
        }

        //next button handling - Quynh Nguyen
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                frmSuppliers form1 = new frmSuppliers();
                form1.setEditedSupplier((Supplier)this.listSupplier.SelectedItem);
                form1.Show();
                form1.Activate();
            }
            catch (Exception ex)
            {
                Utils.ErrorManager(ex, "", "frmEditSuppliers.btnNext_Click()");
            }

        }

        // cancel button handling - Jonathan
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Delete Supplier handling - Quynh Nguyen
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Supplier selectedSupplier = (Supplier)this.listSupplier.SelectedItem;
            if(selectedSupplier == null)
            {
                MessageBox.Show("Please select the supplier which you want to delete and try again.", "Not Select Supplier.");
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete the supplier with Name - \"" + selectedSupplier.SupName + "\"?",
                "Delete Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) // user confirmed to delete supplier
                {
                    SupplierDB ado = new SupplierDB();
                    try
                    {
                        if (ado.DeleteSupplier(selectedSupplier.SupplierId)) // delete successfully
                        {
                            MessageBox.Show("The supplier \"" + selectedSupplier.SupName + "\" was deleted sussccefully",
                                "Deleting Supplier");
                        }
                        else
                        {
                            MessageBox.Show("The supplier \"" + selectedSupplier.SupName + "\" was not deleted sussccefully",
                                "Deleting Supplier");
                        }
                    }
                    catch (Exception ex)
                    {
                        Utils.ErrorManager(ex, "", "frmEditSuppliers.btnDelete_Click()");
                    }

                }

                this.Close();
            }            
        }

        
    }
}
