using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class AccountDetailsForm : Form
    {
        private string username;

        private DataAccess dataAccess;

        public AccountDetailsForm(string username)
        {
            InitializeComponent();

            dataAccess = new DataAccess();
            
            exitButton.Click += (s, e) => Close();

            this.username = username;
            GetDetails();
        }

        private void GetDetails()
        {
            Account account;
            try
            {
                account = dataAccess.GetAccountInfo(username);
            }
            catch (SqlException)
            {
                string message = "An error has occured while trying to connect to database."
                            + "Please try again later or contact your database administrator.";
                MessageBox.Show(message, "Error");
                Close();
                return;
            }

            usernameTextBox.Text = username;
            lastNameTextBox.Text = account.LastName;
            firstNameTextBox.Text = account.FirstName;
            addressTextBox.Text = account.Address;
            phoneTextBox.Text = account.Phone;
            dateOfBirthPicker.Value = account.DateOfBirth;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text,
                firstName = firstNameTextBox.Text,
                address = addressTextBox.Text,
                phone = phoneTextBox.Text;
            DateTime dateOfBirth = dateOfBirthPicker.Value;

            bool hasBlankFields = lastName == "" || firstName == ""
                                || address == "" || phone == "";
            if (hasBlankFields)
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            bool phoneNumberIsValid = phone.Any((c) => !char.IsDigit(c));
            if (phoneNumberIsValid)
            {
                MessageBox.Show("Phone number must consist only numbers.");
                return;
            }

            if (dateOfBirth > DateTime.Today)
            {
                MessageBox.Show("Hư cấu.");
                return;
            }

            var newInfo = new Account(username, lastName, firstName, address, phone, dateOfBirth);
            dataAccess.UpdateAccount(newInfo);

            MessageBox.Show("Success.");
            Close();
        }
    }
}