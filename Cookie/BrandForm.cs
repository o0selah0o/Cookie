using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie
{
    public partial class BrandForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public BrandForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }
        public void BindControls()
        {
            dgdBrand.DataSource = DM.DSCookie;
            GetData("select * from Brand");

            currencyManager = (CurrencyManager)this.BindingContext[DM.DSCookie, "Brand"];
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dgdBrand.DataSource = DM.dtBrand;
                // Resize the DataGridView columns to fit the newly loaded content.
                dgdBrand.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
