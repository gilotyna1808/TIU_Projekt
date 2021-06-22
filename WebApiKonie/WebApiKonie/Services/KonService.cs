using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class KonService : IKonService
    {
        ZakladyDB database;
        public KonService(ZakladyDB zaklady)
        {
            database = zaklady;
        }

        public bool DodajKonia(KonDTO kon)
        {
            database.Konie.Add(KonDTO.toKon(kon));
            database.SaveChanges();
            return true;
        }

        public bool ModyfikujKonia(KonDTO kon)
        {
            var k = database.Konie.Where(s => s.ID_Konia == kon.ID_Konia).First();
            k.Kondycja = kon.Kondycja;
            k.Kraj = kon.Kraj;
            k.Nazwa = kon.Nazwa;
            k.Predkosc = kon.Predkosc;
            k.Wiek = kon.Wiek;
            database.SaveChanges();
            return true;
        }

        public KonDTO PobierzKonia(int id)
        {
            return KonDTO.toKonDTO(database.Konie.Where(s => s.ID_Konia == id).FirstOrDefault());
        }

        public IEnumerable<KonDTO> PobierzKonie()
        {
            return KonDTO.toKonDTO(database.Konie.ToList());
        }
    }
}
