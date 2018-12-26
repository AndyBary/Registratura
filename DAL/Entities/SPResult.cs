using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SPResult
    {
        public string Pacient_FIO { get; set; }
        public DateTime Zapis_date { get; set; }
        public string Zapis_time { get; set; }
        public string Doctor_FIO { get; set; }
    }
}
