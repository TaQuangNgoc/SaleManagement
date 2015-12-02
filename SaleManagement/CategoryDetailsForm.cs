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
    public partial class CategoryDetailsForm : Form
    {
        private bool isForUpdate;
        private int categoryID;
        private DataAccess dataAccess;

        public static CategoryDetailsForm CreateInsertForm()
        {
            var form = new CategoryDetailsForm();
            form.isForUpdate = false;
            form.ShowDialog();

            return form;
        }

        public static CategoryDetailsForm CreateUpdateForm(DataRow selectedRow)
        {
            var form = new CategoryDetailsForm();
            form.isForUpdate = true;

            form.TransferDataRowDetailToForm(selectedRow);

            form.ShowDialog();

            return form;
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
                MessageBox.Show("category is empty");
            }
            string categoryName = categoryTxt.Text,
                    description = descriptionTxt.Text;

            bool categoryNameExists = dataAccess.CategoryNameExists(categoryName);
            if (categoryNameExists)
            {
                MessageBox.Show("Category name exists. Please select another name.");
                return;
            }

            if (isForUpdate)
                dataAccess.UpdateCategory(categoryName, description, categoryID);
            else
                dataAccess.InsertCategory(categoryName, description);

            MessageBox.Show("Success.");
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
