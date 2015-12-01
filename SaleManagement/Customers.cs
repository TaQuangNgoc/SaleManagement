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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            CustomerDetail CustomersDetailForm = CustomerDetail.CreateInsertForm();
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DataAccess da = new DataAccess();
            Grc.DataSource = da.CustomersDataTable();
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
                    DataRow dataRowDetail = Grv.GetDataRow(Grv.FocusedRowHandle);
                    CustomerDetail CustomersDetailForm = CustomerDetail.CreateUpdateForm(dataRowDetail);
                    LoadDataToGrid();
                }
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Some errors occured!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            decimal customerID = decimal.Parse(DataRowDetail["CustomerID"].ToString());
                            DataAccess da = new DataAccess();
                            if (!da.IsDeleteCustomers(customerID))
                            {
                                MessageBox.Show("Customer named " + DataRowDetail["FirstName"].ToString() + " can not delete!");
                                j++;
                            }
                        }

                        MessageBox.Show("Delete " + (rowCount - j) + " record(s) successfully!");
                        LoadDataToGrid();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
