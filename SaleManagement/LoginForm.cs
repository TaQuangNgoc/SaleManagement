using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.Data.SqlClient;
using SaleManagement.Properties;
using System.Diagnostics;

namespace SaleManagement
{
    public partial class LoginForm : XtraForm
    {
        private DataAccess dataAccess;
        private bool autoclose;

        public LoginForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();

            idTextEdit.Enter += (s, e) => idTextEdit.SelectAll();
            passwordTextEdit.Enter += (s, e) => passwordTextEdit.SelectAll();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.ID == "")
                return;

            autoLoginCheckEdit.Checked = true;

            var id = Settings.Default.ID;
            var password = Convert.FromBase64String(Settings.Default.Password);

            ValidateAndProceedToMainForm(id, password);
        }

        private void ValidateAndProceedToMainForm(string id, byte[] password)
        {
            bool loginSuccess;
            try
            {
                loginSuccess = dataAccess.VerifyLoginDetails(id, password);
            }
            catch (SqlException)
            {
                string message = "An error has occured while trying to connect to database."
                            + "Please try again later or contact your database administrator.";
                MessageBox.Show(message, "Error");
                return;
            }

            if (!loginSuccess)
            {
                Debug.Assert(!autoLoginCheckEdit.Checked);

                string message = "ID or password is incorrect; please check your login details.";
                MessageBox.Show(message, "Error");
                return;
            }

            this.Hide();

            var mainForm = new MainForm();
            var result = mainForm.ShowDialog();

            bool logout = result == DialogResult.OK;
            if (!logout)
                this.Close();
            else
            {
                ResetFields();
                ResetCookies();
                this.Show();
            }
        }

        private void ResetFields()
        {
            idTextEdit.Text = "";
            passwordTextEdit.Text = "";
        }

        private void ResetCookies()
        {
            if (Settings.Default.ID != "")
            {
                Settings.Default.ID = "";
                Settings.Default.Password = "";
                Settings.Default.Save();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var hasher = SHA256.Create();
            var passwordString = passwordTextEdit.Text + "RandomSalt";
            var passwordBytes = Encoding.UTF8.GetBytes(passwordString);
            var password = hasher.ComputeHash(passwordBytes);
            string id = idTextEdit.Text;

            ValidateAndProceedToMainForm(id, password);
        }
    }
}