using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private PoliklinikaDB db;
        private PacientRepositorySQL pacientRepository;
        private UchastokRepositorySQL uchastokRepository;
        private RaspisanieRepositorySQL raspisanieRepository;
        private ZapisRepositorySQL zapisRepository;
        public DbReposSQL()
        {
            db = new PoliklinikaDB();
        }

        public IRepository<Pacient> Pacients
        {
            get
            {
                if (pacientRepository == null)
                    pacientRepository = new PacientRepositorySQL(db);
                return pacientRepository;
            }
        }

        public IRepository<Uchastok> Uchastoks
        {
            get
            {
                if (uchastokRepository == null)
                    uchastokRepository = new UchastokRepositorySQL(db);
                return uchastokRepository;
            }
        }

        public IRepository<Raspisanie> Rasps
        {
            get
            {
                if (raspisanieRepository == null)
                    raspisanieRepository = new RaspisanieRepositorySQL(db);
                return raspisanieRepository;
            }
        }

        public IRepository<Zapis> Zaps
        {
            get
            {
                if (zapisRepository == null)
                    zapisRepository = new ZapisRepositorySQL(db);
                return zapisRepository;
            }
        }
        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
