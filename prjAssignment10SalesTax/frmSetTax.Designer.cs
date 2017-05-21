namespace prjAssignment10SalesTax
{
    partial class frmSetTax
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
            this.txtSetTaxIn = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblNewTaxRate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSetTaxIn
            // 
            this.txtSetTaxIn.Location = new System.Drawing.Point(77, 122);
            this.txtSetTaxIn.Name = "txtSetTaxIn";
            this.txtSetTaxIn.Size = new System.Drawing.Size(100, 20);
            this.txtSetTaxIn.TabIndex = 0;
            this.txtSetTaxIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(69, 2);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(117, 78);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Enter the tax rate in the\r\nfollowing manner:\r\n\r\n##.##\r\n\r\nthen press OK or Enter.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(90, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblNewTaxRate
            // 
            this.lblNewTaxRate.AutoSize = true;
            this.lblNewTaxRate.Location = new System.Drawing.Point(89, 103);
            this.lblNewTaxRate.Name = "lblNewTaxRate";
            this.lblNewTaxRate.Size = new System.Drawing.Size(76, 13);
            this.lblNewTaxRate.TabIndex = 6;
            this.lblNewTaxRate.Text = "New Tax Rate";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(231, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSetTax
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(255, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNewTaxRate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtSetTaxIn);
            this.Name = "frmSetTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Tax Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSetTaxIn;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblNewTaxRate;
        private System.Windows.Forms.Button btnCancel;
    }
}