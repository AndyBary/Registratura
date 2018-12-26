using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Infastructure;
using BLL.Interfaces;
using Ninject;

namespace Поликлиника_лаба_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("dbConnection"));

            IdbCrud crudServ = kernel.Get<IdbCrud>();
            IPacientService pacServ = kernel.Get<IPacientService>();
            IReportService reportServ = kernel.Get<IReportService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(crudServ, reportServ, pacServ));  
        }
    }
}
