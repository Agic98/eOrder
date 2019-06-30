namespace eOrder.Win.Forms.FormsRequest
{
    partial class frmProductRequest
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
            this.gbxProductData = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProductData
            // 
            this.gbxProductData.Controls.Add(this.btnSave);
            this.gbxProductData.Controls.Add(this.btnNewImage);
            this.gbxProductData.Controls.Add(this.label5);
            this.gbxProductData.Controls.Add(this.pbxPhoto);
            this.gbxProductData.Controls.Add(this.txtPrice);
            this.gbxProductData.Controls.Add(this.label4);
            this.gbxProductData.Controls.Add(this.label3);
            this.gbxProductData.Controls.Add(this.cbxCategoryId);
            this.gbxProductData.Controls.Add(this.label2);
            this.gbxProductData.Controls.Add(this.txtDescription);
            this.gbxProductData.Controls.Add(this.txtName);
            this.gbxProductData.Controls.Add(this.label1);
            this.gbxProductData.Location = new System.Drawing.Point(13, 13);
            this.gbxProductData.Name = "gbxProductData";
            this.gbxProductData.Size = new System.Drawing.Size(397, 511);
            this.gbxProductData.TabIndex = 0;
            this.gbxProductData.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnNewImage
            // 
            this.btnNewImage.Location = new System.Drawing.Point(136, 407);
            this.btnNewImage.Name = "btnNewImage";
            this.btnNewImage.Size = new System.Drawing.Size(75, 23);
            this.btnNewImage.TabIndex = 10;
            this.btnNewImage.Text = "New image";
            this.btnNewImage.UseVisualStyleBackColor = true;
            this.btnNewImage.Click += new System.EventHandler(this.BtnNewImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Picture";
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(30, 330);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(100, 100);
            this.pbxPhoto.TabIndex = 8;
            this.pbxPhoto.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(30, 275);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(335, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrice_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(30, 223);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(335, 21);
            this.cbxCategoryId.TabIndex = 4;
            this.cbxCategoryId.Validating += new System.ComponentModel.CancelEventHandler(this.CbxCategoryId_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(30, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(335, 88);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProductRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 539);
            this.Controls.Add(this.gbxProductData);
            this.Name = "frmProductRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductRequest";
            this.Load += new System.EventHandler(this.FrmProductRequest_Load);
            this.gbxProductData.ResumeLayout(false);
            this.gbxProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProductData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}