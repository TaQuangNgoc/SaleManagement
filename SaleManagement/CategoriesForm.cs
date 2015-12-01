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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            CategoriesDetail CategoriesDetailForm = new CategoriesDetail();
            CategoriesDetailForm.displayForInsert();
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
                    CategoriesDetail CategoriesDetailForm = new CategoriesDetail();
                    CategoriesDetailForm.displayForUpdate(DataRowDetail);
                    LoadDataToGrid();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Some errors occured!");
            }
           
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DataAccess da = new DataAccess();
            Grc.DataSource = da.CategoriesDataTable();
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
			                 DataRow DataRowDetail =Grv.GetDataRow(Grv.GetSelectedRows()[i]);
                                decimal CategoryID = decimal.Parse(DataRowDetail["CategoryID"].ToString());
                                DataAccess da = new DataAccess();
                                if (!da.IsDeleteCategories(CategoryID))
                                {
                                    MessageBox.Show("Category "+ DataRowDetail["CategoryName"].ToString()+" have some Products, so you can not perform this task!");
                                    j++;
                                }
			            }

                        MessageBox.Show("Delete "+( rowCount-j) + " record(s) successfully!");                   
                        LoadDataToGrid();
                    }
                }
            }
            catch (Exception )
            {
                
            }
        }
    }
}
