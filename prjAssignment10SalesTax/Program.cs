using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAssignment10SalesTax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //  Technically not a splash screen, I know.
            //  I think there's a splash screen class that
            //  I'll look up if I have more time.
            Application.Run(new frmSplash());
            //  Splash screen times out.
            
            //  Launch regular form
            Application.Run(new frmMain());
        }
    }
}
