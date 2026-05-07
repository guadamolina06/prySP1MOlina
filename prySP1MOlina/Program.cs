using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using prySP1MOlina.Services;

namespace prySP1MOlina
{
    internal static class Program
    {
        // Servicio compartido de la clínica (listas en memoria)
        public static ClinicaService Service { get; private set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializar servicio antes de crear formularios
            Service = new ClinicaService();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
