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
        private readonly ZakladyDB database;
        public KlientServiceFake(ZakladyDB zaklady)
        {
            database = zaklady;
        }


        public bool dodajKlienta(KlientDTO klient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KlientDTO> getAll()
        {
            var k = database.Klienci.ToList();
            return KlientDTO.toKlientDTO(k);
        }

        public KlientDTO getById(int id)
        {
            return KlientDTO.toKlientDTO(database.Klienci.Where(s => s.ID_Klienta == id).First());
        }

        public bool modyfikujKlienta(KlientDTO klient)
        {
            throw new NotImplementedException();
        }

        public bool zmienStanKonta(int id, decimal kwota)
        {
            throw new NotImplementedException();
        }
    }
}
