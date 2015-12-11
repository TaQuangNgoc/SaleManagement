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
    public partial class StatisticByProductNumber : Form
    {
        public StatisticByProductNumber()
        {
            InitializeComponent();
            ngayBatDauDTPicker.Value = new DateTime(DateTime.Now.Year, 1, 1);
        }

        private void StatisticByProductNumber_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            pivotGridControl.DataSource = da.TableReturnFromProcedureStatistics(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
           
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            pivotGridControl.DataSource = da.TableReturnFromProcedureStatistics(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
        }
    }
}
