using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie
{
    public partial class MainForm : Form
    {
        private DataModule DM;                   		// the reference to the form that holds the data components
        private BrandForm frmBrand;                 // the reference to the Client form

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrandMng_Click(object sender, EventArgs e)
        {
            if (frmBrand == null)
            {
                frmBrand = new BrandForm(DM, this);
            }
            frmBrand.ShowDialog();
        }
    }
}
