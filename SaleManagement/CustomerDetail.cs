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
    public partial class CustomerDetail : Form
    {
        private bool IsForUpdate;
        private decimal customerID;

        public static CustomerDetail CreateInsertForm()
        {
            var form = new CustomerDetail();
            form.IsForUpdate = false;
            form.ShowDialog();

            return form;
        }

        public static CustomerDetail CreateUpdateForm(DataRow DataRowDetail)
        {
            var form = new CustomerDetail();
            form.IsForUpdate = true;

            form.transferDataRowDetailToForm(DataRowDetail);

            form.ShowDialog();

            return form;
        }

        private CustomerDetail()
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
            if (IsForUpdate == false)
            {
                DataAccess da = new DataAccess();
                if (da.IsInsertCustomers(lastNameTxt.Text, firstNameTxt.Text,addressTxt.Text,phoneTxt.Text, dateOfBirthDAT.Value))
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
                if (da.IsUpdateCustomers(lastNameTxt.Text, firstNameTxt.Text,addressTxt.Text,phoneTxt.Text, dateOfBirthDAT.Value, customerID))
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
