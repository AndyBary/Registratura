using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PacientService : IPacientService
    {
        private IDbRepos db;
        Pacient pacient;


        public PacientService(IDbRepos repos)
        {
            this.db = repos;
        }

        public void  CreatePacient(PacientModel pacientDto)
        { 
          if (pacientDto.Polis_number > 0)
            {
                Pacient pacient = db.Pacients.GetItem(pacientDto.Polis_number);
                pacient.FIO = pacientDto.FIO;
                pacient.Adres = pacientDto.Adres;
                pacient.Gender = pacientDto.Gender;
                pacient.Birth_day = pacientDto.Birth_day;
                pacient.Uchastok_number = pacientDto.Uchastok_number;

                Console.Write("Новый пациент добавлен");
            }           
        }

        bool IPacientService.CreatePacient(PacientModel pacientDto)
        {
            throw new NotImplementedException();
        }
    }


}

