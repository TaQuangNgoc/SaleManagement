using DevExpress.XtraBars;
using DevExpress.XtraTab;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CategoriesForm categoriesForm;
        private ProductsForm productsForm;
        private SuppliersForm suppliersForm;
        private CustomersForm customersForm;

        public MainForm()
        {
            InitializeComponent();

            mdiManager.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbonControl.SelectedPage = listingPage;
        }

        private void categoriesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (categoriesForm != null)
                categoriesForm.Focus();
            else
            {
                categoriesForm = new CategoriesForm();
                categoriesForm.MdiParent = this;
                categoriesForm.Show();
            }
        }

        private void productsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (productsForm != null)
            {
                productsForm.Focus();
            }
            else
            {
                productsForm = new ProductsForm();
                productsForm.MdiParent = this;
                productsForm.Show();
            }
        }

        private void suppliersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (suppliersForm != null)
            {
                suppliersForm.Focus();
            }
            else
            {
                suppliersForm = new SuppliersForm();
                suppliersForm.MdiParent = this;
                suppliersForm.Show();
            }
        }

        private void customersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customersForm != null)
            {
                customersForm.Focus();
            }
            else
            {
                customersForm = new CustomersForm();
                customersForm.MdiParent = this;
                customersForm.Show();
            }
        }

        private void logoutButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}