namespace SaleManagement.Report
{
    partial class MaxCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxCustomers));
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.titlePanel = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.presentButton = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ngayKetThucDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ngayBatDauDTPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MONEY";
            this.gridColumn2.DisplayFormat.FormatString = "c";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn2.FieldName = "CustomerMoney";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "PHONE";
            this.gridColumn1.FieldName = "Phone";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // c2
            // 
            this.c2.Caption = "LAST NAME";
            this.c2.FieldName = "LastName";
            this.c2.Name = "c2";
            this.c2.Visible = true;
            this.c2.VisibleIndex = 0;
            this.c2.Width = 323;
            // 
            // C1
            // 
            this.C1.Caption = "FIRST NAME";
            this.C1.FieldName = "FirstName";
            this.C1.Name = "C1";
            this.C1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.C1.Visible = true;
            this.C1.VisibleIndex = 1;
            this.C1.Width = 300;
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
            this.C1,
            this.c2,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 50;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.PaintStyleName = "Flat";
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 87);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(820, 259);
            this.gridControl.TabIndex = 27;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gridControl);
            this.mainPanel.Controls.Add(this.titlePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(824, 348);
            this.mainPanel.TabIndex = 34;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.panelControl2);
            this.titlePanel.Controls.Add(this.panelControl1);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(820, 85);
            this.titlePanel.TabIndex = 30;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.titleLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(816, 33);
            this.panelControl2.TabIndex = 36;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(34, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(165, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "10 MAX CUSTOMERS";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.presentButton);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.ngayKetThucDTPicker);
            this.panelControl1.Controls.Add(this.ngayBatDauDTPicker);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(816, 55);
            this.panelControl1.TabIndex = 35;
            // 
            // presentButton
            // 
            this.presentButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.presentButton.Image = ((System.Drawing.Image)(resources.GetObject("presentButton.Image")));
            this.presentButton.Location = new System.Drawing.Point(676, 12);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(87, 33);
            this.presentButton.TabIndex = 34;
            this.presentButton.Text = "Show";
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "TO";
            // 
            // ngayKetThucDTPicker
            // 
            this.ngayKetThucDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayKetThucDTPicker.Location = new System.Drawing.Point(415, 16);
            this.ngayKetThucDTPicker.Name = "ngayKetThucDTPicker";
            this.ngayKetThucDTPicker.Size = new System.Drawing.Size(200, 20);
            this.ngayKetThucDTPicker.TabIndex = 2;
            // 
            // ngayBatDauDTPicker
            // 
            this.ngayBatDauDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayBatDauDTPicker.Location = new System.Drawing.Point(103, 17);
            this.ngayBatDauDTPicker.Name = "ngayBatDauDTPicker";
            this.ngayBatDauDTPicker.Size = new System.Drawing.Size(200, 20);
            this.ngayBatDauDTPicker.TabIndex = 1;
            // 
            // MaxCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 348);
            this.Controls.Add(this.mainPanel);
            this.Name = "MaxCustomers";
            this.Text = "MaxCustomers";
            this.Load += new System.EventHandler(this.MaxCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).EndInit();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn c2;
        private DevExpress.XtraGrid.Columns.GridColumn C1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PanelControl titlePanel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton presentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ngayKetThucDTPicker;
        private System.Windows.Forms.DateTimePicker ngayBatDauDTPicker;

    }
}