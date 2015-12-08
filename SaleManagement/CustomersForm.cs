using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class CustomersForm : Form
    {
        private DataAccess dataAccess;

        public CustomersForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            CustomerDetailsForm CustomersDetailForm = CustomerDetailsForm.CreateInsertForm();
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            Grc.DataSource = dataAccess.SelectCustomers();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow selectedRow = Grv.GetDataRow(Grv.FocusedRowHandle);
                CustomerDetailsForm.CreateUpdateForm(selectedRow);
                LoadDataToGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = Grv.SelectedRowsCount;
                if (selectedRowCount == 0)
                {
                    MessageBox.Show("You have to choose a category to delete.");
                    return;
                }

                string message = "Are you sure that you want to continue to perform this task?";
                DialogResult dialogResult = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;

                int failToDeletedCount = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    DataRow DataRowDetail = Grv.GetDataRow(Grv.GetSelectedRows()[i]);
                    int customerID = int.Parse(DataRowDetail["CustomerID"].ToString());
                    try
                    {
                        dataAccess.DeleteCustomer(customerID);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Customer named " + DataRowDetail["FirstName"].ToString() + " can not be deleted!");
                        failToDeletedCount++;
                    }
                }

                MessageBox.Show("Delete " + (selectedRowCount - failToDeletedCount) + " record(s) successfully!");
                LoadDataToGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void Grv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                DoRowDoubleClick(view, pt);
            }
            catch (Exception)
            {
                MessageBox.Show("Some errors occured!");
            }
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow selectedRow = Grv.GetDataRow(Grv.FocusedRowHandle);
                CustomerDetailsForm.CreateUpdateForm(selectedRow);
                LoadDataToGrid();
            }
            else MessageBox.Show("You have to choose one Category to update!");
        }

        private void Grv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
