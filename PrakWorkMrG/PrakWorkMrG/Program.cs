using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrakWorkMrG
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Give();
            Give.ActiveForm.Visible = false;
            new Take();
            Take.ActiveForm.Visible = false;
            Application.Run(new Main());
        }
    }
}
