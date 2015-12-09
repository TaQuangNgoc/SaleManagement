namespace SaleManagement
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.cardView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.productNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.companyNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPriceColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitsInStockColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.titlePanel = new DevExpress.XtraEditors.PanelControl();
            this.insertButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 45);
            this.gridControl.MainView = this.cardView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(853, 288);
            this.gridControl.TabIndex = 27;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView});
            // 
            // cardView
            // 
            this.cardView.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.cardView.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.cardView.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView.Appearance.CardCaption.Options.UseBackColor = true;
            this.cardView.Appearance.CardCaption.Options.UseBorderColor = true;
            this.cardView.Appearance.CardCaption.Options.UseForeColor = true;
            this.cardView.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cardView.Appearance.EmptySpace.BackColor2 = System.Drawing.Color.White;
            this.cardView.Appearance.EmptySpace.Options.UseBackColor = true;
            this.cardView.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardView.Appearance.FieldCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardView.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.cardView.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardView.Appearance.FieldCaption.Options.UseBorderColor = true;
            this.cardView.Appearance.FieldCaption.Options.UseForeColor = true;
            this.cardView.Appearance.FieldValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardView.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.cardView.Appearance.FieldValue.Options.UseBackColor = true;
            this.cardView.Appearance.FieldValue.Options.UseForeColor = true;
            this.cardView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.cardView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.cardView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.cardView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.cardView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cardView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.cardView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.cardView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardView.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.cardView.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.cardView.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.cardView.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardView.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.cardView.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.cardView.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.cardView.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cardView.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.cardView.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardView.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.cardView.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.cardView.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardView.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.cardView.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.cardView.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.cardView.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardView.CardCaptionFormat = "{1}";
            this.cardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.productNameColumn,
            this.productIDColumn,
            this.companyNameColumn,
            this.categoryNameColumn,
            this.unitPriceColumn,
            this.unitsInStockColumn,
            this.pictureColumn});
            this.cardView.DetailHeight = 500;
            this.cardView.FocusedCardTopFieldIndex = 0;
            this.cardView.GridControl = this.gridControl;
            this.cardView.MaximumCardColumns = 3;
            this.cardView.MaximumCardRows = 2;
            this.cardView.Name = "cardView";
            this.cardView.OptionsBehavior.AutoHorzWidth = true;
            this.cardView.OptionsBehavior.Editable = false;
            this.cardView.OptionsBehavior.FieldAutoHeight = true;
            this.cardView.PaintStyleName = "Flat";
            this.cardView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView.DoubleClick += new System.EventHandler(this.cardView_DoubleClick);
            // 
            // productNameColumn
            // 
            this.productNameColumn.Caption = "PRODUCTNAME";
            this.productNameColumn.FieldName = "ProductName";
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.productNameColumn.Width = 293;
            // 
            // productIDColumn
            // 
            this.productIDColumn.Caption = "PRODUCTID";
            this.productIDColumn.FieldName = "ProductID";
            this.productIDColumn.Name = "productIDColumn";
            this.productIDColumn.Visible = true;
            this.productIDColumn.VisibleIndex = 0;
            // 
            // companyNameColumn
            // 
            this.companyNameColumn.Caption = "COMPANY NAME";
            this.companyNameColumn.FieldName = "CompanyName";
            this.companyNameColumn.Name = "companyNameColumn";
            this.companyNameColumn.Visible = true;
            this.companyNameColumn.VisibleIndex = 1;
            // 
            // categoryNameColumn
            // 
            this.categoryNameColumn.Caption = "CATEGORY NAME";
            this.categoryNameColumn.FieldName = "CategoryName";
            this.categoryNameColumn.Name = "categoryNameColumn";
            this.categoryNameColumn.Visible = true;
            this.categoryNameColumn.VisibleIndex = 2;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.Caption = "UNIT PRICE";
            this.unitPriceColumn.DisplayFormat.FormatString = "{c}";
            this.unitPriceColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.unitPriceColumn.FieldName = "UnitPrice";
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.Visible = true;
            this.unitPriceColumn.VisibleIndex = 3;
            // 
            // unitsInStockColumn
            // 
            this.unitsInStockColumn.Caption = "UNITS IN STOCK";
            this.unitsInStockColumn.FieldName = "UnitsInStock";
            this.unitsInStockColumn.Name = "unitsInStockColumn";
            this.unitsInStockColumn.Visible = true;
            this.unitsInStockColumn.VisibleIndex = 4;
            // 
            // pictureColumn
            // 
            this.pictureColumn.Caption = "PICTURE";
            this.pictureColumn.ColumnEdit = this.repositoryItemPictureEdit1;
            this.pictureColumn.FieldName = "Picture";
            this.pictureColumn.Name = "pictureColumn";
            this.pictureColumn.Visible = true;
            this.pictureColumn.VisibleIndex = 5;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PRODUCTS";
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(853, 43);
            this.titlePanel.TabIndex = 30;
            // 
            // insertButton
            // 
            this.insertButton.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.insertButton.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.insertButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.insertButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.insertButton.Appearance.Options.UseBackColor = true;
            this.insertButton.Appearance.Options.UseBorderColor = true;
            this.insertButton.Appearance.Options.UseForeColor = true;
            this.insertButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.insertButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.insertButton.Image = ((System.Drawing.Image)(resources.GetObject("insertButton.Image")));
            this.insertButton.Location = new System.Drawing.Point(426, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(105, 33);
            this.insertButton.TabIndex = 24;
            this.insertButton.Text = "Insert";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.deleteButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Appearance.Options.UseBackColor = true;
            this.deleteButton.Appearance.Options.UseBorderColor = true;
            this.deleteButton.Appearance.Options.UseForeColor = true;
            this.deleteButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(636, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 33);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.exitButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.exitButton.Appearance.Options.UseBackColor = true;
            this.exitButton.Appearance.Options.UseBorderColor = true;
            this.exitButton.Appearance.Options.UseForeColor = true;
            this.exitButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(750, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 33);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.insertButton);
            this.buttonsPanel.Controls.Add(this.updateButton);
            this.buttonsPanel.Controls.Add(this.deleteButton);
            this.buttonsPanel.Controls.Add(this.exitButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(2, 333);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Size = new System.Drawing.Size(853, 41);
            this.buttonsPanel.TabIndex = 29;
            // 
            // updateButton
            // 
            this.updateButton.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.updateButton.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.updateButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.updateButton.Appearance.ForeColor = System.Drawing.Color.White;
            this.updateButton.Appearance.Options.UseBackColor = true;
            this.updateButton.Appearance.Options.UseBorderColor = true;
            this.updateButton.Appearance.Options.UseForeColor = true;
            this.updateButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(531, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 33);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gridControl);
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Controls.Add(this.titlePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(857, 376);
            this.mainPanel.TabIndex = 32;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 376);
            this.Controls.Add(this.mainPanel);
            this.Name = "ProductsForm";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.XtraEditors.PanelControl titlePanel;
        private DevExpress.XtraEditors.SimpleButton insertButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        internal System.Windows.Forms.Panel buttonsPanel;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView;
        private DevExpress.XtraGrid.Columns.GridColumn productNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn productIDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn companyNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn categoryNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn unitPriceColumn;
        private DevExpress.XtraGrid.Columns.GridColumn unitsInStockColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pictureColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.PanelControl mainPanel;
    }
}