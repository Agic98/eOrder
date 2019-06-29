namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmOrganizationRequest
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxUserData = new System.Windows.Forms.GroupBox();
            this.cbxCityId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxOrganizationData = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxCurrencyId = new System.Windows.Forms.ComboBox();
            this.cbxOrganizationTypeId = new System.Windows.Forms.ComboBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNewImage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.gbxUserData.SuspendLayout();
            this.gbxOrganizationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(535, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxUserData
            // 
            this.gbxUserData.Controls.Add(this.btnNewImage);
            this.gbxUserData.Controls.Add(this.pbxProfilePhoto);
            this.gbxUserData.Controls.Add(this.cbxCityId);
            this.gbxUserData.Controls.Add(this.label12);
            this.gbxUserData.Controls.Add(this.label7);
            this.gbxUserData.Controls.Add(this.txtEmail);
            this.gbxUserData.Controls.Add(this.label4);
            this.gbxUserData.Controls.Add(this.txtPhoneNumber);
            this.gbxUserData.Controls.Add(this.label5);
            this.gbxUserData.Controls.Add(this.txtAddress);
            this.gbxUserData.Controls.Add(this.label6);
            this.gbxUserData.Controls.Add(this.txtPasswordConfirmed);
            this.gbxUserData.Controls.Add(this.label3);
            this.gbxUserData.Controls.Add(this.txtPassword);
            this.gbxUserData.Controls.Add(this.label2);
            this.gbxUserData.Controls.Add(this.txtUsername);
            this.gbxUserData.Controls.Add(this.label1);
            this.gbxUserData.Location = new System.Drawing.Point(13, 13);
            this.gbxUserData.Name = "gbxUserData";
            this.gbxUserData.Size = new System.Drawing.Size(288, 498);
            this.gbxUserData.TabIndex = 9;
            this.gbxUserData.TabStop = false;
            // 
            // cbxCityId
            // 
            this.cbxCityId.FormattingEnabled = true;
            this.cbxCityId.Location = new System.Drawing.Point(24, 330);
            this.cbxCityId.Name = "cbxCityId";
            this.cbxCityId.Size = new System.Drawing.Size(237, 21);
            this.cbxCityId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "City";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(24, 234);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(237, 20);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(24, 184);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(237, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // txtPasswordConfirmed
            // 
            this.txtPasswordConfirmed.Location = new System.Drawing.Point(24, 135);
            this.txtPasswordConfirmed.Name = "txtPasswordConfirmed";
            this.txtPasswordConfirmed.Size = new System.Drawing.Size(237, 20);
            this.txtPasswordConfirmed.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password confirmed";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(24, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(24, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // gbxOrganizationData
            // 
            this.gbxOrganizationData.Controls.Add(this.label11);
            this.gbxOrganizationData.Controls.Add(this.cbxCurrencyId);
            this.gbxOrganizationData.Controls.Add(this.cbxOrganizationTypeId);
            this.gbxOrganizationData.Controls.Add(this.txtShortName);
            this.gbxOrganizationData.Controls.Add(this.label10);
            this.gbxOrganizationData.Controls.Add(this.label9);
            this.gbxOrganizationData.Controls.Add(this.label8);
            this.gbxOrganizationData.Controls.Add(this.txtName);
            this.gbxOrganizationData.Location = new System.Drawing.Point(322, 13);
            this.gbxOrganizationData.Name = "gbxOrganizationData";
            this.gbxOrganizationData.Size = new System.Drawing.Size(288, 230);
            this.gbxOrganizationData.TabIndex = 10;
            this.gbxOrganizationData.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Currency";
            // 
            // cbxCurrencyId
            // 
            this.cbxCurrencyId.FormattingEnabled = true;
            this.cbxCurrencyId.Location = new System.Drawing.Point(25, 184);
            this.cbxCurrencyId.Name = "cbxCurrencyId";
            this.cbxCurrencyId.Size = new System.Drawing.Size(237, 21);
            this.cbxCurrencyId.TabIndex = 18;
            // 
            // cbxOrganizationTypeId
            // 
            this.cbxOrganizationTypeId.FormattingEnabled = true;
            this.cbxOrganizationTypeId.Location = new System.Drawing.Point(25, 135);
            this.cbxOrganizationTypeId.Name = "cbxOrganizationTypeId";
            this.cbxOrganizationTypeId.Size = new System.Drawing.Size(237, 21);
            this.cbxOrganizationTypeId.TabIndex = 15;
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(25, 87);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(237, 20);
            this.txtShortName.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Organization type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Short name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 15;
            // 
            // btnNewImage
            // 
            this.btnNewImage.Location = new System.Drawing.Point(130, 456);
            this.btnNewImage.Name = "btnNewImage";
            this.btnNewImage.Size = new System.Drawing.Size(75, 23);
            this.btnNewImage.TabIndex = 22;
            this.btnNewImage.Text = "New image";
            this.btnNewImage.UseVisualStyleBackColor = true;
            this.btnNewImage.Click += new System.EventHandler(this.BtnNewImage_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Picture";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbxProfilePhoto
            // 
            this.pbxProfilePhoto.Location = new System.Drawing.Point(24, 379);
            this.pbxProfilePhoto.Name = "pbxProfilePhoto";
            this.pbxProfilePhoto.Size = new System.Drawing.Size(100, 100);
            this.pbxProfilePhoto.TabIndex = 14;
            this.pbxProfilePhoto.TabStop = false;
            // 
            // frmOrganizationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 523);
            this.Controls.Add(this.gbxOrganizationData);
            this.Controls.Add(this.gbxUserData);
            this.Controls.Add(this.btnSave);
            this.Name = "frmOrganizationRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organization Add";
            this.Load += new System.EventHandler(this.frmOrganizationRequest_Load);
            this.gbxUserData.ResumeLayout(false);
            this.gbxUserData.PerformLayout();
            this.gbxOrganizationData.ResumeLayout(false);
            this.gbxOrganizationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxUserData;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxOrganizationData;
        private System.Windows.Forms.TextBox txtPasswordConfirmed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCityId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxOrganizationTypeId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxCurrencyId;
        private System.Windows.Forms.Button btnNewImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbxProfilePhoto;
    }
}