using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;
using SaleManagement.Report;

namespace SaleManagement
{
    public partial class MainForm : RibbonForm
    {
        private string username;

        private CategoriesForm categoriesForm;
        private ProductsForm productsForm;
        private SuppliersForm suppliersForm;
        private CustomersForm customersForm;
        StatisticByProductNumber statistic;
        _10FastestProducts fastestProductsForm;
        ProductsCantSale productCantSaleForm;
        StatisticPrice statisticPriceForm;
        MaxRevenue maxRevenueForm;
        CustomersStatistics customersStatisticsForm;
        MaxCustomers maxCustomerForm;
        EmployeeStatistic employeeStatistics;
        MaxEmployeeByNumber maxEmployeeForm;
        MinEmployee minEmployeeForm;
        EmployeeStatisticsSale employeeStatisticForm;
        TopSaler topSalerForm;
        BottomSaler bottomSalerForm;

        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }

        public MainForm(string username)
        {
            InitializeComponent();

            mdiManager.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbonControl.SelectedPage = listingPage;

            this.username = username;
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

        private void editAccountButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var editForm = new AccountDetailsForm(username);
            editForm.ShowDialog();
        }

        private void logoutButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void productsStatisticsNumberButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (statistic == null || !IsFormOpen(statistic))
            {
                statistic = new StatisticByProductNumber();
                statistic.MdiParent = this;
                statistic.Show();
            }
            else
            {
                statistic.Focus();
            }
        }

        private void topNumberProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fastestProductsForm == null || !IsFormOpen(fastestProductsForm))
            {
                fastestProductsForm = new _10FastestProducts();
                fastestProductsForm.MdiParent = this;
                fastestProductsForm.Show();
            }
            else
            {
                fastestProductsForm.Focus();
            }
        }

        private void productsCantSaleButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (productCantSaleForm == null || !IsFormOpen(productCantSaleForm))
            {
                productCantSaleForm = new ProductsCantSale();
                productCantSaleForm.MdiParent = this;
                productCantSaleForm.Show();
            }
            else
            {
                productCantSaleForm.Focus();
            }
        }

        private void priceStatisticsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (statisticPriceForm == null || !IsFormOpen(statisticPriceForm))
            {
                statisticPriceForm = new StatisticPrice();
                statisticPriceForm.MdiParent = this;
                statisticPriceForm.Show();
            }
            else
            {
                statisticPriceForm.Focus();
            }
        }

        private void topReveueProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (maxRevenueForm == null || !IsFormOpen(maxRevenueForm))
            {
                maxRevenueForm = new MaxRevenue();
                maxRevenueForm.MdiParent = this;
                maxRevenueForm.Show();
            }
            else
            {
                maxRevenueForm.Focus();
            }
        }

        private void customerStatisticsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customersStatisticsForm == null || !IsFormOpen(customersStatisticsForm))
            {
                customersStatisticsForm = new CustomersStatistics();
                customersStatisticsForm.MdiParent = this;
                customersStatisticsForm.Show();
            }
            else
            {
                maxRevenueForm.Focus();
            }
        }

        private void topCustomersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (maxCustomerForm == null || !IsFormOpen(maxCustomerForm))
            {
                maxCustomerForm = new MaxCustomers();
                maxCustomerForm.MdiParent = this;
                maxCustomerForm.Show();
            }
            else
            {
                maxCustomerForm.Focus();
            }
        }

        private void employeeStatisticsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (employeeStatistics == null || !IsFormOpen(employeeStatistics))
            {
                employeeStatistics = new EmployeeStatistic();
                employeeStatistics.MdiParent = this;
                employeeStatistics.Show();
            }
            else
            {
                maxCustomerForm.Focus();
            }
        }

        private void topEmployeeByProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (maxEmployeeForm == null || !IsFormOpen(maxEmployeeForm))
            {
                maxEmployeeForm = new MaxEmployeeByNumber();
                maxEmployeeForm.MdiParent = this;
                maxEmployeeForm.Show();
            }
            else
            {
                maxEmployeeForm.Focus();
            }
        }

        private void bottomEmployeesByProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (minEmployeeForm == null || !IsFormOpen(minEmployeeForm))
            {
                minEmployeeForm = new MinEmployee();
                minEmployeeForm.MdiParent = this;
                minEmployeeForm.Show();
            }
            else
            {
                minEmployeeForm.Focus();
            }
        }

        private void employeeStatisticsPriceButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (employeeStatisticForm == null || !IsFormOpen(employeeStatisticForm))
            {
                employeeStatisticForm = new EmployeeStatisticsSale();
                employeeStatisticForm.MdiParent = this;
                employeeStatisticForm.Show();
            }
            else
            {
                employeeStatisticForm.Focus();
            }
        }

        private void topSalersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (topSalerForm == null || !IsFormOpen(topSalerForm))
            {
                topSalerForm = new TopSaler();
                topSalerForm.MdiParent = this;
                topSalerForm.Show();
            }
            else
            {
                topSalerForm.Focus();
            }
        }

        private void bottomSalersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bottomSalerForm == null || !IsFormOpen(bottomSalerForm))
            {
                bottomSalerForm = new BottomSaler();
                bottomSalerForm.MdiParent = this;
                bottomSalerForm.Show();
            }
            else
            {
                bottomSalerForm.Focus();
            }
        }
    }
}