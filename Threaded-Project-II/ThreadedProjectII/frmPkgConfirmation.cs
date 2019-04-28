using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectII
{
    /* Load data and build Product Confirmation Page.
     * Author: Jonathan Pirca
     * Date: Dec - 17 - 2018     
     */
    public partial class frmPkgConfirmation : Form
    {
        public frmPkgConfirmation()
        {
            InitializeComponent();
        }

        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The package \"Pckage Name\" was created sussccefully","Adding Package");
            this.Close();

        }

        private void btnBackPkg_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPackage form1 = new frmPackage();
            form1.Activate();
            form1.Show();
        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
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
    }
}
