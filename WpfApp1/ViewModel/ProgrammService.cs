using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data;
using WpfApp1.Model;
using WpfApp1.Helpers;
using System.Windows;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
   

    public class ProgrammService : Base
    {
        PoliklinikaDB db;

        public List<Raspisanie> rasp { get; set; }
        public List<Pacient> pacient{ get; set; }
        public List<Doctor> doctor { get; set; }
        public List<Zapis> zapis { get; set; }
        public RelayCommand AddPacientCommand { get; set; }
        public RelayCommand AddZapisCommand { get; set; }
        public RelayCommand CreatePacientCommand { get; set; }
        public RelayCommand HranimkaCommand { get; set; }
        public ProgrammService()
        {

            AddPacientCommand = new RelayCommand(AddPacient, CanExecute);
            AddZapisCommand = new RelayCommand(AddZapis, CanExecute);
            CreatePacientCommand = new RelayCommand(CreatePacient, CanExecute);
            //HranimkaCommand = new RelayCommand(Hranimka, CanExecute);
            db = new PoliklinikaDB();
            db.Raspisanie.Load();
            rasp = db.Raspisanie.ToList();

            db.Pacient.Load();
            pacient = db.Pacient.ToList();

            db.Doctor.Load();
            doctor = db.Doctor.ToList();

            db.Zapis.Load();
            zapis = db.Zapis.ToList();
        }

        public void spravcheck(string ul, PacientAddWindow f, Pacient pacient)
        {
            if (ul == "Рабфаковская, 1" || ul == "Рабфаковская, 2" || ul == "Рабфаковская, 3") { pacient.Uchastok_number = 1; }
            if (ul == "Профессиональная, 1" || ul == "Профессиональная, 2" || ul == "Профессиональная, 3") { pacient.Uchastok_number = 2; }
            if (ul == "Красных Зорь, 1" || ul == "Красных Зорь, 2" || ul == "Красных Зорь, 3") { pacient.Uchastok_number = 1; }
            if (ul == "Лежневская, 1" || ul == "Лежневская, 2" || ul == "Лежневская, 3") { pacient.Uchastok_number = 3; }
            if (ul == "Ермака, 1" || ul == "Ермака, 2" || ul == "Ермака, 3") { pacient.Uchastok_number = 4; }
            if (ul == "Станционная, 1" || ul == "Станционная, 2" || ul == "Станционная, 3") { pacient.Uchastok_number = 4; }
            if (ul == "Громобоя, 1" || ul == "Громобоя, 2" || ul == "Громобоя, 3") { pacient.Uchastok_number = 5; }
            if (ul == "Парижской Комунны, 1" || ul == "Парижской Комунны, 2" || ul == "Парижской Комунны, 3") { pacient.Uchastok_number = 6; }
            if (ul == "Станкостроителей, 1" || ul == "Станкостроителей, 2" || ul == "Станкостроителей, 3") { pacient.Uchastok_number = 7; }
        }

        /*public class SPResult
        {
            public string Pacient_FIO { get; set; }
            public DateTime Zapis_date { get; set; }
            public string Zapis_time { get; set; }
            public string Doctor_FIO { get; set; }
        }

        public List<SPResult> Hranimka(object parameter, DateTime start, DateTime end)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@start", start);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@end", end);
            db = new PoliklinikaDB();
            var result = db.Database.SqlQuery<SPResult>("otchet1 @start, @end", new object[] { param1, param2 }).ToList();
            return result;
        }*/



        public void CreatePacient(object parameter)
        {
            PacientAddWindow p = new PacientAddWindow();
            string ul;
            Pacient pacient = new Pacient();

            pacient.Polis_number = _SelectedPolis_number;
            pacient.FIO = p.FIOTB.Text;
            pacient.Gender = p.GenderCB.Text;
            pacient.Birth_day = Convert.ToString(p.Birth_dayTB.Text);
            pacient.Adres = p.AdresTB.Text;
            ul = p.AdresTB.Text;
            spravcheck(ul, p, pacient);

            db.Pacient.Load();

            db.Pacient.Add(pacient);
            SaveChanges();

            MessageBox.Show("Паицент добавлен");
            CloseWindow();
        }
        
        public void AddPacient(object parameter)
        {
            PacientAddWindow p = new PacientAddWindow();
            p.Show();
            SaveChanges();
        }

        void AddZapis(object parameter)
        {
              Zapis z = new Zapis();
            {
                z.Zapis_date = _SelectedZapis_date;
                z.Pacient_FIO = _SelectedPacient_FIO;
                z.Zapis_time = _SelectedZapis_time;
                z.Doctor_FIO = _SelectedDoctor_FIO;

            }

                if (SelectedZapis_time == "")
                {
                    MessageBox.Show("Введите время приема");
                    return;
                }
                db.Zapis.Add(z);
                MessageBox.Show("Пациент записан");
                SaveChanges();
        }

        int _SelectedPolis_number;
        public int SelectedPolis_number
        {
            get
            {
                return _SelectedPolis_number;
            }
            set
            {
                if (_SelectedPolis_number != value)
                {
                    _SelectedPolis_number = value;
                    ZapisPropertyChanged("SelectedPolis_number");
                }
            }
        }

        string _SelectedGender;
        public string SelectedGender
        {
            get
            {
                return _SelectedGender;
            }
            set
            {
                if (_SelectedGender != value)
                {
                    _SelectedGender = value;
                    ZapisPropertyChanged("SelectedGender");
                }
            }
        }

        DateTime _SelectedBirth_day;
        public DateTime SelectedBirth_day
        {
            get
            {
                return _SelectedBirth_day;
            }
            set
            {
                if (_SelectedBirth_day != value)
                {
                    _SelectedBirth_day = value;
                    ZapisPropertyChanged("SelectedBirth_day");
                }
            }
        }

        string _SelectedAdres;
        public string SelectedAdres
        {
            get
            {
                return _SelectedAdres;
            }
            set
            {
                if (_SelectedAdres != value)
                {
                    _SelectedAdres = value;
                    ZapisPropertyChanged("SelectedAdres");
                }
            }
        }

        int _SelectedUchastok_number;
        public int SelectedUchastok_number
        {
            get
            {
                return _SelectedUchastok_number;
            }
            set
            {
                if (_SelectedUchastok_number != value)
                {
                    _SelectedUchastok_number = value;
                    ZapisPropertyChanged("SelectedUchastok_number");
                }
            }
        }

        string _SelectedDoctor_FIO;
        public string SelectedDoctor_FIO
        {
            get
            {
                return _SelectedDoctor_FIO;
            }
            set
            {
                if (_SelectedDoctor_FIO != value)
                {
                    _SelectedDoctor_FIO = value;
                    ZapisPropertyChanged("SelectedDoctor_FIO");
                }
            }
        }

        string _SelectedZapis_time;
        public string SelectedZapis_time
        {
            get
            {
                return _SelectedZapis_time;
            }
            set
            {
                if (_SelectedZapis_time != value)
                {
                    _SelectedZapis_time = value;
                    ZapisPropertyChanged("SelectedTime");
                }
            }
        }

        DateTime _SelectedZapis_date;
        public DateTime SelectedZapis_date
        {
            get
            {
                return _SelectedZapis_date;
            }
            set
            {
                if (_SelectedZapis_date != value)
                {
                    _SelectedZapis_date = value;
                    ZapisPropertyChanged("SelectedDate");
                }
            }
        }

        string _SelectedPacient_FIO;
        public string SelectedPacient_FIO
        {
            get
            {
                return _SelectedPacient_FIO;
            }
            set
            {
                if (_SelectedPacient_FIO != value)
                {
                    _SelectedPacient_FIO = value;
                    ZapisPropertyChanged("SelectedPacient_FIO");
                }
            }
        }

        Doctor _SelectedKabinet;
        public Doctor SelectedKabinet
        {
            get
            {
                return _SelectedKabinet;
            }
            set
            {
                if (_SelectedKabinet != value)
                {
                    _SelectedKabinet = value;
                    ZapisPropertyChanged("SelectedKabinet");
                }
            }
        }

        Doctor _SelectedSpeciality;
        public Doctor SelectedSpeciality
        {
            get
            {
                return _SelectedSpeciality;
            }
            set
            {
                if (_SelectedSpeciality != value)
                {
                    _SelectedSpeciality = value;
                    ZapisPropertyChanged("SelectedSpeciality");
                }
            }
        }

        public bool SaveChanges()
        {
            /*if (db.SaveChanges() > 0) */return true;
            //return false;
        }

        bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
