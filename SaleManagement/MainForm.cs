using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SaleManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CategoriesForm categoriesForm;
        ProductsForm productsForm;
        SuppliersForm suppliersForm;
        CustomersForm customersForm;
        public MainForm()
        {
            InitializeComponent();
            xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage1;
           
        }

        //form in tag

        //private void m_btn_report_ItemClick(object sender, ItemClickEventArgs e)
        //{


        //    if (v_f130_bao_cao == null || !IsFormOpen(v_f130_bao_cao))
        //    {
        //        v_f130_bao_cao = new ReportForm();
        //        v_f130_bao_cao.MdiParent = this;
        //        v_f130_bao_cao.Show();
        //    }
        //    else
        //    {
        //        v_f130_bao_cao.Focus();
        //    }
        //}

        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }

        private void categoriesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
             if (categoriesForm == null || !IsFormOpen(categoriesForm))
             {
                 categoriesForm = new CategoriesForm();
                 categoriesForm.MdiParent = this;
                 categoriesForm.Show();
             }
             else
             {
                 categoriesForm.Focus();
             }
        }

        private void productsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (productsForm == null || !IsFormOpen(productsForm))
            {
                productsForm = new ProductsForm();
                productsForm.MdiParent = this;
                productsForm.Show();
            }
            else
            {
                productsForm.Focus();
            }
        }

        private void suppliersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (suppliersForm == null || !IsFormOpen(suppliersForm))
            {
                suppliersForm = new SuppliersForm();
                suppliersForm.MdiParent = this;
                suppliersForm.Show();
            }
            else
            {
                suppliersForm.Focus();
            }
        }

        private void customersButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customersForm == null || !IsFormOpen(customersForm))
            {
                customersForm = new CustomersForm();
                customersForm.MdiParent = this;
                customersForm.Show();
            }
            else
            {
                customersForm.Focus();
            }
        }

        
    }
}