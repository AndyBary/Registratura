using DAL.Entities;
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
    class RaspisanieRepositorySQL : IRepository<Raspisanie>
    {
        private PoliklinikaDB db;

        public RaspisanieRepositorySQL(PoliklinikaDB dbcontext)
        {
            this.db = dbcontext;
            db.Raspisanie1.Load();
        }

        public ObservableCollection<Raspisanie> GetList()
        {
            return db.Raspisanie1.Local;
        }

        public Raspisanie GetItem(int id)
        {
            return db.Raspisanie1.Find(id);
        }

        public void Create(Raspisanie raspisanie)
        {
            db.Raspisanie1.Add(raspisanie);
        }

        public void Update(Raspisanie raspisanie)
        {
            db.Entry(raspisanie).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Raspisanie raspisanie = db.Raspisanie1.Find(id);
            if (raspisanie != null)
                db.Raspisanie1.Remove(raspisanie);
        }
    }
}
