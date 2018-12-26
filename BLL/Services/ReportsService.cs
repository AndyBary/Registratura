using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Interfaces;
using DAL.Entities;

namespace BLL.Services
{
    public class ReportsService : IReportService
    {
        private PoliklinikaDB db;
        
        public List<SPResult> ExecuteSP(DateTime start, DateTime end)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@start", start);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@end", end);
            db = new PoliklinikaDB();
            var result = db.Database.SqlQuery<SPResult>("otchet1 @start, @end", new object[] { param1, param2 }).ToList();
            return result;
        }

        public int ReportPacientsNumber(int cb)
        {
            db = new PoliklinikaDB();
            var result = db.Database.SqlQuery<int>("select count(*) as 'count' from [Pacient] where Uchastok_number = " + cb).FirstOrDefault();
            return result;
        }
    }
}

