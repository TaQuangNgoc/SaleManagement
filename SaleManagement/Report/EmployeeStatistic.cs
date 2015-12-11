using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DataAccess da = new DataAccess();
            pivotGridControl.DataSource = da.TableReturnFromProcedureStatistics(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void pivotGridControl_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            EmployeeStatisticsDetail employeeStatisticDetailForm = new EmployeeStatisticsDetail();
            employeeStatisticDetailForm.Display(e.CreateDrillDownDataSource());
        }
    }
}
