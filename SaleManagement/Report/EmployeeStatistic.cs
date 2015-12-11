using DevExpress.XtraPivotGrid;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagement.Report
{
    public partial class EmployeeStatistic : Form
    {
        public EmployeeStatistic()
        {
            InitializeComponent();

            ngayBatDauDTPicker.Value = new DateTime(DateTime.Now.Year, 1, 1);
        }

        private void EmployeeStatistic_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DateTime fromDate = ngayBatDauDTPicker.Value,
                    toDate = ngayKetThucDTPicker.Value;
            var dataAccess = new DataAccess();
            var procedureName = "[ProcedureStatistics]";

            try
            {
                pivotGridControl.DataSource = dataAccess.ExecuteProcedure(procedureName, fromDate, toDate);
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

        private void pivotGridControl_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            var employeeStatisticDetailForm = new EmployeeStatisticsDetail();
            employeeStatisticDetailForm.Display(e.CreateDrillDownDataSource());
        }
    }
}
