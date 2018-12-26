
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using BLL.Interfaces;
using DAL.Entities;
using DAL;
using DAL.Interfaces;
using System;
using BLL.Models;

namespace BLL
{
    public class DBDataOperation : IdbCrud
    {
        IDbRepos db;

        public DBDataOperation(IDbRepos repos)
        {
            db = repos;
        }

        ObservableCollection<Pacient> l;
        ObservableCollection<Uchastok> u;
        ObservableCollection<Raspisanie> rp;
        ObservableCollection<Zapis> z;

        public RaspisanieModel GetId(int Polis_number)
        {
            return toRaspisanieModel(db.Rasps.GetItem(Polis_number));
        }

        public List<PacientModel> GetAllPacient()
        {
            l = db.Pacients.GetList();
            return l.Select(i => toPacientModel(i)).ToList();
        }

        public List<RaspisanieModel> GetRaspisanie()
        {
            rp = db.Rasps.GetList();
            return rp.Select(r => toRaspisanieModel(r)).ToList();
        }

        public List<ZapisModel> GetZapis()
        {
            z = db.Zaps.GetList();
            return z.Select(r => toZapisModel(r)).ToList();
        }

        public PacientModel GetPacient(int Polis_number)
        {
            return toPacientModel(db.Pacients.GetItem(Polis_number));
        }

        public UchastokModel GetUchastok(int ID)
        {
            return toUchastokModel(db.Uchastoks.GetItem(ID));
        }

        public void CreatePacient(PacientModel p)
        {
            db.Pacients.Create(toPacient(p, new Pacient()));
            db.Save();
            GetAllPacient();
        }

        public void UpdatePacient(PacientModel p)
        {
            Pacient ph = db.Pacients.GetItem(p.Polis_number);
            db.Pacients.Update(toPacient(p, ph));
            db.Save();
            GetAllPacient();
        }

        public void CreateZapis(ZapisModel z)
        {
            db.Zaps.Create(toZapis(z, new Zapis()));
            db.Save();
            GetZapis();
        }
        public bool CreateUchastok(Uchastok uchastok)
        {
            //db.Uchastok.Add(uchastok);
            return true;//Save();
        }

        public void UpdateUchastok(Uchastok u)
        {
           // db.Entry(u).State = EntityState.Modified;
        }

        public void DeletePacient(int Polis_number)
        {
            Pacient p = db.Pacients.GetItem(Polis_number);
            if (p != null)
            {
                db.Pacients.Delete(Polis_number);
                db.Save();
            }
        }

        public void DeleteUchastok(int id)
        {
            /*Uchastok u = db.Uchastoks.Find(id);
            if (u != null)
                db.Uchastoks.Remove(u);*/
        }

        private Uchastok toUchastok(UchastokModel ul, Uchastok u)
        {
            u.Number = ul.Number;
            u.ID = ul.ID;
            return u;
        }
        private UchastokModel toUchastokModel(Uchastok u)
        {
            return new UchastokModel() { Number = u.Number, ID = u.ID};
        }

        private Raspisanie toRaspisanie(RaspisanieModel rm, Raspisanie r)
        {
            r.FIO = rm.FIO;
            r.Kabinet_vracha = rm.Kabinet_vracha;
            r.Speciality = rm.Speciality;
            r.Nachalo_priema = rm.Nachalo_priema;
            r.Konec_priema = rm.Konec_priema;
            r.Status = rm.Status;
            return r;
        }
        private RaspisanieModel toRaspisanieModel(Raspisanie r)
        {
            return new RaspisanieModel() { FIO = r.FIO, Kabinet_vracha = r.Kabinet_vracha, Speciality = r.Speciality, Nachalo_priema = r.Nachalo_priema, Konec_priema = r.Konec_priema, Status = r.Status};
        }

        private Pacient toPacient(PacientModel pl, Pacient p)
        {
            p.Polis_number = pl.Polis_number;
            p.FIO = pl.FIO;
            p.Gender = pl.Gender;
            p.Birth_day = pl.Birth_day;
            p.Uchastok_number = pl.Uchastok_number;
            p.Adres = pl.Adres;
            return p;
        }
        private PacientModel toPacientModel(Pacient p)
        {
            return new PacientModel()
            {
                Polis_number = p.Polis_number,
                FIO = p.FIO,
                Gender = p.Gender,
                Birth_day = p.Birth_day,
                Uchastok_number = p.Uchastok_number,
                Adres = p.Adres
            };
        }

        private Zapis toZapis(ZapisModel zm, Zapis z)
        {
            z.Zapis_date = zm.Zapis_date;
            z.Pacient_FIO = zm.Pacient_FIO;
            z.Zapis_time = zm.Zapis_time;
            z.Doctor_FIO = zm.Doctor_FIO;
            return z;
        }
        private ZapisModel toZapisModel(Zapis z)
        {
            return new ZapisModel()
            {
                Zapis_date = z.Zapis_date,
                Pacient_FIO = z.Pacient_FIO,
                Zapis_time = z.Zapis_time,
                Doctor_FIO = z.Doctor_FIO,
            };
        }

    }
}
