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
    public class ZapisRepositorySQL : IRepository<Zapis>
    {
        private PoliklinikaDB db;

        public ZapisRepositorySQL(PoliklinikaDB dbcontext)
        {
            this.db = dbcontext;
            db.Zapis.Load();
        }

        public ObservableCollection<Zapis> GetList()
        {
            return db.Zapis.Local;
        }

        public Zapis GetItem(int id)
        {
            return db.Zapis.Find(id);
        }

        public void Create(Zapis zapis)
        {
            db.Zapis.Add(zapis);
        }

        public void Update(Zapis zapis)
        {
            db.Entry(zapis).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Zapis zapis = db.Zapis.Find(id);
            if (zapis != null)
                db.Zapis.Remove(zapis);
        }
    }
}
