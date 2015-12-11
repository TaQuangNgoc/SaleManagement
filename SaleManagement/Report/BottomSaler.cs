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
            DataAccess da = new DataAccess();
            pivotGridControl.DataSource = da.TableReturnFromProcedure10NhanVienBanDuocItTienNhat(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            if (ngayBatDauDTPicker.Value <= ngayKetThucDTPicker.Value)
            {
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("You have to choose fromDate is smaller than toDate!");
            }
        }

        private void pivotGridControl_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            EmployeeStatisticSaleDetail employeeStatisticSaleDetailForm = new EmployeeStatisticSaleDetail();
            employeeStatisticSaleDetailForm.Display(e.CreateDrillDownDataSource());
        }

    }
}
