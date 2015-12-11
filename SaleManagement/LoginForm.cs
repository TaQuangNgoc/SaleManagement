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

        public LoginForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();

            usernameTextEdit.Enter += (s, e) => usernameTextEdit.SelectAll();
            passwordTextEdit.Enter += (s, e) => passwordTextEdit.SelectAll();
            exitButton.Click += (s, e) => Close();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.Username == "")
                return;

            autoLoginCheckEdit.Checked = true;

            var username = Settings.Default.Username;
            var password = Convert.FromBase64String(Settings.Default.Password);

            ValusernameateAndProceedToMainForm(username, password);
        }

        private void ValusernameateAndProceedToMainForm(string username, byte[] password)
        {
            bool loginSuccess;
            try
            {
                loginSuccess = dataAccess.VerifyLoginDetails(username, password);
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
                string message = "Username or password is incorrect; please check your login details.";
                MessageBox.Show(message, "Error");
                return;
            }

            this.Hide();

            var mainForm = new MainForm(username);
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
            usernameTextEdit.Text = "";
            passwordTextEdit.Text = "";
        }

        private void ResetCookies()
        {
            if (Settings.Default.Username != "")
            {
                Settings.Default.Username = "";
                Settings.Default.Password = "";
                Settings.Default.Save();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var hasher = SHA1.Create();
            var passwordString = passwordTextEdit.Text + "RandomSalt";
            var passwordBytes = Encoding.Unicode.GetBytes(passwordString);
            var password = hasher.ComputeHash(passwordBytes);
            string username = usernameTextEdit.Text;

            if (autoLoginCheckEdit.Checked)
                SavePassword(username, password);

            ValusernameateAndProceedToMainForm(username, password);
        }

        private void SavePassword(string username, byte[] password)
        {
            Settings.Default.Username = usernameTextEdit.Text;
            Settings.Default.Password = Convert.ToBase64String(password);
            Settings.Default.Save();
        }
    }
}