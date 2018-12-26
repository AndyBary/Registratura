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
using System.Windows;
using WpfApp1.View;
using WpfApp1.Helpers;

namespace WpfApp1.ViewModel
{
   

    public class SheduleService : Base
    {
        PoliklinikaDB db;

        public List<Raspisanie> rasp { get; set; }
        public List<Pacient> pacient{ get; set; }
        public List<Doctor> doctor { get; set; }
        public RelayCommand AddPacientCommand { get; set; }
        public RelayCommand AddZapisCommand { get; set; }

        public SheduleService()
        {
            AddPacientCommand = new RelayCommand(AddPacient, CanExecute);
            AddZapisCommand = new RelayCommand(AddZapis, CanExecute);

            db = new PoliklinikaDB();
            db.Raspisanie.Load();
            rasp = db.Raspisanie.ToList();

            db.Pacient.Load();
            pacient = db.Pacient.ToList();

            db.Doctor.Load();
            doctor = db.Doctor.ToList();
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

        /*void CreatePacient()
        {
            Pacient pacient = new Pacient();
            db.Pacient.Add(pacient);
            Save();
        }*/

        void AddPacient(object parameter)
        {
            Pacient pacient = new Pacient();

            {
                string ul;
                SelectedPolis_number = _SelectedPolis_number;
                SelectedPacient_FIO = _SelectedPacient_FIO;
                SelectedGender = _SelectedGender;
                SelectedBirth_day = _SelectedBirth_day;
                SelectedAdres = _SelectedAdres;
                //ul = f.AdresTB.Text;
                //spravcheck(ul, f, pacient);
                db.Pacient.Add(pacient);
                //MessageBox.Show("Пациент добавлен");
                Save();
                var p = new PacientAddWindow();
                p.Show();
                CloseWindow();
            };
        }

        void AddZapis(object parameter)
        {
              Zapis zapis = new Zapis();

            {
                SelectedZapis_date = _SelectedZapis_date;
                SelectedPacient_FIO = _SelectedPacient_FIO;
                SelectedZapis_time = SelectedZapis_time;
                SelectedDoctor_FIO = _SelectedDoctor_FIO;
                db.Zapis.Add(zapis);
                
                MessageBox.Show("Пациент записан");
                Save();
            };
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
        Doctor _SelectedDoctor_FIO;
        public Doctor SelectedDoctor_FIO
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

        TimeSpan _SelectedZapis_time;
        public TimeSpan SelectedZapis_time
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

        Pacient _SelectedPacient_FIO;
        public Pacient SelectedPacient_FIO
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

        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        bool CanExecute(object parameter)
        {
            return ((SelectedDoctor_FIO == null) && (SelectedPacient_FIO == null));
        }
    }
}
