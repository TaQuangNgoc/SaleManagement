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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            CategoryDetailsForm CategoriesDetailForm = new CategoryDetailsForm();
            CategoriesDetailForm.displayForInsert();
=======
            CategoryDetailsForm.CreateInsertForm();
>>>>>>> origin/master
            LoadDataToGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
             
             try
<<<<<<< HEAD
             {                
                 Point pt = Grv.GridControl.PointToClient(Control.MousePosition);
                 DoRowDoubleClick(Grv, pt);
             }
             catch (Exception)
             {
                 MessageBox.Show("Some errors occured!");
             }
=======
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
                    DataRow selectedRow = Grv.GetDataRow(Grv.FocusedRowHandle);
                    CategoryDetailsForm.CreateUpdateForm(selectedRow);
                    LoadDataToGrid();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Some errors occured!");
            }
>>>>>>> origin/master
           
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


        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow DataRowDetail = Grv.GetDataRow(Grv.FocusedRowHandle);
                CategoryDetailsForm CategoriesDetailForm = new CategoryDetailsForm();
                CategoriesDetailForm.displayForUpdate(DataRowDetail);
                LoadDataToGrid();            
            }
            else MessageBox.Show("You have to choose one Category to update!");
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

        private void Grv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

       
    }
}
