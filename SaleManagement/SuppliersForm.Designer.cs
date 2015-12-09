namespace SaleManagement
{
    partial class SuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.insertButton = new DevExpress.XtraEditors.SimpleButton();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.supplierIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.companyNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.titlePanel = new DevExpress.XtraEditors.PanelControl();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(93, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SUPPLIERS";
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
            this.insertButton.Location = new System.Drawing.Point(213, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(105, 33);
            this.insertButton.TabIndex = 24;
            this.insertButton.Text = "Insert";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
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
            this.updateButton.Location = new System.Drawing.Point(318, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 33);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            this.deleteButton.Location = new System.Drawing.Point(423, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 33);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delele";
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
            this.exitButton.Location = new System.Drawing.Point(537, 4);
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
            this.buttonsPanel.Location = new System.Drawing.Point(2, 319);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Size = new System.Drawing.Size(640, 41);
            this.buttonsPanel.TabIndex = 29;
            // 
            // supplierIDColumn
            // 
            this.supplierIDColumn.Caption = "SuppliersID";
            this.supplierIDColumn.FieldName = "SupplierID";
            this.supplierIDColumn.Name = "supplierIDColumn";
            // 
            // gridView
            // 
            this.gridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.Empty.Options.UseBackColor = true;
            this.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView.Appearance.Preview.Options.UseFont = true;
            this.gridView.Appearance.Preview.Options.UseForeColor = true;
            this.gridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.Row.Options.UseBackColor = true;
            this.gridView.Appearance.Row.Options.UseForeColor = true;
            this.gridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.companyNameColumn,
            this.supplierIDColumn,
            this.phoneColumn,
            this.addressColumn});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 50;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.PaintStyleName = "Flat";
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // companyNameColumn
            // 
            this.companyNameColumn.Caption = "COMPANY NAME";
            this.companyNameColumn.FieldName = "CompanyName";
            this.companyNameColumn.Name = "companyNameColumn";
            this.companyNameColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.companyNameColumn.Visible = true;
            this.companyNameColumn.VisibleIndex = 0;
            this.companyNameColumn.Width = 134;
            // 
            // phoneColumn
            // 
            this.phoneColumn.Caption = "PHONE";
            this.phoneColumn.FieldName = "Phone";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.Visible = true;
            this.phoneColumn.VisibleIndex = 1;
            this.phoneColumn.Width = 176;
            // 
            // addressColumn
            // 
            this.addressColumn.Caption = "ADDRESS";
            this.addressColumn.FieldName = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.Visible = true;
            this.addressColumn.VisibleIndex = 2;
            this.addressColumn.Width = 229;
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 45);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(640, 274);
            this.gridControl.TabIndex = 27;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gridControl);
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Controls.Add(this.titlePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(644, 362);
            this.mainPanel.TabIndex = 32;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(640, 43);
            this.titlePanel.TabIndex = 30;
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 362);
            this.Controls.Add(this.mainPanel);
            this.Name = "SuppliersForm";
            this.Text = "Suppliers";
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.XtraEditors.SimpleButton insertButton;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        internal System.Windows.Forms.Panel buttonsPanel;
        private DevExpress.XtraGrid.Columns.GridColumn supplierIDColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn companyNameColumn;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PanelControl titlePanel;
        private DevExpress.XtraGrid.Columns.GridColumn phoneColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressColumn;
    }
}