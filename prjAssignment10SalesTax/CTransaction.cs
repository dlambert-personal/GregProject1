using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAssignment10SalesTax
{
    /// <summary>
    /// Can you see this comment???
    /// </summary>
    public class CTransaction
    {
        //  Declare variable(s)
        //  I don't think the sale amount needs to be public
        //  but what the heck.
        public decimal decTaxRate { get; set; }
        public decimal decSaleAmt { get; set; }
        
        private decimal decTaxAmt;
            
        //  Constructor
        public CTransaction()
        {

        }
        
      

        //  Method for calculating tax
        public decimal CalculateTax(decimal decSaleAmt)
        {
            decTaxAmt = decSaleAmt * (decTaxRate / 100);
            return decTaxAmt;
        }
        
    }
}
