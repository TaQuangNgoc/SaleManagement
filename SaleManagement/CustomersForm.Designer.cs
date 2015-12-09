namespace SaleManagement
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lastNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateOfBirthColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.insertButton = new DevExpress.XtraEditors.SimpleButton();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.titlePanel = new DevExpress.XtraEditors.PanelControl();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 45);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(770, 290);
            this.gridControl.TabIndex = 27;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
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
            this.lastNameColumn,
            this.customerIDColumn,
            this.firstNameColumn,
            this.addressColumn,
            this.phoneColumn,
            this.dateOfBirthColumn});
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
            // lastNameColumn
            // 
            this.lastNameColumn.Caption = "LASTNAME";
            this.lastNameColumn.FieldName = "LastName";
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.lastNameColumn.Visible = true;
            this.lastNameColumn.VisibleIndex = 0;
            this.lastNameColumn.Width = 210;
            // 
            // customerIDColumn
            // 
            this.customerIDColumn.Caption = "CUSTOMERSID";
            this.customerIDColumn.FieldName = "CustomerID";
            this.customerIDColumn.Name = "customerIDColumn";
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Caption = "FIRSTNAME";
            this.firstNameColumn.FieldName = "FirstName";
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.Visible = true;
            this.firstNameColumn.VisibleIndex = 1;
            this.firstNameColumn.Width = 132;
            // 
            // addressColumn
            // 
            this.addressColumn.Caption = "ADDRESS";
            this.addressColumn.FieldName = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.Visible = true;
            this.addressColumn.VisibleIndex = 2;
            this.addressColumn.Width = 132;
            // 
            // phoneColumn
            // 
            this.phoneColumn.Caption = "PHONE";
            this.phoneColumn.FieldName = "Phone";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.Visible = true;
            this.phoneColumn.VisibleIndex = 3;
            this.phoneColumn.Width = 132;
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.Caption = "DATE OF BIRTH";
            this.dateOfBirthColumn.FieldName = "DateOfBirth";
            this.dateOfBirthColumn.Name = "dateOfBirthColumn";
            this.dateOfBirthColumn.Visible = true;
            this.dateOfBirthColumn.VisibleIndex = 4;
            this.dateOfBirthColumn.Width = 139;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gridControl);
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Controls.Add(this.titlePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(774, 378);
            this.mainPanel.TabIndex = 33;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.insertButton);
            this.buttonsPanel.Controls.Add(this.updateButton);
            this.buttonsPanel.Controls.Add(this.deleteButton);
            this.buttonsPanel.Controls.Add(this.exitButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(2, 335);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Size = new System.Drawing.Size(770, 41);
            this.buttonsPanel.TabIndex = 29;
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
            this.insertButton.Location = new System.Drawing.Point(343, 4);
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
            this.updateButton.Location = new System.Drawing.Point(448, 4);
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
            this.deleteButton.Location = new System.Drawing.Point(553, 4);
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
            this.exitButton.Location = new System.Drawing.Point(667, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 33);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(770, 43);
            this.titlePanel.TabIndex = 30;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CUSTOMERS";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 378);
            this.Controls.Add(this.mainPanel);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn customerIDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressColumn;
        private DevExpress.XtraGrid.Columns.GridColumn phoneColumn;
        private DevExpress.XtraGrid.Columns.GridColumn dateOfBirthColumn;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        internal System.Windows.Forms.Panel buttonsPanel;
        private DevExpress.XtraEditors.SimpleButton insertButton;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.PanelControl titlePanel;
        private DevExpress.XtraEditors.LabelControl titleLabel;
    }
}