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
        private decimal customerID;

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
        }

        private void transferDataRowDetailToForm(DataRow DataRowDetail)
        {
            lastNameTxt.Text = DataRowDetail["LastName"].ToString();
            firstNameTxt.Text = DataRowDetail["FirstName"].ToString();
            addressTxt.Text = DataRowDetail["Address"].ToString();
            phoneTxt.Text = DataRowDetail["Phone"].ToString();
            dateOfBirthDAT.Value = Convert.ToDateTime(DataRowDetail["DateOfBirth"].ToString());
            customerID = decimal.Parse(DataRowDetail["CustomerID"].ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isInputOK())
            {
                if (isForUpdate == false)
                {
                    DataAccess da = new DataAccess();
                    if (da.IsInsertCustomers(lastNameTxt.Text, firstNameTxt.Text, addressTxt.Text, phoneTxt.Text, dateOfBirthDAT.Value))
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
                    if (da.IsUpdateCustomers(lastNameTxt.Text, firstNameTxt.Text, addressTxt.Text, phoneTxt.Text, dateOfBirthDAT.Value, customerID))
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
            else
            {
                MessageBox.Show("You have to check your information!");
            }
        }

        private bool isInputOK()
        {
            if (lastNameTxt.Text != "" && firstNameTxt.Text != "" && phoneTxt.Text != "" && addressTxt.Text != "")
                return true;
            return false;

        }

    }
}
