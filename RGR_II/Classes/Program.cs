using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RGR_II.Classes.DatabaseInteraction;

namespace RGR_II
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GetCreateTableString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Classes.ResourcesConfigEditClass.GetProdjectDir();
            Classes.ResourcesConfigEditClass.GetDatabaseDir();
            Application.Run(new StartForm());
        }
    }
}
