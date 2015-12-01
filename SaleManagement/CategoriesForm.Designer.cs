namespace SaleManagement
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.Grc = new DevExpress.XtraGrid.GridControl();
            this.Grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.insertButton = new DevExpress.XtraEditors.SimpleButton();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.m_pnl_out_place_dm);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(652, 326);
            this.panelControl1.TabIndex = 31;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 45);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(648, 238);
            this.panelControl3.TabIndex = 31;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.Grc);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(644, 234);
            this.panelControl4.TabIndex = 31;
            // 
            // Grc
            // 
            this.Grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grc.Location = new System.Drawing.Point(2, 2);
            this.Grc.MainView = this.Grv;
            this.Grc.Name = "Grc";
            this.Grc.Size = new System.Drawing.Size(640, 230);
            this.Grc.TabIndex = 27;
            this.Grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grv});
            // 
            // Grv
            // 
            this.Grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn1});
            this.Grv.GridControl = this.Grc;
            this.Grv.Name = "Grv";
            this.Grv.OptionsBehavior.Editable = false;
            this.Grv.OptionsSelection.MultiSelect = true;
            this.Grv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "CATEGORIES";
            this.gridColumn3.FieldName = "CategoryName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 293;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CategoryID";
            this.gridColumn6.FieldName = "CategoryID";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.insertButton);
            this.m_pnl_out_place_dm.Controls.Add(this.updateButton);
            this.m_pnl_out_place_dm.Controls.Add(this.deleteButton);
            this.m_pnl_out_place_dm.Controls.Add(this.exitButton);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(2, 283);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(648, 41);
            this.m_pnl_out_place_dm.TabIndex = 29;
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
            this.insertButton.Location = new System.Drawing.Point(221, 4);
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
            this.updateButton.Location = new System.Drawing.Point(326, 4);
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
            this.deleteButton.Location = new System.Drawing.Point(431, 4);
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
            this.exitButton.Location = new System.Drawing.Point(545, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 33);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(648, 43);
            this.panelControl2.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CATEGORIES";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "");
            this.imageList2.Images.SetKeyName(11, "");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            this.imageList2.Images.SetKeyName(14, "");
            this.imageList2.Images.SetKeyName(15, "");
            this.imageList2.Images.SetKeyName(16, "");
            this.imageList2.Images.SetKeyName(17, "");
            this.imageList2.Images.SetKeyName(18, "");
            this.imageList2.Images.SetKeyName(19, "");
            this.imageList2.Images.SetKeyName(20, "");
            this.imageList2.Images.SetKeyName(21, "");
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Desciption";
            this.gridColumn1.FieldName = "Description";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 326);
            this.Controls.Add(this.panelControl1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grv)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl Grc;
        private DevExpress.XtraGrid.Views.Grid.GridView Grv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton insertButton;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}