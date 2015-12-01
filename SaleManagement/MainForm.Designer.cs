﻿namespace SaleManagement
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m_cmd_thong_tin = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nguyen_vong = new DevExpress.XtraBars.BarButtonItem();
            this.m_btn_report = new DevExpress.XtraBars.BarButtonItem();
            this.categoriesButton = new DevExpress.XtraBars.BarButtonItem();
            this.productsButton = new DevExpress.XtraBars.BarButtonItem();
            this.suppliersButton = new DevExpress.XtraBars.BarButtonItem();
            this.customersButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.m_cmd_thong_tin,
            this.m_cmd_nguyen_vong,
            this.m_btn_report,
            this.categoriesButton,
            this.productsButton,
            this.suppliersButton,
            this.customersButton});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(993, 163);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // m_cmd_thong_tin
            // 
            this.m_cmd_thong_tin.Caption = "CATEGORIES";
            this.m_cmd_thong_tin.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thong_tin.Glyph")));
            this.m_cmd_thong_tin.Id = 1;
            this.m_cmd_thong_tin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thong_tin.LargeGlyph")));
            this.m_cmd_thong_tin.LargeWidth = 100;
            this.m_cmd_thong_tin.Name = "m_cmd_thong_tin";
            // 
            // m_cmd_nguyen_vong
            // 
            this.m_cmd_nguyen_vong.Caption = "THÔNG TIN NGUYỆN VỌNG";
            this.m_cmd_nguyen_vong.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nguyen_vong.Glyph")));
            this.m_cmd_nguyen_vong.Id = 2;
            this.m_cmd_nguyen_vong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nguyen_vong.LargeGlyph")));
            this.m_cmd_nguyen_vong.LargeWidth = 100;
            this.m_cmd_nguyen_vong.Name = "m_cmd_nguyen_vong";
            // 
            // m_btn_report
            // 
            this.m_btn_report.Caption = "Kết quả xét tuyển";
            this.m_btn_report.Glyph = ((System.Drawing.Image)(resources.GetObject("m_btn_report.Glyph")));
            this.m_btn_report.Id = 3;
            this.m_btn_report.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_btn_report.LargeGlyph")));
            this.m_btn_report.LargeWidth = 100;
            this.m_btn_report.Name = "m_btn_report";
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.DanhMuc});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "LISTING";
            // 
            // DanhMuc
            // 
            this.DanhMuc.ItemLinks.Add(this.categoriesButton);
            this.DanhMuc.ItemLinks.Add(this.productsButton);
            this.DanhMuc.ItemLinks.Add(this.suppliersButton);
            this.DanhMuc.ItemLinks.Add(this.customersButton);
            this.DanhMuc.Name = "DanhMuc";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "REPORT";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(993, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sale Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem m_cmd_thong_tin;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nguyen_vong;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem m_btn_report;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem categoriesButton;
        private DevExpress.XtraBars.BarButtonItem productsButton;
        private DevExpress.XtraBars.BarButtonItem suppliersButton;
        private DevExpress.XtraBars.BarButtonItem customersButton;
    }
}