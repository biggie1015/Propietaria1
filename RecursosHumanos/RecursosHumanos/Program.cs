using RecursosHumanos.FrmPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos
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
            //Application.Run(new FrmReporte.FrmReporte());
            Application.Run(new FrmLogin.FrmLogin());
            //Application.Run(new  FrmCandidato.FrmCandidato());
            //Application.Run(new FrmPrincipal.VistaPrincipal());
        }
    }
}
