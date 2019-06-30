namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmUserRoleRequest
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
            this.gbxUserRoleData = new System.Windows.Forms.GroupBox();
            this.cbxRoleId = new System.Windows.Forms.ComboBox();
            this.cbxUserId = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxUserRoleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUserRoleData
            // 
            this.gbxUserRoleData.Controls.Add(this.cbxRoleId);
            this.gbxUserRoleData.Controls.Add(this.cbxUserId);
            this.gbxUserRoleData.Controls.Add(this.btnSave);
            this.gbxUserRoleData.Controls.Add(this.Description);
            this.gbxUserRoleData.Controls.Add(this.label1);
            this.gbxUserRoleData.Location = new System.Drawing.Point(3, 2);
            this.gbxUserRoleData.Name = "gbxUserRoleData";
            this.gbxUserRoleData.Size = new System.Drawing.Size(310, 199);
            this.gbxUserRoleData.TabIndex = 0;
            this.gbxUserRoleData.TabStop = false;
            // 
            // cbxRoleId
            // 
            this.cbxRoleId.FormattingEnabled = true;
            this.cbxRoleId.Location = new System.Drawing.Point(24, 100);
            this.cbxRoleId.Name = "cbxRoleId";
            this.cbxRoleId.Size = new System.Drawing.Size(256, 21);
            this.cbxRoleId.TabIndex = 6;
            this.cbxRoleId.Validating += new System.ComponentModel.CancelEventHandler(this.CbxRoleId_Validating);
            // 
            // cbxUserId
            // 
            this.cbxUserId.FormattingEnabled = true;
            this.cbxUserId.Location = new System.Drawing.Point(24, 50);
            this.cbxUserId.Name = "cbxUserId";
            this.cbxUserId.Size = new System.Drawing.Size(256, 21);
            this.cbxUserId.TabIndex = 5;
            this.cbxUserId.Validating += new System.ComponentModel.CancelEventHandler(this.CbxUserId_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(21, 84);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(29, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUserRoleRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 205);
            this.Controls.Add(this.gbxUserRoleData);
            this.Name = "frmUserRoleRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User roles";
            this.Load += new System.EventHandler(this.frmUserRoleRequest_Load);
            this.gbxUserRoleData.ResumeLayout(false);
            this.gbxUserRoleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUserRoleData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRoleId;
        private System.Windows.Forms.ComboBox cbxUserId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}