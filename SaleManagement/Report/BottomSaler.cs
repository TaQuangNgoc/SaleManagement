using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class BottomSaler : Form
    {
        public BottomSaler()
        {
            InitializeComponent();

            ngayBatDauDTPicker.Value = new DateTime(DateTime.Now.Year, 1, 1);
        }

        private void BottomSaler_Load(object sender, EventArgs e)
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
                pivotGridControl.DataSource = dataAccess.TableReturnFromProcedure10NhanVienBanDuocItTienNhat(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
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

        private void pivotGridControl_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            var employeeStatisticSaleDetailForm = new EmployeeStatisticSaleDetail();
            employeeStatisticSaleDetailForm.Display(e.CreateDrillDownDataSource());
        }

    }
}
