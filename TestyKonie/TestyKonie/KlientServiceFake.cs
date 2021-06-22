using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiKonie.Models;
using WebApiKonie.Services;

namespace TestyKonie
{
    class KlientServiceFake : IKlientServices
    {
        private List<KlientDTO> klients;
        public KlientServiceFake()
        {
            klients = new List<KlientDTO> {
                new KlientDTO
                {
                    ID_Klienta=1,
                    Imie="Daniel",
                    Email="aaa@tlen.pl",
                    Nazwisko="Dabrowski",
                    StanKonta=150.00M,
                    Wiek=22
                },
                new KlientDTO
                {
                    ID_Klienta=2,
                    Imie="Mateusz",
                    Email="aaa@tlen.pl",
                    Nazwisko="Gibas",
                    StanKonta=1050.00M,
                    Wiek=22
                },
                new KlientDTO
                {
                    ID_Klienta=3,
                    Imie="Tomasz",
                    Email="aaa@tlen.pl",
                    Nazwisko="Blaszczyk",
                    StanKonta=1500.00M,
                    Wiek=22
                },
            };
        }


        public bool dodajKlienta(KlientDTO klient)
        {
            klients.Add(klient);
            return true;
        }

        public IEnumerable<KlientDTO> getAll()
        {
            return klients;
        }

        public KlientDTO getById(int id)
        {
            return klients.Where(s=>s.ID_Klienta==id).Single();
        }

        public bool modyfikujKlienta(KlientDTO klient)
        {
            KlientDTO k = klients.Where(s => s.ID_Klienta == klient.ID_Klienta).Single();
            k.Email = klient.Email;
            k.Imie = klient.Imie;
            k.Nazwisko = klient.Nazwisko;
            k.StanKonta = klient.StanKonta;
            k.Wiek = klient.Wiek;
            return true;
        }

        public bool zmienStanKonta(int id, decimal kwota)
        {
            klients.Where(s => s.ID_Klienta == id).Single().StanKonta = kwota;
            return true;
        }
    }
}
