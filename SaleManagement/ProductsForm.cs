using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
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
    public partial class ProductsForm : Form
    {
        private DataAccess dataAccess;

        public ProductsForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();

            this.Load += (s, e) => LoadDataToGrid();
            exitButton.Click += (s, e) => Close();

            unitPriceColumn.DisplayFormat.FormatType = FormatType.Custom;
            unitPriceColumn.DisplayFormat.FormatString = "c";
        }

        private void LoadDataToGrid()
        {
            gridControl.DataSource = dataAccess.SelectProducts();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            ProductDetailsForm.CreateInsertForm();
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
            ProductDetailsForm.CreateUpdateForm(selected);
            LoadDataToGrid();
        }

        private void cardView_DoubleClick(object sender, EventArgs e)
        {
            var localMousePosition = gridControl.PointToClient(MousePosition);
            var gridHitInfo = cardView.CalcHitInfo(localMousePosition);
            var clickedOnCard = gridHitInfo.InCard;

            if (clickedOnCard)
                ShowUpdateForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            DataRow selected = gridView.GetFocusedDataRow();
            var idString = (string)selected["ProductID"];
            int id;

            try
            {
                 id = int.Parse(idString);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect format of product ID. Contact your database administrator.", "Error");
                return;
            }

            try
            {
                dataAccess.DeleteProducts(id);
            }
            catch (SqlException)
            {
                MessageBox.Show("An error has occured when trying to delete the item from database.", "Error");
            }

            MessageBox.Show("Deleted.");
            LoadDataToGrid();
        }
    }
}
