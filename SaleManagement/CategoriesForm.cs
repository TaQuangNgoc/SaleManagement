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
    public partial class CategoriesForm : Form
    {
        private DataAccess dataAccess;

        public CategoriesForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();

            this.Load += (s, e) => LoadDataToGrid();
            exitButton.Click += (s, e) => Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm.CreateInsertForm();
            LoadDataToGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (Grv.FocusedRowHandle == -1)
            {
                MessageBox.Show("You have to choose one Category to update!");
                return;
            }

            ShowUpdateForm();
        }

        private void ShowUpdateForm()
        {
            Debug.Assert(Grv.FocusedRowHandle != -1);

            DataRow selected = Grv.GetDataRow(Grv.FocusedRowHandle);
            CategoryDetailsForm.CreateUpdateForm(selected);
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            Grc.DataSource = dataAccess.SelectCategories();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int rowCount = Grv.SelectedRowsCount;
            if (rowCount == 0)
            {
                MessageBox.Show("You have to choose at lease 1 Category to delete!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to continue to perform this task?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int failNumber = 0;
                    for (int i = 0; i < rowCount; i++)
                    {
                        DataRow DataRowDetail = Grv.GetDataRow(Grv.GetSelectedRows()[i]);
                        int categoryID = int.Parse(DataRowDetail["CategoryID"].ToString());
                        DataAccess da = new DataAccess();

                        try
                        {
                            dataAccess.DeleteCategory(categoryID);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Category " + DataRowDetail["CategoryName"].ToString() + " have some Products, so you can not perform this task!");
                            failNumber++;
                        }
                    }

                    MessageBox.Show("Delete " + (rowCount - failNumber) + " record(s) successfully!");
                    LoadDataToGrid();
                }
            }
        }

        private void Grv_DoubleClick(object sender, EventArgs e)
        {
            var localMousePosition = Grc.PointToClient(MousePosition);
            var gridHitInfo = Grv.CalcHitInfo(localMousePosition);
            var clickedOnRow = gridHitInfo.InRow;

            if (clickedOnRow)
                ShowUpdateForm();
        }

        private void Grv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
