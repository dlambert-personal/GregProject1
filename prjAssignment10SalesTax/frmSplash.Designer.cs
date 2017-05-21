namespace prjAssignment10SalesTax
{
    partial class frmSplash
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
            this.picAbacus = new System.Windows.Forms.PictureBox();
            this.picCalculator = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWlcome2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAbacus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbacus
            // 
            this.picAbacus.Image = global::prjAssignment10SalesTax.Properties.Resources.abacus;
            this.picAbacus.Location = new System.Drawing.Point(3, 291);
            this.picAbacus.Name = "picAbacus";
            this.picAbacus.Size = new System.Drawing.Size(229, 170);
            this.picAbacus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAbacus.TabIndex = 0;
            this.picAbacus.TabStop = false;
            // 
            // picCalculator
            // 
            this.picCalculator.Image = global::prjAssignment10SalesTax.Properties.Resources.Calculator;
            this.picCalculator.Location = new System.Drawing.Point(324, 1);
            this.picCalculator.Name = "picCalculator";
            this.picCalculator.Size = new System.Drawing.Size(298, 250);
            this.picCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCalculator.TabIndex = 1;
            this.picCalculator.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("AR DELANEY", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(-7, 108);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(324, 78);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblWlcome2
            // 
            this.lblWlcome2.AutoSize = true;
            this.lblWlcome2.BackColor = System.Drawing.Color.Transparent;
            this.lblWlcome2.Font = new System.Drawing.Font("AR DELANEY", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlcome2.Location = new System.Drawing.Point(238, 276);
            this.lblWlcome2.Name = "lblWlcome2";
            this.lblWlcome2.Size = new System.Drawing.Size(534, 156);
            this.lblWlcome2.TabIndex = 3;
            this.lblWlcome2.Text = "To the Sales\r\nTax Calculator.";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(356, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjAssignment10SalesTax.Properties.Resources.dollars;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(787, 466);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWlcome2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picCalculator);
            this.Controls.Add(this.picAbacus);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Sales Tax Calculator!";
            ((System.ComponentModel.ISupportInitialize)(this.picAbacus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbacus;
        private System.Windows.Forms.PictureBox picCalculator;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWlcome2;
        private System.Windows.Forms.Button btnCancel;
    }
}

