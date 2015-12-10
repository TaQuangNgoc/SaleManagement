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
    public partial class EmployeeStatisticsDetail : Form
    {
        public EmployeeStatisticsDetail()
        {
            InitializeComponent();
        }

        internal void Display(DevExpress.XtraPivotGrid.PivotDrillDownDataSource pivotDrillDownDataSource)
        {
            gridControl.DataSource = pivotDrillDownDataSource;
            this.ShowDialog();
        }
    }
}
