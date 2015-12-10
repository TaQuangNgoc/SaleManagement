namespace SaleManagement
{
    partial class AccountDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailsForm));
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new DevExpress.XtraEditors.LabelControl();
            this.phoneLabel = new DevExpress.XtraEditors.LabelControl();
            this.addressLabel = new DevExpress.XtraEditors.LabelControl();
            this.firstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.buttonsPanel = new DevExpress.XtraEditors.PanelControl();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsPanel)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.usernameTextBox);
            this.groupControl.Controls.Add(this.phoneTextBox);
            this.groupControl.Controls.Add(this.addressTextBox);
            this.groupControl.Controls.Add(this.firstNameTextBox);
            this.groupControl.Controls.Add(this.lastNameTextBox);
            this.groupControl.Controls.Add(this.dateOfBirthPicker);
            this.groupControl.Controls.Add(this.usernameLabel);
            this.groupControl.Controls.Add(this.dateOfBirthLabel);
            this.groupControl.Controls.Add(this.phoneLabel);
            this.groupControl.Controls.Add(this.addressLabel);
            this.groupControl.Controls.Add(this.firstNameLabel);
            this.groupControl.Controls.Add(this.lastNameLabel);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(438, 294);
            this.groupControl.TabIndex = 13;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(153, 232);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(231, 20);
            this.dateOfBirthPicker.TabIndex = 26;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(153, 192);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(231, 20);
            this.phoneTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(153, 152);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(231, 20);
            this.addressTextBox.TabIndex = 18;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 110);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Location = new System.Drawing.Point(36, 238);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(61, 13);
            this.dateOfBirthLabel.TabIndex = 16;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(36, 195);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(30, 13);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Phone";
            // 
            // addressLabel
            // 
            this.addressLabel.Location = new System.Drawing.Point(36, 155);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(39, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(36, 113);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(48, 13);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "FirstName";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(153, 72);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(36, 72);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(47, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "LastName";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.exitButton);
            this.buttonsPanel.Controls.Add(this.saveButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 294);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(438, 51);
            this.buttonsPanel.TabIndex = 12;
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
            this.exitButton.Location = new System.Drawing.Point(286, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 41);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
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
            this.saveButton.Location = new System.Drawing.Point(36, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 41);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(153, 33);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(231, 20);
            this.usernameTextBox.TabIndex = 28;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(36, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(48, 13);
            this.usernameLabel.TabIndex = 27;
            this.usernameLabel.Text = "Username";
            // 
            // AccountDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 345);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "AccountDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit account info";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsPanel)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private DevExpress.XtraEditors.LabelControl lastNameLabel;
        private DevExpress.XtraEditors.PanelControl buttonsPanel;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl dateOfBirthLabel;
        private DevExpress.XtraEditors.LabelControl phoneLabel;
        private DevExpress.XtraEditors.LabelControl addressLabel;
        private DevExpress.XtraEditors.LabelControl firstNameLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private DevExpress.XtraEditors.LabelControl usernameLabel;
    }
}