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
    public partial class CustomerDetailsForm : Form
    {
        private bool isForUpdate;
        private int customerID;
        private DataAccess dataAccess;

        public static CustomerDetailsForm CreateInsertForm()
        {
            var form = new CustomerDetailsForm();
            form.isForUpdate = false;
            form.ShowDialog();

            return form;
        }

        public static CustomerDetailsForm CreateUpdateForm(DataRow selectedRow)
        {
            var form = new CustomerDetailsForm();
            form.isForUpdate = true;

            form.transferDataRowDetailToForm(selectedRow);

            form.ShowDialog();

            return form;
        }

        private CustomerDetailsForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void transferDataRowDetailToForm(DataRow DataRowDetail)
        {
            lastNameTxt.Text = DataRowDetail["LastName"].ToString();
            firstNameTxt.Text = DataRowDetail["FirstName"].ToString();
            addressTxt.Text = DataRowDetail["Address"].ToString();
            phoneTxt.Text = DataRowDetail["Phone"].ToString();
            dateOfBirthDAT.Value = Convert.ToDateTime(DataRowDetail["DateOfBirth"].ToString());
            customerID = int.Parse(DataRowDetail["CustomerID"].ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.HasBlankField())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string lastName = lastNameTxt.Text,
                firstName = firstNameTxt.Text,
                address = addressTxt.Text,
                phone = phoneTxt.Text;
            DateTime dateOfBirth = dateOfBirthDAT.Value;

            if (isForUpdate)
                dataAccess.UpdateCustomer(lastName, firstName, address, phone, dateOfBirth, customerID);
            else
                dataAccess.InsertCustomer(lastName, firstName, address, phone, dateOfBirth);

            MessageBox.Show("Success.");
            Close();
        }

        private bool HasBlankField()
        {
            return lastNameTxt.Text == ""
                || firstNameTxt.Text == ""
                || phoneTxt.Text == ""
                || addressTxt.Text == "";
        }

    }
}
