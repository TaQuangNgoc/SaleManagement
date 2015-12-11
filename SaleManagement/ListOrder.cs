using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class ListOrder : Form
    {
        private DataAccess dataAccess;
        public ListOrder()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }


        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {           
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();       
        }

        private void ListOrder_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            
        }

        private void LoadDataToGrid()
        {
            DataAccess da = new DataAccess();
            gridControl.DataSource = da.SelectOrder();    
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewOrderForm newOrder = NewOrderForm.CreateInsertForm();
                LoadDataToGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Some error"+ex.ToString());
            }
        }

        
      

        
       
    }
}
