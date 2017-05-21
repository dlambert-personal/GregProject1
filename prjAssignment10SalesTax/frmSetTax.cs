using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAssignment10SalesTax
{
    public partial class frmSetTax : Form
    {


        public decimal decSetRate { get; set; }

        private decimal decLocalRate;
        public frmSetTax()
        {
            InitializeComponent();            
        }

        

        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //  Is there anything in the field
            if (txtSetTaxIn.TextLength > 0)
            {
                //  Is it numeric and in correct form?
                if (decimal.TryParse(txtSetTaxIn.Text, out decLocalRate))
                {
                    //  Is it positive?
                    if (decLocalRate > 0)
                    {
                        //  Set new tax rate
                        decSetRate = decLocalRate;
                        this.Close();
                        
                    }

                    //  Must be 0 or negative
                    else
                    {
                        MessageBox.Show("Please enter a positive tax rate in the format #.# .");
                    }
                }

                //  Not numeric or not decimal
                else
                {
                    MessageBox.Show("Please enter a number in the form #.# for the tax rate.");
                }
            }
            
            //  Nothing there
            else
            {
                MessageBox.Show("Please enter a number in the box" +
                    "\n" +
                    "or press the Cancel button.");
            }
        }
        
    }
}
