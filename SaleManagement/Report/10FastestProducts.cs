using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagement.Report
{
    public partial class _10FastestProducts : Form
    {
        public _10FastestProducts()
        {
            InitializeComponent();

            ngayBatDauDTPicker.Value = new DateTime(DateTime.Now.Year, 2, 1);
        }

        private void LoadDataToGrid()
        {
            DateTime fromDate = ngayBatDauDTPicker.Value,
                    toDate = ngayKetThucDTPicker.Value;
            var dataAccess = new DataAccess();
            var procedureName = "[Procedure10MatHangBanChayNhatTheoSoLuong]";

            try
            {
                gridControl.DataSource = dataAccess.ExecuteProcedure(procedureName, fromDate, toDate);
            }
            catch (SqlException)
            {
                MessageBox.Show("An error has occured while trying to connect to server.", "Error");
            }
        }

        private void _10FastestProducts_Load(object sender, EventArgs e)
        {
            DateTime fromDate = ngayBatDauDTPicker.Value,
                    toDate = ngayKetThucDTPicker.Value;

            bool isValid = fromDate <= toDate;
            if (!isValid)
            {
                MessageBox.Show("Date range is invalid.", "Error");
                return;
            }

            LoadDataToGrid();
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
