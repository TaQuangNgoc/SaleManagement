namespace SaleManagement
{
    partial class ProductsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsDetail));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.companyNameSLE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.categoryNameSLE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.unitsInStockTxt = new System.Windows.Forms.TextBox();
            this.unitPriceTxt = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.m_lbl_nghiep_vu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.BrowseButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameSLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameSLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.companyNameSLE);
            this.groupControl1.Controls.Add(this.categoryNameSLE);
            this.groupControl1.Controls.Add(this.unitsInStockTxt);
            this.groupControl1.Controls.Add(this.unitPriceTxt);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.productNameTxt);
            this.groupControl1.Controls.Add(this.m_lbl_nghiep_vu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(715, 385);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Product Detail";
            // 
            // companyNameSLE
            // 
            this.companyNameSLE.EditValue = "";
            this.companyNameSLE.Location = new System.Drawing.Point(122, 126);
            this.companyNameSLE.Name = "companyNameSLE";
            this.companyNameSLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companyNameSLE.Properties.DisplayMember = "CompanyName";
            this.companyNameSLE.Properties.ValueMember = "SupplierID";
            this.companyNameSLE.Properties.View = this.searchLookUpEdit1View;
            this.companyNameSLE.Size = new System.Drawing.Size(258, 20);
            this.companyNameSLE.TabIndex = 19;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // categoryNameSLE
            // 
            this.categoryNameSLE.EditValue = "";
            this.categoryNameSLE.Location = new System.Drawing.Point(122, 196);
            this.categoryNameSLE.Name = "categoryNameSLE";
            this.categoryNameSLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryNameSLE.Properties.DisplayMember = "CategoryName";
            this.categoryNameSLE.Properties.ValueMember = "CategoryID";
            this.categoryNameSLE.Properties.View = this.gridView1;
            this.categoryNameSLE.Size = new System.Drawing.Size(258, 20);
            this.categoryNameSLE.TabIndex = 19;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // unitsInStockTxt
            // 
            this.unitsInStockTxt.Location = new System.Drawing.Point(122, 336);
            this.unitsInStockTxt.Name = "unitsInStockTxt";
            this.unitsInStockTxt.Size = new System.Drawing.Size(258, 20);
            this.unitsInStockTxt.TabIndex = 18;
            // 
            // unitPriceTxt
            // 
            this.unitPriceTxt.Location = new System.Drawing.Point(122, 268);
            this.unitPriceTxt.Name = "unitPriceTxt";
            this.unitPriceTxt.Size = new System.Drawing.Size(258, 20);
            this.unitPriceTxt.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 339);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Units In Stock";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 271);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Unit Price";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 199);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Category Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 129);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Company Name";
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(122, 59);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(258, 20);
            this.productNameTxt.TabIndex = 12;
            // 
            // m_lbl_nghiep_vu
            // 
            this.m_lbl_nghiep_vu.Location = new System.Drawing.Point(12, 62);
            this.m_lbl_nghiep_vu.Name = "m_lbl_nghiep_vu";
            this.m_lbl_nghiep_vu.Size = new System.Drawing.Size(67, 13);
            this.m_lbl_nghiep_vu.TabIndex = 4;
            this.m_lbl_nghiep_vu.Text = "Product Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 13);
            this.labelControl3.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.exitButton);
            this.panelControl2.Controls.Add(this.saveButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 385);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(715, 51);
            this.panelControl2.TabIndex = 10;
            // 
            // exitButton
            // 
            this.exitButton.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.exitButton.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.exitButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.exitButton.Appearance.Options.UseBackColor = true;
            this.exitButton.Appearance.Options.UseBorderColor = true;
            this.exitButton.Appearance.Options.UseForeColor = true;
            this.exitButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(503, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 41);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.saveButton.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.saveButton.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.saveButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.saveButton.Appearance.Options.UseBackColor = true;
            this.saveButton.Appearance.Options.UseBorderColor = true;
            this.saveButton.Appearance.Options.UseForeColor = true;
            this.saveButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(71, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 41);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(25, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(216, 211);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BrowseButton.Location = new System.Drawing.Point(61, 0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(142, 38);
            this.BrowseButton.TabIndex = 21;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "SupplierID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "COMPANY NAME";
            this.gridColumn3.FieldName = "CompanyName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CATEGORY NAME";
            this.gridColumn6.FieldName = "CategoryName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CategoryID";
            this.gridColumn2.FieldName = "CategoryID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureBox);
            this.groupControl2.Controls.Add(this.BrowseButton);
            this.groupControl2.Location = new System.Drawing.Point(426, 59);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(263, 297);
            this.groupControl2.TabIndex = 22;
            this.groupControl2.Text = "Picture";
            // 
            // ProductsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 436);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "ProductsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsDetail";
            this.Load += new System.EventHandler(this.ProductsDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameSLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameSLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox productNameTxt;
        private DevExpress.XtraEditors.LabelControl m_lbl_nghiep_vu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit companyNameSLE;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TextBox unitsInStockTxt;
        private System.Windows.Forms.TextBox unitPriceTxt;
        private DevExpress.XtraEditors.SearchLookUpEdit categoryNameSLE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton BrowseButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}