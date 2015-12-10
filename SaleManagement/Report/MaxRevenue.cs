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
    public partial class MaxRevenue : Form
    {
        public MaxRevenue()
        {
            InitializeComponent();
        }

        private void MaxRevenue_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            DataAccess da = new DataAccess();
            gridControl.DataSource = da.TableReturnFromProcedure10MatHangBanCoDoanhSoLonNhat(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
           
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
