using System;
using System.Windows.Forms; // Asegúrate de que este espacio de nombres esté correcto

namespace Sistema.Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Cambia `Form1` al formulario que deseas iniciar primero
        }
    }
}
