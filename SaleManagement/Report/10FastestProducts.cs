using System;
using System.Windows.Forms;

namespace SaleManagement.Report
{
    public partial class _10FastestProducts : Form
    {
        public _10FastestProducts()
        {
            InitializeComponent();
        }

        private void LoadDataToGrid()
        {
            var dataAccess = new DataAccess();
            var procedureName = "[Procedure10MatHangBanChayNhatTheoSoLuong]";
            DateTime fromDate = ngayBatDauDTPicker.Value,
                    toDate = ngayKetThucDTPicker.Value;

            gridControl.DataSource = dataAccess.ExecuteProcedure(procedureName, fromDate, toDate);
        }

        private void _10FastestProducts_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }


        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
