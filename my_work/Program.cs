using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_work
{
    public delegate void ObjectStringDelegate(object sender);
    public class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsSingleIsntance())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TrainingLog());
            }
            else
            {
                MessageBox.Show("Программа уже запущена!");
            }
        }
        static Mutex InstanceCheckMutex;
        static bool IsSingleIsntance()
        {
            bool flag;
            InstanceCheckMutex = new Mutex(true, "TrainingLog", out flag);
            return flag;
        }
    }
   
}
