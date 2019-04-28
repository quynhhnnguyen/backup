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
    /* Load data and build Travel Experts Main Page.
     * Author: Jonathan Pirca
     * Date: Dec - 17 - 2018     
     */
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            //form1.MdiParent = this;

            DialogResult result = form1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MainMenuStrip.Enabled = true;
            }
            else
            {
                this.Close();
            }

            //form1.Show();
            //form1.Activate();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.IsMdiContainer = true;
            frmPackage form1 = new frmPackage();
            form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            //menuMain.Enabled = false;
            form1.Show();
            form1.Activate();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddProducts form1 = new frmAddProducts();
            form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            //menuMain.Enabled = false;
            form1.Show();
            form1.Activate();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSuppliers form1 = new frmSuppliers();
            form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            //menuMain.Enabled = false;
            form1.Show();
            form1.Activate();
        }

        private void mnuAddSupplier_Click(object sender, EventArgs e)
        {
            frmSuppliers form1 = new frmSuppliers();
            form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            //menuMain.Enabled = false;
            form1.Show();
            form1.Activate();
        }

        private void mnuEditSupplier_Click(object sender, EventArgs e)
        {
            frmEditSuppliers form1 = new frmEditSuppliers();
            form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            //menuMain.Enabled = false;
            form1.Show();
            form1.Activate();
        }

        private void editProducts_Click(object sender, EventArgs e)
        {
            frmEditProducts form1 = new frmEditProducts();
            form1.MdiParent = this;
            //Form2.Enabled = true;
            //Form2.BringToFront();
            //menuMain.Enabled = false;
            form1.Show();
            form1.Activate();
        }


    }
}
