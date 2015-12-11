using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagement.Report
{
    public partial class ProductsCantSale : Form
    {
        public ProductsCantSale()
        {
            InitializeComponent();

            ngayBatDauDTPicker.Value = new DateTime(DateTime.Now.Year, 1, 1);
        }

        private void ProductsCantBuy_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DateTime fromDate = ngayBatDauDTPicker.Value,
                    toDate = ngayKetThucDTPicker.Value;
            var dataAccess = new DataAccess();

            try
            {
                gridControl.DataSource = dataAccess.TableReturnFromProcedureMatHangKhongBanDuoc(fromDate, toDate);
            }
            catch (SqlException)
            {
                MessageBox.Show("An error has occured while trying to connect to server.", "Error");
            }
        }

        private void presentButton_Click(object sender, EventArgs e)
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
    }
}
