using DevExpress.XtraGrid.Views.Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class NewOrderForm : Form
    {
        private NewOrderForm()
        {
            InitializeComponent();
        }

        public static NewOrderForm CreateInsertForm()
        {
            var form = new NewOrderForm();
            form.ShowDialog();
            return form;
        }

        DataAccess dataAccess;
        DataTable OrderDetailTable;

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            dataAccess = new DataAccess();
            comboBoxCustomerPhone.DisplayMember = "Phone";
            comboBoxCustomerPhone.ValueMember = "CustomerID";
            DataTable dt = dataAccess.SelectCustomers();
            dt.Rows.Add(-1, "Nhập số điện thoại");
            comboBoxCustomerPhone.DataSource = dt;
            comboBoxCustomerPhone.SelectedValue = -1;

            OrderDetailTable = new DataTable();
            OrderDetailTable.Columns.Add("ProductID");
            OrderDetailTable.Columns.Add("Product");
            OrderDetailTable.Columns.Add("UnitPrice");
            OrderDetailTable.Columns.Add("Quantity");
            OrderDetailTable.Columns.Add("Discount");

            gridControl.DataSource = OrderDetailTable;

            productLookUpEdit.DataSource = dataAccess.SelectProductNames();
            productLookUpEdit.DisplayMember = "ProductName";
            productLookUpEdit.ValueMember = "ProductID";
        }

        private void comboBoxCustomerPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomerPhone.SelectedValue != null)
            {
                decimal ID_khach_hang = Convert.ToDecimal(comboBoxCustomerPhone.SelectedValue.ToString());
                if (ID_khach_hang <= 0)
                {
                    lastNameTxt.Text = "";
                   firstNameTxt.Text = "";
                   addressTxt.Text = "";
                    dateOfBirthDAT.Value= DateTime.Now;
                    return;
                }
                dataAccess = new DataAccess();
                DataRow DataRowDetail = dataAccess.SelectCustomers(ID_khach_hang);
                lastNameTxt.Text = DataRowDetail["LastName"].ToString();
                firstNameTxt.Text = DataRowDetail["FirstName"].ToString();
                addressTxt.Text = DataRowDetail["Address"].ToString();
                dateOfBirthDAT.Value = Convert.ToDateTime(DataRowDetail["DateOfBirth"].ToString());                
               // load_data_2_grid_khach_hang_don_hang();
            }
        }

        


        private void grv_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void productLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            dataAccess = new DataAccess();
            decimal id = (decimal)grv.GetRowCellValue(grv.FocusedRowHandle, "Product");
            grv.SetRowCellValue(grv.FocusedRowHandle, "UnitPrice",dataAccess.SelectUnnitPrice(id));
               
        }
            
     
    }
}
