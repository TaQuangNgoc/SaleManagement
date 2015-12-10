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
    public partial class _10FastestProducts : Form
    {
        public _10FastestProducts()
        {
            InitializeComponent();
        }

        private void LoadDataToGrid()
        {

            DataAccess da = new DataAccess();
            gridControl.DataSource = da.TableReturnFromProcedure10MatHangBanChayNhatTheoSoLuong(ngayBatDauDTPicker.Value, ngayKetThucDTPicker.Value);
        }

        private void _10FastestProducts_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }


        private void presentButton_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
