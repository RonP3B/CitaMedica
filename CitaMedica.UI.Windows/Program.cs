using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitaMedica.UI.Windows
{
    static class Program
    {

        public static bool UserAuthenticated;
        public static string Username;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
            Application.Run(new Login());
            if (UserAuthenticated) Application.Run(new MainMenu());
        }
    }
}
