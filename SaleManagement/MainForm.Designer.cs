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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.categoriesButton = new DevExpress.XtraBars.BarButtonItem();
            this.productsButton = new DevExpress.XtraBars.BarButtonItem();
            this.suppliersButton = new DevExpress.XtraBars.BarButtonItem();
            this.customersButton = new DevExpress.XtraBars.BarButtonItem();
            this.listingPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.listingPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.reportPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.reportPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.accountPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.logoutButton = new DevExpress.XtraBars.BarButtonItem();
            this.accountPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.logoutButton});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 9;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.listingPage,
            this.reportPage,
            this.accountPage});
            this.ribbonControl.Size = new System.Drawing.Size(993, 163);
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
            this.reportPageGroup});
            this.reportPage.Image = ((System.Drawing.Image)(resources.GetObject("reportPage.Image")));
            this.reportPage.Name = "reportPage";
            this.reportPage.Text = "REPORT";
            // 
            // reportPageGroup
            // 
            this.reportPageGroup.Name = "reportPageGroup";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(993, 31);
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // accountPage
            // 
            this.accountPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.accountPageGroup});
            this.accountPage.Name = "accountPage";
            this.accountPage.Text = "ACCOUNT";
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
            // accountPageGroup
            // 
            this.accountPageGroup.ItemLinks.Add(this.logoutButton);
            this.accountPageGroup.Name = "accountPageGroup";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 449);
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup reportPageGroup;
        private DevExpress.XtraBars.BarButtonItem categoriesButton;
        private DevExpress.XtraBars.BarButtonItem productsButton;
        private DevExpress.XtraBars.BarButtonItem suppliersButton;
        private DevExpress.XtraBars.BarButtonItem customersButton;
        private DevExpress.XtraBars.BarButtonItem logoutButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage accountPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountPageGroup;
    }
}