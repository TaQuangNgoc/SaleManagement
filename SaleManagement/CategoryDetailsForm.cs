using System;
using System.Data;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class CategoryDetailsForm : Form
    {
        private bool isForUpdate;
        private int categoryID;
        private DataAccess dataAccess;

        public static DialogResult CreateInsertDialog()
        {
            var form = new CategoryDetailsForm();
            form.isForUpdate = false;

            return form.ShowDialog();
        }

        public static DialogResult CreateUpdateDialog(DataRow selectedRow)
        {
            var form = new CategoryDetailsForm();
            form.isForUpdate = true;
            form.TransferDataRowDetailToForm(selectedRow);

            return form.ShowDialog();
        }

        private CategoryDetailsForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void TransferDataRowDetailToForm(DataRow dataRow)
        {
            categoryTxt.Text = dataRow["CategoryName"].ToString();
            descriptionTxt.Text = dataRow["Description"].ToString();
            categoryID = int.Parse(dataRow["CategoryID"].ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (categoryTxt.Text == "") 
            {
                MessageBox.Show("Category is empty");
                return;
            }
            string categoryName = categoryTxt.Text,
                    description = descriptionTxt.Text;

            if (isForUpdate)
                dataAccess.UpdateCategory(categoryName, description, categoryID);
            else
            {
                bool categoryNameExists = dataAccess.CategoryNameExists(categoryName);
                if (categoryNameExists)
                {
                    MessageBox.Show("Category name exists. Please select another name.");
                    return;
                }
                dataAccess.InsertCategory(categoryName, description);
            }

            MessageBox.Show("Success.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
