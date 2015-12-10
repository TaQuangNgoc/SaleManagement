using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class CustomerDetailsForm : Form
    {
        private bool isForUpdate;
        private int customerID;
        private DataAccess dataAccess;

        public static DialogResult CreateInsertDialog()
        {
            var form = new CustomerDetailsForm();
            form.isForUpdate = false;

            return form.ShowDialog();
        }

        public static DialogResult CreateUpdateDialog(DataRow selectedRow)
        {
            var form = new CustomerDetailsForm();
            form.isForUpdate = true;
            form.GetInfo(selectedRow);
            
            return form.ShowDialog();
        }

        private CustomerDetailsForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void GetInfo(DataRow DataRowDetail)
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
            if (this.HasBlankFields())
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            if (phoneTxt.Text.Any((c) => !char.IsDigit(c)))
            {
                MessageBox.Show("Phone number must consist only numbers.");
                return;
            }

            string lastName = lastNameTxt.Text,
                firstName = firstNameTxt.Text,
                address = addressTxt.Text,
                phone = phoneTxt.Text;
            DateTime dateOfBirth = dateOfBirthDAT.Value;

            if (dateOfBirth > DateTime.Today)
            {
                MessageBox.Show("Hư cấu.");
                return;
            }

            if (isForUpdate)
                dataAccess.UpdateCustomer(lastName, firstName, address, phone, dateOfBirth, customerID);
            else
                dataAccess.InsertCustomer(lastName, firstName, address, phone, dateOfBirth);

            MessageBox.Show("Success.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool HasBlankFields()
        {
            return lastNameTxt.Text == ""
                || firstNameTxt.Text == ""
                || phoneTxt.Text == ""
                || addressTxt.Text == "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}