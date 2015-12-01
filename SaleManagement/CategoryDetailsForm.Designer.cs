namespace SaleManagement
{
    partial class CategoryDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryDetailsForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.m_lbl_nghiep_vu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_huy = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.descriptionTxt);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.categoryTxt);
            this.groupControl1.Controls.Add(this.m_lbl_nghiep_vu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 250);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Category Detail";
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(138, 54);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(435, 20);
            this.categoryTxt.TabIndex = 12;
            // 
            // m_lbl_nghiep_vu
            // 
            this.m_lbl_nghiep_vu.Location = new System.Drawing.Point(29, 57);
            this.m_lbl_nghiep_vu.Name = "m_lbl_nghiep_vu";
            this.m_lbl_nghiep_vu.Size = new System.Drawing.Size(75, 13);
            this.m_lbl_nghiep_vu.TabIndex = 4;
            this.m_lbl_nghiep_vu.Text = "Category Name";
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
            this.panelControl2.Controls.Add(this.m_cmd_huy);
            this.panelControl2.Controls.Add(this.m_cmd_luu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 250);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(621, 51);
            this.panelControl2.TabIndex = 8;
            // 
            // m_cmd_huy
            // 
            this.m_cmd_huy.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.m_cmd_huy.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.m_cmd_huy.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.m_cmd_huy.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_huy.Appearance.Options.UseBackColor = true;
            this.m_cmd_huy.Appearance.Options.UseBorderColor = true;
            this.m_cmd_huy.Appearance.Options.UseForeColor = true;
            this.m_cmd_huy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_cmd_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cmd_huy.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_huy.Image")));
            this.m_cmd_huy.Location = new System.Drawing.Point(475, 5);
            this.m_cmd_huy.Name = "m_cmd_huy";
            this.m_cmd_huy.Size = new System.Drawing.Size(98, 41);
            this.m_cmd_huy.TabIndex = 1;
            this.m_cmd_huy.Text = "Exit";
            this.m_cmd_huy.Click += new System.EventHandler(this.m_cmd_huy_Click);
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.m_cmd_luu.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.m_cmd_luu.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.m_cmd_luu.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_luu.Appearance.Options.UseBackColor = true;
            this.m_cmd_luu.Appearance.Options.UseBorderColor = true;
            this.m_cmd_luu.Appearance.Options.UseForeColor = true;
            this.m_cmd_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(76, 5);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(98, 41);
            this.m_cmd_luu.TabIndex = 0;
            this.m_cmd_luu.Text = "Save";
            this.m_cmd_luu.Click += new System.EventHandler(this.m_cmd_luu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Description";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(138, 99);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(435, 105);
            this.descriptionTxt.TabIndex = 14;
            // 
            // CategoriesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 301);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "CategoriesDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesDetail";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox categoryTxt;
        private DevExpress.XtraEditors.LabelControl m_lbl_nghiep_vu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_huy;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private System.Windows.Forms.TextBox descriptionTxt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}