using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class VendorReport : Form
    {
        public VendorReport()
        {
            InitializeComponent();
        }

        private void VendorReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamgDataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.teamgDataSet.Vendor);

            this.reportViewer1.RefreshReport();
        }
    }
}
