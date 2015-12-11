namespace SaleManagement
{
    partial class MaxEmployeeByNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxEmployeeByNumber));
            this.titlePanel = new DevExpress.XtraEditors.PanelControl();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.presentButton = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ngayBatDauDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ngayKetThucDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(904, 40);
            this.titlePanel.TabIndex = 36;
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(263, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "10 MAX EMPLOYEES BY NUMBER";
            // 
            // presentButton
            // 
            this.presentButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.presentButton.Image = ((System.Drawing.Image)(resources.GetObject("presentButton.Image")));
            this.presentButton.Location = new System.Drawing.Point(627, 5);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(87, 33);
            this.presentButton.TabIndex = 34;
            this.presentButton.Text = "Show";
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField1});
            this.pivotGridControl.Location = new System.Drawing.Point(2, 2);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.Size = new System.Drawing.Size(900, 236);
            this.pivotGridControl.TabIndex = 0;
            this.pivotGridControl.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl_CellDoubleClick);
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "Quantity";
            this.pivotGridField2.CellFormat.FormatString = "{c}";
            this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.pivotGridField2.FieldName = "Quantity";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Options.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridField2.Options.AllowSortBySummary = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridField2.SortBySummaryInfo.FieldName = "Quantity";
            this.pivotGridField2.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value;
            this.pivotGridField2.UnboundFieldName = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Employee";
            this.pivotGridField3.FieldName = "EmployeeName";
            this.pivotGridField3.MinWidth = 100;
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Width = 300;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "EmployeeID";
            this.pivotGridField1.FieldName = "EmployeeID";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Visible = false;
            // 
            // ngayBatDauDTPicker
            // 
            this.ngayBatDauDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayBatDauDTPicker.Location = new System.Drawing.Point(95, 9);
            this.ngayBatDauDTPicker.Name = "ngayBatDauDTPicker";
            this.ngayBatDauDTPicker.Size = new System.Drawing.Size(200, 20);
            this.ngayBatDauDTPicker.TabIndex = 1;
            // 
            // ngayKetThucDTPicker
            // 
            this.ngayKetThucDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayKetThucDTPicker.Location = new System.Drawing.Point(375, 9);
            this.ngayKetThucDTPicker.Name = "ngayKetThucDTPicker";
            this.ngayKetThucDTPicker.Size = new System.Drawing.Size(200, 20);
            this.ngayKetThucDTPicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "TO";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 85);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(908, 244);
            this.panelControl2.TabIndex = 44;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.pivotGridControl);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(904, 240);
            this.panelControl4.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.titlePanel);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(908, 85);
            this.panelControl1.TabIndex = 43;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.presentButton);
            this.panelControl3.Controls.Add(this.ngayBatDauDTPicker);
            this.panelControl3.Controls.Add(this.ngayKetThucDTPicker);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 39);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(904, 44);
            this.panelControl3.TabIndex = 35;
            // 
            // MaxEmployeeByNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 329);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "MaxEmployeeByNumber";
            this.Text = "MaxEmployeeByNumber";
            this.Load += new System.EventHandler(this.MaxEmployeeByNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePanel)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl titlePanel;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.XtraEditors.SimpleButton presentButton;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private System.Windows.Forms.DateTimePicker ngayBatDauDTPicker;
        private System.Windows.Forms.DateTimePicker ngayKetThucDTPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}