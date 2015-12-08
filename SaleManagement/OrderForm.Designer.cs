namespace SaleManagement
{
    partial class OrderForm
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
            this.companyNameSLE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl_nghiep_vu = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.unitPriceTxt = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.unitsInStockTxt = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Grc = new DevExpress.XtraGrid.GridControl();
            this.Grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameSLE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // companyNameSLE
            // 
            this.companyNameSLE.EditValue = "";
            this.companyNameSLE.Location = new System.Drawing.Point(105, 24);
            this.companyNameSLE.Name = "companyNameSLE";
            this.companyNameSLE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companyNameSLE.Properties.DisplayMember = "CompanyName";
            this.companyNameSLE.Properties.ValueMember = "SupplierID";
            this.companyNameSLE.Properties.View = this.searchLookUpEdit1View;
            this.companyNameSLE.Size = new System.Drawing.Size(258, 20);
            this.companyNameSLE.TabIndex = 20;
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
            // m_lbl_nghiep_vu
            // 
            this.m_lbl_nghiep_vu.Location = new System.Drawing.Point(22, 31);
            this.m_lbl_nghiep_vu.Name = "m_lbl_nghiep_vu";
            this.m_lbl_nghiep_vu.Size = new System.Drawing.Size(67, 13);
            this.m_lbl_nghiep_vu.TabIndex = 21;
            this.m_lbl_nghiep_vu.Text = "Product Name";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.pictureBox);
            this.groupControl1.Controls.Add(this.unitsInStockTxt);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.m_lbl_nghiep_vu);
            this.groupControl1.Controls.Add(this.unitPriceTxt);
            this.groupControl1.Controls.Add(this.companyNameSLE);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(27, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 200);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 69);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Unit Price";
            // 
            // unitPriceTxt
            // 
            this.unitPriceTxt.Location = new System.Drawing.Point(105, 66);
            this.unitPriceTxt.Name = "unitPriceTxt";
            this.unitPriceTxt.Size = new System.Drawing.Size(258, 20);
            this.unitPriceTxt.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 119);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Units In Stock";
            // 
            // unitsInStockTxt
            // 
            this.unitsInStockTxt.Location = new System.Drawing.Point(105, 112);
            this.unitsInStockTxt.Name = "unitsInStockTxt";
            this.unitsInStockTxt.Size = new System.Drawing.Size(258, 20);
            this.unitsInStockTxt.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Grc);
            this.groupControl2.Location = new System.Drawing.Point(25, 258);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(804, 238);
            this.groupControl2.TabIndex = 23;
            this.groupControl2.Text = "Order Detail";
            // 
            // Grc
            // 
            this.Grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grc.Location = new System.Drawing.Point(2, 21);
            this.Grc.MainView = this.Grv;
            this.Grc.Name = "Grc";
            this.Grc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.Grc.Size = new System.Drawing.Size(800, 215);
            this.Grc.TabIndex = 28;
            this.Grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grv});
            // 
            // Grv
            // 
            this.Grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn5,
            this.UnitPrice,
            this.gridColumn4,
            this.gridColumn7});
            this.Grv.GridControl = this.Grc;
            this.Grv.Name = "Grv";
            this.Grv.OptionsBehavior.Editable = false;
            this.Grv.OptionsSelection.MultiSelect = true;
            this.Grv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PRODUCT NAME";
            this.gridColumn2.FieldName = "ProductName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 293;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "PRODUCTID";
            this.gridColumn6.FieldName = "ProductID";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "QUANTITY";
            this.gridColumn5.FieldName = "Quantity";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Caption = "UNIT PRICE";
            this.UnitPrice.DisplayFormat.FormatString = "{c}";
            this.UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UnitPrice.FieldName = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = true;
            this.UnitPrice.VisibleIndex = 4;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(393, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(155, 150);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "DISCOUNT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 161);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Discount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 24;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(27, 218);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Add to Order";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SIMPLE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 530);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.companyNameSLE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit companyNameSLE;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl m_lbl_nghiep_vu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox unitPriceTxt;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox unitsInStockTxt;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Grc;
        private DevExpress.XtraGrid.Views.Grid.GridView Grv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}