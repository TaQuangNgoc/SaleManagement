using System;
using System.Windows.Forms;

namespace SaleManagement.Report
{
    public partial class CustomersStatistics : Form
    {
        public CustomersStatistics()
        {
            InitializeComponent();
        }

        private void CustomersStatistics_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            var dataAccess = new DataAccess();
            var procedureName = "[ProcedureStatistics]";
            DateTime fromDate = ngayBatDauDTPicker.Value,
                    toDate = ngayKetThucDTPicker.Value;

            pivotGridControl.DataSource = dataAccess.ExecuteProcedure(procedureName, fromDate, toDate);
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
