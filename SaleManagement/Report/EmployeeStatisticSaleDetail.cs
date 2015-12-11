using System.Windows.Forms;

namespace SaleManagement
{
    public partial class EmployeeStatisticSaleDetail : Form
    {
        public EmployeeStatisticSaleDetail()
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
