using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;
using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IReportService
    {
        int ReportPacientsNumber(int cb);
        List<SPResult> ExecuteSP(DateTime start, DateTime end);
    }
}
