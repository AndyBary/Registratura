using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAL;
namespace BLL.Interfaces
{
    public interface IdbCrud
    {
        List<PacientModel> GetAllPacient();
        List<RaspisanieModel> GetRaspisanie();
        List<ZapisModel> GetZapis();
        PacientModel GetPacient(int pacientId);
        RaspisanieModel GetId(int id);
        void CreatePacient(PacientModel p);
        void UpdatePacient(PacientModel p);
        void DeletePacient(int id);
        void CreateZapis(ZapisModel z);
    }
}
