using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Interfaces;
using BLL.Services;
using Ninject;
using Ninject.Modules;

namespace Поликлиника_лаба_3
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPacientService>().To<PacientService>();
            Bind<IReportService>().To<ReportsService>();
            Bind<IdbCrud>().To<DBDataOperation>();
        }
    }
}
