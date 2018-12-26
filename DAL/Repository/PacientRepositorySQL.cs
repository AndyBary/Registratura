using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class PacientRepositorySQL : IRepository<Pacient>
    {
        private PoliklinikaDB db;

        public PacientRepositorySQL(PoliklinikaDB dbcontext)
        {
            this.db = dbcontext;
            db.Pacient.Load();
        }

        public ObservableCollection<Pacient> GetList()
        {
            return db.Pacient.Local;
        }

        public Pacient GetItem(int Polis_number)
        {
            return db.Pacient.Find(Polis_number);
        }

        public void Create(Pacient pacient)
        {
            db.Pacient.Add(pacient);
        }

        public void Update(Pacient pacient)
        {
            db.Entry(pacient).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Pacient pacient = db.Pacient.Find(id);
            if (pacient != null)
                db.Pacient.Remove(pacient);
        }
    }
}
