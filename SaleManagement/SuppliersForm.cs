using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

            this.Load += (s, e) => LoadDataToGrid();
            exitButton.Click += (s, e) => Close();
        }

        private void LoadDataToGrid()
        {
            gridControl.DataSource = dataAccess.SelectSuppliers();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            SupplierDetailsForm.CreateInsertForm();
            LoadDataToGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowUpdateForm();
            }
            catch (NullReferenceException)
            {
                if (gridView.RowCount != 0)
                    throw;

                MessageBox.Show("There's no item to update.", "Error");
            }
        }

        private void ShowUpdateForm()
        {
            Debug.Assert(gridView.FocusedRowHandle != -1);

            DataRow selected = gridView.GetFocusedDataRow();
            SupplierDetailsForm.CreateUpdateForm(selected);
            LoadDataToGrid();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var localMousePosition = gridControl.PointToClient(MousePosition);
            var gridHitInfo = gridView.CalcHitInfo(localMousePosition);
            var clickedOnRow = gridHitInfo.InRow;

            if (clickedOnRow)
                ShowUpdateForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            DataRow selected;
            try
            {
                selected = gridView.GetFocusedDataRow();
            }
            catch (NullReferenceException)
            {
                if (gridView.RowCount != 0)
                    throw;

                MessageBox.Show("There's nothing to delete.", "Error");
                return;
            }

            var idString = (string)selected["SupplierID"];
            int id;

            try
            {
                id = int.Parse(idString);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect format of supplier ID. Contact your database administrator.", "Error");
                return;
            }

            try
            {
                dataAccess.DeleteSupplier(id);
            }
            catch (SqlException)
            {
                MessageBox.Show("An error has occured when trying to delete the item from database.", "Error");
            }

            MessageBox.Show("Deleted.");
            LoadDataToGrid();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
