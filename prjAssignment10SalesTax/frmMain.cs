using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//  Hi, David!!  How are you?


namespace prjAssignment10SalesTax
{
    public partial class frmMain : Form
    {
        CTransaction taxTransaction = new CTransaction();
        private decimal decItemPrice;
        public decimal decTaxAmt { get; set; }

        public frmMain()
        {
            InitializeComponent();

            //  Declare initial tax rate for WI
            taxTransaction.decTaxRate = 5;
            lblTaxRateOut.Text = (taxTransaction.decTaxRate).ToString() + " %";

        }
        
        
        private void setTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  First get rid of results as the rate may change
            //  Could be a method of its own.  Why can't I just
            //  call the btn click method?

            

            txtPriceIn.Text = String.Empty;
            lblTaxOut.Text = String.Empty;
            lblTotalOut.Text = String.Empty;
            txtPriceIn.Focus();

            //  Make a form
            frmSetTax taxSetForm = new frmSetTax();
            //  Display it
            taxSetForm.ShowDialog();
            

            if (taxSetForm.decSetRate >0)
            {
                //  Now put the new rate over there
                taxTransaction.decTaxRate = taxSetForm.decSetRate;
                //  And display it here
                lblTaxRateOut.Text = taxTransaction.decTaxRate.ToString() + " %";
            }

        
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPriceIn.Text = String.Empty;
            lblTaxOut.Text = String.Empty;
            lblTotalOut.Text = String.Empty;
            txtPriceIn.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //  Show messagebox with basic instructions
            MessageBox.Show
                ("Enter an item price in the form ##.##.  No other punctuation" +
                "is needed.  Then press enter or the Calculate button." +
                "\n\n" +
                "The form can be cleared with the Esc key or using the Reset" +
                "button." +
                "\n\n" +
                "If you would like to change the tax rate you can access the" +
                "\n" +
                "form through the File menu.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Show messagebox with about info
            MessageBox.Show(
                "       Sales Tax Calculator" +
                "\n\n" +
                "                     by" +
                "\n" +
                "            Greg Lambert" +
                "\n\n" +
                "Not really copyrighted 2017");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  Is there anything in the sale field?
            if ((txtPriceIn.Text).Length > 0)
            {
                //  Is it a decimal?  
                if (decimal.TryParse (txtPriceIn.Text, out decItemPrice))
                {
                    if (decItemPrice > 0)
                    {
                        //  Let's make it manageable
                        if (decItemPrice < 1000000)
                        {
                            decTaxAmt = taxTransaction.CalculateTax(decItemPrice);
                            lblTaxOut.Text = decTaxAmt.ToString("c");
                            lblTotalOut.Text = (decItemPrice + decTaxAmt).ToString("c");
                            
                        }
                        //  Last one...
                        else
                        {
                            MessageBox.Show("That's just too big for this assignment.");
                            txtPriceIn.SelectAll();
                        }

                    }
                    //  It's 0 or negative
                    else
                    {
                        MessageBox.Show("Pleae make the value positive.");
                        txtPriceIn.SelectAll();
                    }
                    
                    
                }
                //  Must be a alpha
                else
                {
                    MessageBox.Show("Please enter only numeric data" + "\n" +
                        "in the Price of Item field.");
                    txtPriceIn.SelectAll();
                }
            }

            //  Nothing in sale field
            else
            {
                MessageBox.Show("Please enter something in the" + "\n" +
                    "Price of Item field.");
                
            }
        }

        private void txtPriceIn_TextChanged(object sender, EventArgs e)
        {
            lblTaxOut.Text = String.Empty;
            lblTotalOut.Text = String.Empty;
        }
    }

   

}
