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
        private bool IsUpdate = true; // if Form is Insert State, IsUpdate= false;
        private decimal categoryID;

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            if (IsUpdate == false)
            {
                    DataAccess da = new DataAccess();
                    if (da.IsInsertCategories(categoryTxt.Text, descriptionTxt.Text))
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
                    if (da.IsUpdateCategories(categoryTxt.Text, descriptionTxt.Text, categoryID))
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

        internal void displayForUpdate(DataRow DataRowDetail)
        {
            transferDataRowDetailToForm(DataRowDetail);
            this.ShowDialog();
        }

        private void transferDataRowDetailToForm(DataRow DataRowDetail)
        {
            categoryTxt.Text = DataRowDetail["CategoryName"].ToString();
            descriptionTxt.Text = DataRowDetail["Description"].ToString();
            categoryID = decimal.Parse(DataRowDetail["CategoryID"].ToString());
        }

        internal void displayForInsert()
        {
            IsUpdate = false;
            this.ShowDialog();
        }

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
