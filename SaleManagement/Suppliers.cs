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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            SuppliersDetail SupplersDetailForm = new SuppliersDetail();
            SupplersDetailForm.displayForInsert();
            LoadDataToGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rowCount = Grv.SelectedRowsCount;
                if (rowCount == 0)
                {
                    MessageBox.Show("You have to choose one Category to update!");
                }
                else if (rowCount > 1)
                {
                    MessageBox.Show("You have to choose only one Category to update!");
                }
                else
                {
                    DataRow DataRowDetail = Grv.GetDataRow(Grv.FocusedRowHandle);
                    SuppliersDetail CategoriesDetailForm = new SuppliersDetail();
                    CategoriesDetailForm.displayForUpdate(DataRowDetail);
                    LoadDataToGrid();
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Some errors occured!");
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
            try
            {
                decimal rowCount = Grv.SelectedRowsCount;
                if (rowCount == 0)
                {
                    MessageBox.Show("You have to choose at lease 1 Category to delete!");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure that you want to continue to  perform this task?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        decimal j = 0;
                        for (int i = 0; i < rowCount; i++)
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

                        MessageBox.Show("Delete " + (rowCount - j) + " record(s) successfully!");
                       
                    }
                    LoadDataToGrid();
                }
            }
            catch (Exception)
            {

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
