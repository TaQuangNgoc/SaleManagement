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
    public partial class SupplierDetailsForm : Form
    {
        private bool isForUpdate = true;
        private decimal supplierID;

        public static SupplierDetailsForm CreateInsertForm()
        {
            var form = new SupplierDetailsForm();
            form.isForUpdate = false;
            form.ShowDialog();

            return form;
        }

        public static SupplierDetailsForm CreateUpdateForm(DataRow selectedRow)
        {
            var form = new SupplierDetailsForm();
            form.isForUpdate = true;

            form.transferDataRowDetailToForm(selectedRow);

            form.ShowDialog();

            return form;
        }

        private SupplierDetailsForm()
        {
            InitializeComponent();
        }

        internal void displayForInsert()
        {
            isForUpdate = false;
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
            if (isForUpdate == false)
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
