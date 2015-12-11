using System.Windows.Forms;

namespace SaleManagement
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
