using System;
using System.Windows.Forms;

namespace GDOOR_MODULO_DE_RELATORIO____SANGRIA
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain_Bleeding_Report());
        }
    }
}
