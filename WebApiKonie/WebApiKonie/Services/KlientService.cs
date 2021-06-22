using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class KlientService:IKlientServices
    {
        private static ZakladyDB database;

        public KlientService(ZakladyDB zaklady)
        {
            database = zaklady;
        }

        public bool dodajKlienta(KlientDTO klient)
        {
            database.Klienci.Add(KlientDTO.toKlient(klient));
            return true;
        }

        public IEnumerable<KlientDTO> getAll()
        {
            List<Klient> temp = database.Klienci.ToList();
            return KlientDTO.toKlientDTO(temp);
        }

        public KlientDTO getById(int id)
        {
            return KlientDTO.toKlientDTO(database.Klienci.Where(s=>s.ID_Klienta==id).First());
        }

        public bool modyfikujKlienta(KlientDTO klient)
        {
            var k = database.Klienci.SingleOrDefault(s => s.ID_Klienta == klient.ID_Klienta);
            k.Email = klient.Email;
            k.Imie = klient.Imie;
            k.Nazwisko = klient.Nazwisko;
            k.Wiek = klient.Wiek;
            k.StanKonta = klient.StanKonta;
            database.SaveChanges();
            return true;
        }

        public bool zmienStanKonta(int id, decimal kwota)
        {
            database.Klienci.Where(s => s.ID_Klienta == id).First().StanKonta = kwota;
            database.SaveChanges();
            return true;
        }
    }
}
