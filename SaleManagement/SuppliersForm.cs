using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
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
            Grc.DataSource = da.SuppliersDataTable();
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
                        decimal SupplierID = decimal.Parse(DataRowDetail["SupplierID"].ToString());
                        DataAccess da = new DataAccess();
                        if (!da.IsDeleteSuppliers(SupplierID))
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

        private void Grv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
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
                SupplierDetailsForm.CreateUpdateForm(selectedRow);
                LoadDataToGrid();
            }
            else MessageBox.Show("You have to choose one Category to update!");
        }
    }
}
