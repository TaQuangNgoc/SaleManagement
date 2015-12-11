using System;
using System.Windows.Forms;

namespace SaleManagement.Report
{
    public partial class CustomersStatistics : Form
    {
        public CustomersStatistics()
        {
            InitializeComponent();
            ngayBatDauDTPicker.Value = new DateTime(DateTime.Now.Year, 1, 1);
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
            if (fromDate <= toDate)
            {
                pivotGridControl.DataSource = dataAccess.ExecuteProcedure(procedureName, fromDate, toDate);
            }
            else
            {
                MessageBox.Show("You have to choose fromDate is smaller than toDate!");
            }

        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
