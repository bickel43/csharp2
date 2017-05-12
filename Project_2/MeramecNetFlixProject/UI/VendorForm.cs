using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class VendorForm: Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitVendorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            vendorDataGridView.DataSource = VendorDB.GetAllVendors();

            vendorIDTextBox.Text = Convert.ToString(vendorDataGridView.RowCount + 1);
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            VendorClass myVendorObj = new VendorClass();

            myVendorObj.VendorID = Convert.ToInt32(vendorIDTextBox.Text);
            myVendorObj.VendorName = vendorNameTextBox.Text;
            myVendorObj.VendorPhone1 = vendorPhone1TextBox.Text;
            myVendorObj.VendorPhone2 = vendorPhone2TextBox.Text;

            bool recordAdded = VendorDB.AddVendor(myVendorObj);

            //if record is true, or false, do some stuff
            if (recordAdded == true)
            {
                //MessageBox.Show("Record added");
                rowsAffectedStatusStripLabel.Text = "1 row added";
            }
            else
            {
                MessageBox.Show("Record not added");
            }
            cleanupUI();
        }

        public void cleanupUI()
        {
            vendorIDTextBox.Clear();
            vendorNameTextBox.Clear();
            vendorPhone1TextBox.Clear();
            vendorPhone2TextBox.Clear();

            vendorDataGridView.DataSource = VendorDB.GetAllVendors();
            vendorIDTextBox.Text = Convert.ToString(vendorDataGridView.RowCount + 1);
        }

        private void updateVendorButton_Click(object sender, EventArgs e)
        {
            try
            {
                VendorClass myVendorObj = new VendorClass();

                myVendorObj.VendorID = Convert.ToInt16(vendorIDTextBox.Text);
                myVendorObj.VendorName = vendorNameTextBox.Text;
                myVendorObj.VendorPhone1 = vendorPhone1TextBox.Text;
                myVendorObj.VendorPhone2 = vendorPhone2TextBox.Text;


                bool recordUpdated = VendorDB.UpdateVendor(myVendorObj);

                //if record is true, or false, do some stuff
                if (recordUpdated == true)
                {
                    rowsAffectedStatusStripLabel.Text = "1 row updated";
                    //MessageBox.Show("Record Updated");          
                }
                else
                {
                    MessageBox.Show("Record Not Updated");
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Error when updating user. \nMake sure a record is selected.", "User Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void deleteVendorButton_Click(object sender, EventArgs e)
        {
            try
            {
                VendorClass myVendorObj = new VendorClass();

                myVendorObj.VendorID = Convert.ToInt16(vendorIDTextBox.Text);
                myVendorObj.VendorName = vendorNameTextBox.Text;
                myVendorObj.VendorPhone1 = vendorPhone1TextBox.Text;
                myVendorObj.VendorPhone2 = vendorPhone2TextBox.Text;

                bool recordDeleted = VendorDB.DeleteVendor(myVendorObj);

                //if record is true, or false, do some stuff
                if (recordDeleted == true)
                {
                    rowsAffectedStatusStripLabel.Text = "1 row deleted";
                    //MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record Not Deleted");
                }
                cleanupUI();
            }
            catch (Exception)
            {
                MessageBox.Show("Error when deleting user. \nMake sure a record is selected.", "User Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void displayUserSelection()
        {
            try
            {
                if (vendorDataGridView.SelectedRows.Count > 0)
                {
                    string vendorID = vendorDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                    string vendorName = vendorDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                    string vendorPhone1 = vendorDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                    string vendorPhone2 = vendorDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;

                    vendorIDTextBox.Text = vendorID.ToString();
                    vendorNameTextBox.Text = vendorName.ToString();
                    vendorPhone1TextBox.Text = vendorPhone1.ToString();
                    vendorPhone2TextBox.Text = vendorPhone2.ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void vendorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayUserSelection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cleanupUI();
        }

        private void vendorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorReport vreport = new VendorReport();
            vreport.ShowDialog();
        }
    }
}
