using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class SuppliersDetail : Form
    {
        private bool IsUpdate = true; // if Form is Insert State, IsUpdate= false;
        private decimal supplierID;
        public SuppliersDetail()
        {
            InitializeComponent();
        }

        internal void displayForInsert()
        {
            IsUpdate = false;
            this.ShowDialog();
        }

        internal void displayForUpdate(DataRow DataRowDetail)
        {
            transferDataRowDetailToForm(DataRowDetail);
            this.ShowDialog();
        }

        private void transferDataRowDetailToForm(DataRow DataRowDetail)
        {
            CompanyNameTxt.Text = DataRowDetail["CompanyName"].ToString();
            PhoneTxt.Text = DataRowDetail["Phone"].ToString();
            AddressTxt.Text = DataRowDetail["Address"].ToString();
            supplierID = decimal.Parse(DataRowDetail["SupplierID"].ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsUpdate == false)
            {
                DataAccess da = new DataAccess();
                if (da.IsInsertSuppliers(CompanyNameTxt.Text, PhoneTxt.Text, AddressTxt.Text))
                {
                    MessageBox.Show(" Insert Succeed!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This action isn't done because there are 2 record have same name!");
                }
            }
            else
            {
                DataAccess da = new DataAccess();
                if (da.IsUpdateSuppliers(CompanyNameTxt.Text, PhoneTxt.Text, AddressTxt.Text, supplierID))
                {
                    MessageBox.Show("Update Succeed!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This action isn't done because there are 2 record have same name!");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
