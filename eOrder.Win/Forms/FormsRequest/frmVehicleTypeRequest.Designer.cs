namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmVehicleTypeRequest
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
            this.gbxVehicleTypeData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxIconPreview = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxVehicleTypeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxVehicleTypeData
            // 
            this.gbxVehicleTypeData.Controls.Add(this.btnSave);
            this.gbxVehicleTypeData.Controls.Add(this.button1);
            this.gbxVehicleTypeData.Controls.Add(this.pbxIconPreview);
            this.gbxVehicleTypeData.Controls.Add(this.label2);
            this.gbxVehicleTypeData.Controls.Add(this.txtName);
            this.gbxVehicleTypeData.Controls.Add(this.label1);
            this.gbxVehicleTypeData.Location = new System.Drawing.Point(3, 3);
            this.gbxVehicleTypeData.Name = "gbxVehicleTypeData";
            this.gbxVehicleTypeData.Size = new System.Drawing.Size(269, 316);
            this.gbxVehicleTypeData.TabIndex = 0;
            this.gbxVehicleTypeData.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Icon";
            // 
            // pbxIconPreview
            // 
            this.pbxIconPreview.Location = new System.Drawing.Point(29, 102);
            this.pbxIconPreview.Name = "pbxIconPreview";
            this.pbxIconPreview.Size = new System.Drawing.Size(125, 125);
            this.pbxIconPreview.TabIndex = 3;
            this.pbxIconPreview.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "New image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVehicleTypeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 323);
            this.Controls.Add(this.gbxVehicleTypeData);
            this.Name = "frmVehicleTypeRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle type";
            this.Load += new System.EventHandler(this.frmVehicleTypeRequest_Load);
            this.gbxVehicleTypeData.ResumeLayout(false);
            this.gbxVehicleTypeData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVehicleTypeData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbxIconPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}