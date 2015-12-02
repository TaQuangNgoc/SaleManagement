using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class SuppliersForm : Form
    {
        private DataAccess dataAccess;

        public SuppliersForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            SupplierDetailsForm.CreateInsertForm();
            LoadDataToGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = Grv.SelectedRowsCount;
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a category to update.");
                return;
            }
            if (selectedRowCount > 1)
            {
                MessageBox.Show("You can only choose one category to update.");
                return;
            }

            try
            {
                DataRow selectedRow = Grv.GetDataRow(Grv.FocusedRowHandle);
                SupplierDetailsForm.CreateUpdateForm(selectedRow);
                LoadDataToGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DataAccess da = new DataAccess();
            Grc.DataSource = da.SelectSuppliers();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = Grv.SelectedRowsCount;
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            try
            {
                bool plural = selectedRowCount > 1;
                string itemType = (plural) ? "categories" : "category",
                     warningMessage = "Are you sure that you want to delete the selected " + itemType + "?";
                var dialogResult = MessageBox.Show(warningMessage, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    decimal j = 0;
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        DataRow DataRowDetail = Grv.GetDataRow(Grv.GetSelectedRows()[i]);
                        int SupplierID = int.Parse(DataRowDetail["SupplierID"].ToString());

                        try
                        {
                            dataAccess.DeleteSupplier(SupplierID);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Company named " + DataRowDetail["CompanyName"].ToString() + " have some Products, so you can not perform this task!");
                            j++;
                        }
                    }

                    MessageBox.Show("Delete " + (selectedRowCount - j) + " record(s) successfully!");

                    LoadDataToGrid();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
