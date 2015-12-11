using System;
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

            this.Load += (s, e) => LoadDataToGrid();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void LoadDataToGrid()
        {
            gridControl.DataSource = dataAccess.SelectOrder();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            var newOrder = NewOrderForm.CreateInsertForm();
            LoadDataToGrid();
        }
    }
}
