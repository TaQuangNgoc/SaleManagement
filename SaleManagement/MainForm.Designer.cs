namespace SaleManagement
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.categoriesButton = new DevExpress.XtraBars.BarButtonItem();
            this.productsButton = new DevExpress.XtraBars.BarButtonItem();
            this.suppliersButton = new DevExpress.XtraBars.BarButtonItem();
            this.customersButton = new DevExpress.XtraBars.BarButtonItem();
            this.logoutButton = new DevExpress.XtraBars.BarButtonItem();
            this.editAccountButton = new DevExpress.XtraBars.BarButtonItem();
            this.productsStatisticsNumberButton = new DevExpress.XtraBars.BarButtonItem();
            this.topNumberProductsButton = new DevExpress.XtraBars.BarButtonItem();
            this.productsCantSaleButton = new DevExpress.XtraBars.BarButtonItem();
            this.priceStatisticsButton = new DevExpress.XtraBars.BarButtonItem();
            this.topReveueProductsButton = new DevExpress.XtraBars.BarButtonItem();
            this.customerStatisticsButton = new DevExpress.XtraBars.BarButtonItem();
            this.topCustomersButton = new DevExpress.XtraBars.BarButtonItem();
            this.employeeStatisticsButton = new DevExpress.XtraBars.BarButtonItem();
            this.topEmployeeByProductsButton = new DevExpress.XtraBars.BarButtonItem();
            this.bottomEmployeesByProductsButton = new DevExpress.XtraBars.BarButtonItem();
            this.employeeStatisticsPriceButton = new DevExpress.XtraBars.BarButtonItem();
            this.topSalersButton = new DevExpress.XtraBars.BarButtonItem();
            this.bottomSalersButton = new DevExpress.XtraBars.BarButtonItem();
            this.listingPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.listingPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.reportPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.reportPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.accountPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.accountPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.categoriesButton,
            this.productsButton,
            this.suppliersButton,
            this.customersButton,
            this.logoutButton,
            this.editAccountButton,
            this.productsStatisticsNumberButton,
            this.topNumberProductsButton,
            this.productsCantSaleButton,
            this.priceStatisticsButton,
            this.topReveueProductsButton,
            this.customerStatisticsButton,
            this.topCustomersButton,
            this.employeeStatisticsButton,
            this.topEmployeeByProductsButton,
            this.bottomEmployeesByProductsButton,
            this.employeeStatisticsPriceButton,
            this.topSalersButton,
            this.bottomSalersButton});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 24;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.listingPage,
            this.reportPage,
            this.accountPage});
            this.ribbonControl.Size = new System.Drawing.Size(1180, 163);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // categoriesButton
            // 
            this.categoriesButton.Caption = "CATEGORIES";
            this.categoriesButton.Glyph = ((System.Drawing.Image)(resources.GetObject("categoriesButton.Glyph")));
            this.categoriesButton.Id = 4;
            this.categoriesButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("categoriesButton.LargeGlyph")));
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.categoriesButton_ItemClick);
            // 
            // productsButton
            // 
            this.productsButton.Caption = "PRODUCTS";
            this.productsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("productsButton.Glyph")));
            this.productsButton.Id = 5;
            this.productsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("productsButton.LargeGlyph")));
            this.productsButton.Name = "productsButton";
            this.productsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.productsButton_ItemClick);
            // 
            // suppliersButton
            // 
            this.suppliersButton.Caption = "SUPPLIERS";
            this.suppliersButton.Glyph = ((System.Drawing.Image)(resources.GetObject("suppliersButton.Glyph")));
            this.suppliersButton.Id = 6;
            this.suppliersButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("suppliersButton.LargeGlyph")));
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.suppliersButton_ItemClick);
            // 
            // customersButton
            // 
            this.customersButton.Caption = "CUSTOMERS";
            this.customersButton.Glyph = ((System.Drawing.Image)(resources.GetObject("customersButton.Glyph")));
            this.customersButton.Id = 7;
            this.customersButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("customersButton.LargeGlyph")));
            this.customersButton.Name = "customersButton";
            this.customersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customersButton_ItemClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Caption = "LOG OUT";
            this.logoutButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.logoutButton.Glyph = ((System.Drawing.Image)(resources.GetObject("logoutButton.Glyph")));
            this.logoutButton.Id = 8;
            this.logoutButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("logoutButton.LargeGlyph")));
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logoutButton_ItemClick);
            // 
            // editAccountButton
            // 
            this.editAccountButton.Caption = "EDIT INFO";
            this.editAccountButton.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.editAccountButton.Glyph = ((System.Drawing.Image)(resources.GetObject("editAccountButton.Glyph")));
            this.editAccountButton.Id = 10;
            this.editAccountButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editAccountButton.LargeGlyph")));
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editAccountButton_ItemClick);
            // 
            // productsStatisticsNumberButton
            // 
            this.productsStatisticsNumberButton.Caption = "PRODUCTS STATISTICS";
            this.productsStatisticsNumberButton.Glyph = ((System.Drawing.Image)(resources.GetObject("productsStatisticsNumberButton.Glyph")));
            this.productsStatisticsNumberButton.Id = 11;
            this.productsStatisticsNumberButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("productsStatisticsNumberButton.LargeGlyph")));
            this.productsStatisticsNumberButton.Name = "productsStatisticsNumberButton";
            this.productsStatisticsNumberButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.productsStatisticsNumberButton_ItemClick);
            // 
            // topNumberProductsButton
            // 
            this.topNumberProductsButton.Caption = "TOP SELLING PRODUCTS";
            this.topNumberProductsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("topNumberProductsButton.Glyph")));
            this.topNumberProductsButton.Id = 12;
            this.topNumberProductsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("topNumberProductsButton.LargeGlyph")));
            this.topNumberProductsButton.Name = "topNumberProductsButton";
            this.topNumberProductsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.topNumberProductsButton_ItemClick);
            // 
            // productsCantSaleButton
            // 
            this.productsCantSaleButton.Caption = "UNSELLABLE PRODUCTS";
            this.productsCantSaleButton.Glyph = ((System.Drawing.Image)(resources.GetObject("productsCantSaleButton.Glyph")));
            this.productsCantSaleButton.Id = 13;
            this.productsCantSaleButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("productsCantSaleButton.LargeGlyph")));
            this.productsCantSaleButton.Name = "productsCantSaleButton";
            this.productsCantSaleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.productsCantSaleButton_ItemClick);
            // 
            // priceStatisticsButton
            // 
            this.priceStatisticsButton.Caption = "PRICE STATISTICS";
            this.priceStatisticsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("priceStatisticsButton.Glyph")));
            this.priceStatisticsButton.Id = 14;
            this.priceStatisticsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("priceStatisticsButton.LargeGlyph")));
            this.priceStatisticsButton.Name = "priceStatisticsButton";
            this.priceStatisticsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.priceStatisticsButton_ItemClick);
            // 
            // topReveueProductsButton
            // 
            this.topReveueProductsButton.Caption = "TOP REVENUE PRODUCTS";
            this.topReveueProductsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("topReveueProductsButton.Glyph")));
            this.topReveueProductsButton.Id = 15;
            this.topReveueProductsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("topReveueProductsButton.LargeGlyph")));
            this.topReveueProductsButton.Name = "topReveueProductsButton";
            this.topReveueProductsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.topReveueProductsButton_ItemClick);
            // 
            // customerStatisticsButton
            // 
            this.customerStatisticsButton.Caption = "CUSTOMER STATISTICS";
            this.customerStatisticsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("customerStatisticsButton.Glyph")));
            this.customerStatisticsButton.Id = 16;
            this.customerStatisticsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("customerStatisticsButton.LargeGlyph")));
            this.customerStatisticsButton.Name = "customerStatisticsButton";
            this.customerStatisticsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customerStatisticsButton_ItemClick);
            // 
            // topCustomersButton
            // 
            this.topCustomersButton.Caption = "TOP CUSTOMERS";
            this.topCustomersButton.Glyph = ((System.Drawing.Image)(resources.GetObject("topCustomersButton.Glyph")));
            this.topCustomersButton.Id = 17;
            this.topCustomersButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("topCustomersButton.LargeGlyph")));
            this.topCustomersButton.Name = "topCustomersButton";
            this.topCustomersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.topCustomersButton_ItemClick);
            // 
            // employeeStatisticsButton
            // 
            this.employeeStatisticsButton.Caption = "EMPLOYEE STATISTICS";
            this.employeeStatisticsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("employeeStatisticsButton.Glyph")));
            this.employeeStatisticsButton.Id = 18;
            this.employeeStatisticsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("employeeStatisticsButton.LargeGlyph")));
            this.employeeStatisticsButton.Name = "employeeStatisticsButton";
            this.employeeStatisticsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.employeeStatisticsButton_ItemClick);
            // 
            // topEmployeeByProductsButton
            // 
            this.topEmployeeByProductsButton.Caption = "TOP EMPLOYEES";
            this.topEmployeeByProductsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("topEmployeeByProductsButton.Glyph")));
            this.topEmployeeByProductsButton.Id = 19;
            this.topEmployeeByProductsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("topEmployeeByProductsButton.LargeGlyph")));
            this.topEmployeeByProductsButton.Name = "topEmployeeByProductsButton";
            this.topEmployeeByProductsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.topEmployeeByProductsButton_ItemClick);
            // 
            // bottomEmployeesByProductsButton
            // 
            this.bottomEmployeesByProductsButton.Caption = "BOTTOM EMPLOYEES";
            this.bottomEmployeesByProductsButton.Glyph = ((System.Drawing.Image)(resources.GetObject("bottomEmployeesByProductsButton.Glyph")));
            this.bottomEmployeesByProductsButton.Id = 20;
            this.bottomEmployeesByProductsButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bottomEmployeesByProductsButton.LargeGlyph")));
            this.bottomEmployeesByProductsButton.Name = "bottomEmployeesByProductsButton";
            this.bottomEmployeesByProductsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bottomEmployeesByProductsButton_ItemClick);
            // 
            // employeeStatisticsPriceButton
            // 
            this.employeeStatisticsPriceButton.Caption = "EMPLOYEE STATISTICS";
            this.employeeStatisticsPriceButton.Glyph = ((System.Drawing.Image)(resources.GetObject("employeeStatisticsPriceButton.Glyph")));
            this.employeeStatisticsPriceButton.Id = 21;
            this.employeeStatisticsPriceButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("employeeStatisticsPriceButton.LargeGlyph")));
            this.employeeStatisticsPriceButton.Name = "employeeStatisticsPriceButton";
            this.employeeStatisticsPriceButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.employeeStatisticsPriceButton_ItemClick);
            // 
            // topSalersButton
            // 
            this.topSalersButton.Caption = "TOP EMPLOYEES";
            this.topSalersButton.Glyph = ((System.Drawing.Image)(resources.GetObject("topSalersButton.Glyph")));
            this.topSalersButton.Id = 22;
            this.topSalersButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("topSalersButton.LargeGlyph")));
            this.topSalersButton.Name = "topSalersButton";
            this.topSalersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.topSalersButton_ItemClick);
            // 
            // bottomSalersButton
            // 
            this.bottomSalersButton.Caption = "BOTTOM EMPLOYEES";
            this.bottomSalersButton.Glyph = ((System.Drawing.Image)(resources.GetObject("bottomSalersButton.Glyph")));
            this.bottomSalersButton.Id = 23;
            this.bottomSalersButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bottomSalersButton.LargeGlyph")));
            this.bottomSalersButton.Name = "bottomSalersButton";
            this.bottomSalersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bottomSalersButton_ItemClick);
            // 
            // listingPage
            // 
            this.listingPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.listingPageGroup});
            this.listingPage.Image = ((System.Drawing.Image)(resources.GetObject("listingPage.Image")));
            this.listingPage.Name = "listingPage";
            this.listingPage.Text = "LISTING";
            // 
            // listingPageGroup
            // 
            this.listingPageGroup.ItemLinks.Add(this.categoriesButton);
            this.listingPageGroup.ItemLinks.Add(this.productsButton);
            this.listingPageGroup.ItemLinks.Add(this.suppliersButton);
            this.listingPageGroup.ItemLinks.Add(this.customersButton);
            this.listingPageGroup.Name = "listingPageGroup";
            // 
            // reportPage
            // 
            this.reportPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.reportPageGroup,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.reportPage.Image = ((System.Drawing.Image)(resources.GetObject("reportPage.Image")));
            this.reportPage.Name = "reportPage";
            this.reportPage.Text = "REPORT";
            // 
            // reportPageGroup
            // 
            this.reportPageGroup.ItemLinks.Add(this.productsStatisticsNumberButton);
            this.reportPageGroup.ItemLinks.Add(this.topNumberProductsButton);
            this.reportPageGroup.ItemLinks.Add(this.productsCantSaleButton);
            this.reportPageGroup.Name = "reportPageGroup";
            this.reportPageGroup.Text = "PRODUCT STATISTICS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.priceStatisticsButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.topReveueProductsButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "PRICE STATISTICS";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.customerStatisticsButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.topCustomersButton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "CUSTOMER STATISTICS";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.employeeStatisticsButton);
            this.ribbonPageGroup3.ItemLinks.Add(this.topEmployeeByProductsButton);
            this.ribbonPageGroup3.ItemLinks.Add(this.bottomEmployeesByProductsButton);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "EMPLOYEE BY PRODUCTS";
            // 
            // accountPage
            // 
            this.accountPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.accountPageGroup});
            this.accountPage.Image = ((System.Drawing.Image)(resources.GetObject("accountPage.Image")));
            this.accountPage.Name = "accountPage";
            this.accountPage.Text = "ACCOUNT";
            // 
            // accountPageGroup
            // 
            this.accountPageGroup.ItemLinks.Add(this.editAccountButton);
            this.accountPageGroup.ItemLinks.Add(this.logoutButton);
            this.accountPageGroup.Name = "accountPageGroup";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1180, 31);
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.employeeStatisticsPriceButton);
            this.ribbonPageGroup4.ItemLinks.Add(this.topSalersButton);
            this.ribbonPageGroup4.ItemLinks.Add(this.bottomSalersButton);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "EMPLOYEES BY REVENUE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sale Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage listingPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup listingPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage reportPage;
        private DevExpress.XtraBars.BarButtonItem categoriesButton;
        private DevExpress.XtraBars.BarButtonItem productsButton;
        private DevExpress.XtraBars.BarButtonItem suppliersButton;
        private DevExpress.XtraBars.BarButtonItem customersButton;
        private DevExpress.XtraBars.BarButtonItem logoutButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage accountPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountPageGroup;
        private DevExpress.XtraBars.BarButtonItem editAccountButton;
        private DevExpress.XtraBars.BarButtonItem productsStatisticsNumberButton;
        private DevExpress.XtraBars.BarButtonItem topNumberProductsButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup reportPageGroup;
        private DevExpress.XtraBars.BarButtonItem productsCantSaleButton;
        private DevExpress.XtraBars.BarButtonItem priceStatisticsButton;
        private DevExpress.XtraBars.BarButtonItem topReveueProductsButton;
        private DevExpress.XtraBars.BarButtonItem customerStatisticsButton;
        private DevExpress.XtraBars.BarButtonItem topCustomersButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem employeeStatisticsButton;
        private DevExpress.XtraBars.BarButtonItem topEmployeeByProductsButton;
        private DevExpress.XtraBars.BarButtonItem bottomEmployeesByProductsButton;
        private DevExpress.XtraBars.BarButtonItem employeeStatisticsPriceButton;
        private DevExpress.XtraBars.BarButtonItem topSalersButton;
        private DevExpress.XtraBars.BarButtonItem bottomSalersButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}