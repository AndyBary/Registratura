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
    class UchastokRepositorySQL : IRepository<Uchastok>
    {
        private PoliklinikaDB db;

        public UchastokRepositorySQL(PoliklinikaDB dbcontext)
        {
            this.db = dbcontext;
            db.Raspisanie.Load();
        }

        public ObservableCollection<Uchastok> GetList()
        {
            return db.Raspisanie.Local;
        }

        public Uchastok GetItem(int id)
        {
            return db.Raspisanie.Find(id);
        }

        public void Create(Uchastok uchastok)
        {
            db.Raspisanie.Add(uchastok);
        }

        public void Update(Uchastok uchastok)
        {
            db.Entry(uchastok).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Uchastok uchastok = db.Raspisanie.Find(id);
            if (uchastok != null)
                db.Raspisanie.Remove(uchastok);
        }
    }
}
