namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmCityRequest
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
            this.gbxCityData = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCountryId = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxCityData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCityData
            // 
            this.gbxCityData.Controls.Add(this.label2);
            this.gbxCityData.Controls.Add(this.cbxCountryId);
            this.gbxCityData.Controls.Add(this.btnSave);
            this.gbxCityData.Controls.Add(this.label1);
            this.gbxCityData.Controls.Add(this.txtName);
            this.gbxCityData.Location = new System.Drawing.Point(13, 13);
            this.gbxCityData.Name = "gbxCityData";
            this.gbxCityData.Size = new System.Drawing.Size(290, 177);
            this.gbxCityData.TabIndex = 0;
            this.gbxCityData.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // cbxCountryId
            // 
            this.cbxCountryId.FormattingEnabled = true;
            this.cbxCountryId.Location = new System.Drawing.Point(20, 86);
            this.cbxCountryId.Name = "cbxCountryId";
            this.cbxCountryId.Size = new System.Drawing.Size(251, 21);
            this.cbxCountryId.TabIndex = 3;
            this.cbxCountryId.Validating += new System.ComponentModel.CancelEventHandler(this.cbxCountryId_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(196, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCityRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 212);
            this.Controls.Add(this.gbxCityData);
            this.Name = "frmCityRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City";
            this.Load += new System.EventHandler(this.frmCityRequest_Load);
            this.gbxCityData.ResumeLayout(false);
            this.gbxCityData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCityData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCountryId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}