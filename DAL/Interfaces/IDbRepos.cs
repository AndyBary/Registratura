using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Interfaces
{
    public interface IDbRepos
    {
        IRepository<Pacient> Pacients { get; }
        IRepository<Uchastok> Uchastoks { get; }
        IRepository<Raspisanie> Rasps { get; }
        IRepository<Zapis> Zaps { get; }
        int Save();
    }
}
