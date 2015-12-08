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
        private bool isForUpdate;
        private int supplierID;
        private DataAccess dataAccess;

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
            dataAccess = new DataAccess();
        }

        private void transferDataRowDetailToForm(DataRow DataRowDetail)
        {
            CompanyNameTxt.Text = DataRowDetail["CompanyName"].ToString();
            PhoneTxt.Text = DataRowDetail["Phone"].ToString();
            AddressTxt.Text = DataRowDetail["Address"].ToString();
            supplierID = int.Parse(DataRowDetail["SupplierID"].ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CompanyNameTxt.Text == "" || PhoneTxt.Text == "" || AddressTxt.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error");
                return;
            }

            if (PhoneTxt.Text.Any((c) => !char.IsDigit(c)))
            {
                MessageBox.Show("Phone number must consist only numbers.");
                return;
            }

            string companyName = CompanyNameTxt.Text,
                    phone = PhoneTxt.Text,
                    address = AddressTxt.Text;


            if (isForUpdate)
                dataAccess.UpdateSupplier(companyName, phone, address, supplierID);
            else
            {
                bool companyNameExist = dataAccess.CompanyNameExists(companyName);
                if (companyNameExist)
                {
                    MessageBox.Show("Company name exists. Please select another name.");
                    return;
                }
                dataAccess.InsertSupplier(companyName, phone, address);
            }

            MessageBox.Show("Success.");
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
