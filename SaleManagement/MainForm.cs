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

        private StatisticByProductNumber statistic;
        private _10FastestProducts fastestProductsForm;
        private ProductsCantSale productCantSaleForm;
        private StatisticPrice statisticPriceForm;
        private MaxRevenue maxRevenueForm;
        private CustomersStatistics customersStatisticsForm;
        private MaxCustomers maxCustomerForm;
        private EmployeeStatistic employeeStatistics;
        private MaxEmployeeByNumber maxEmployeeForm;
        private MinEmployee minEmployeeForm;
        private EmployeeStatisticsSale employeeStatisticForm;
        private TopSaler topSalerForm;
        private BottomSaler bottomSalerForm;

        public MainForm(string username)
        {
            InitializeComponent();

            mdiManager.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbonControl.SelectedPage = listingPage;

            this.username = username;
        }

        private void categoriesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(categoriesForm))
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
            if (IsOpened(productsForm))
                productsForm.Focus();
            else
            {
                productsForm = new ProductsForm();
                productsForm.MdiParent = this;
                productsForm.Show();
            }
        }

        private void suppliersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(suppliersForm))
                suppliersForm.Focus();
            else
            {
                suppliersForm = new SuppliersForm();
                suppliersForm.MdiParent = this;
                suppliersForm.Show();
            }
        }

        private void customersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(customersForm))
                customersForm.Focus();
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
            if (IsOpened(statistic))
                statistic.Focus();
            else
            {
                statistic = new StatisticByProductNumber();
                statistic.MdiParent = this;
                statistic.Show();
            }
        }

        private void topNumberProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(fastestProductsForm))
                fastestProductsForm.Focus();
            else
            {
                fastestProductsForm = new _10FastestProducts();
                fastestProductsForm.MdiParent = this;
                fastestProductsForm.Show();
            }
        }

        private void productsCantSaleButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(productCantSaleForm))
                productCantSaleForm.Focus();
            else
            {
                productCantSaleForm = new ProductsCantSale();
                productCantSaleForm.MdiParent = this;
                productCantSaleForm.Show();
            }
        }

        private void priceStatisticsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(statisticPriceForm))
                statisticPriceForm.Focus();
            else
            {
                statisticPriceForm = new StatisticPrice();
                statisticPriceForm.MdiParent = this;
                statisticPriceForm.Show();
            }
        }

        private void topReveueProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(maxRevenueForm))
                maxRevenueForm.Focus();
            else
            {
                maxRevenueForm = new MaxRevenue();
                maxRevenueForm.MdiParent = this;
                maxRevenueForm.Show();
            }
        }

        private void customerStatisticsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(customersStatisticsForm))
                maxRevenueForm.Focus();
            else
            {
                customersStatisticsForm = new CustomersStatistics();
                customersStatisticsForm.MdiParent = this;
                customersStatisticsForm.Show();
            }
        }

        private void topCustomersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(maxCustomerForm))
                maxCustomerForm.Focus();
            else
            {
                maxCustomerForm = new MaxCustomers();
                maxCustomerForm.MdiParent = this;
                maxCustomerForm.Show();
            }
        }

        private void employeeStatisticsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(employeeStatistics))
                maxCustomerForm.Focus();
            else
            {
                employeeStatistics = new EmployeeStatistic();
                employeeStatistics.MdiParent = this;
                employeeStatistics.Show();
            }
        }

        private void topEmployeeByProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(maxEmployeeForm))
                maxEmployeeForm.Focus();
            else
            {
                maxEmployeeForm = new MaxEmployeeByNumber();
                maxEmployeeForm.MdiParent = this;
                maxEmployeeForm.Show();
            }
        }

        private void bottomEmployeesByProductsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(minEmployeeForm))
                minEmployeeForm.Focus();
            else
            {
                minEmployeeForm = new MinEmployee();
                minEmployeeForm.MdiParent = this;
                minEmployeeForm.Show();
            }
        }

        private void employeeStatisticsPriceButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(employeeStatisticForm))
                employeeStatisticForm.Focus();
            else
            {
                employeeStatisticForm = new EmployeeStatisticsSale();
                employeeStatisticForm.MdiParent = this;
                employeeStatisticForm.Show();
            }
        }

        private void topSalersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(topSalerForm))
                topSalerForm.Focus();
            else
            {
                topSalerForm = new TopSaler();
                topSalerForm.MdiParent = this;
                topSalerForm.Show();
            }
        }

        private void bottomSalersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(bottomSalerForm))
                bottomSalerForm.Focus();
            else
            {
                bottomSalerForm = new BottomSaler();
                bottomSalerForm.MdiParent = this;
                bottomSalerForm.Show();
            }
        }

        private bool IsOpened(Form form)
        {
            return form != null && form.Visible;
        }
    }
}