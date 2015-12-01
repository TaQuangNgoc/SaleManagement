namespace SaleManagement
{
    partial class SuppliersDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersDetail));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CompanyNameTxt = new System.Windows.Forms.TextBox();
            this.m_lbl_nghiep_vu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.AddressTxt);
            this.groupControl1.Controls.Add(this.PhoneTxt);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.CompanyNameTxt);
            this.groupControl1.Controls.Add(this.m_lbl_nghiep_vu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(412, 223);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Supplier Detail";
            // 
            // CompanyNameTxt
            // 
            this.CompanyNameTxt.Location = new System.Drawing.Point(138, 61);
            this.CompanyNameTxt.Name = "CompanyNameTxt";
            this.CompanyNameTxt.Size = new System.Drawing.Size(231, 20);
            this.CompanyNameTxt.TabIndex = 12;
            // 
            // m_lbl_nghiep_vu
            // 
            this.m_lbl_nghiep_vu.Location = new System.Drawing.Point(22, 64);
            this.m_lbl_nghiep_vu.Name = "m_lbl_nghiep_vu";
            this.m_lbl_nghiep_vu.Size = new System.Drawing.Size(75, 13);
            this.m_lbl_nghiep_vu.TabIndex = 4;
            this.m_lbl_nghiep_vu.Text = "Company Name";
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
            this.panelControl2.Location = new System.Drawing.Point(0, 223);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(412, 51);
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
            this.exitButton.Location = new System.Drawing.Point(271, 5);
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
            this.saveButton.Location = new System.Drawing.Point(22, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 41);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Phone";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Address";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(138, 106);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(231, 20);
            this.PhoneTxt.TabIndex = 15;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(138, 151);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(231, 20);
            this.AddressTxt.TabIndex = 16;
            // 
            // SuppliersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 274);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "SuppliersDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppliersDetail";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox CompanyNameTxt;
        private DevExpress.XtraEditors.LabelControl m_lbl_nghiep_vu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}