using System;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin_D()); // Aquí inicia tu formulario de login
        }
    }
}

