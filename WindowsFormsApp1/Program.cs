using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            DataBase DB = new DataBase();
            if (DB.isNotEmpty())
            {
                Application.Run(new LoginForm());
            }
            else 
            {
                Application.Run(new RegForm1());
            }
        }
    }
}
