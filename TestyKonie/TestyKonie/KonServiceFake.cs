using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiKonie.Models;
using WebApiKonie.Services;

namespace TestyKonie
{
    class KonServiceFake:IKonService
    {
        private readonly ZakladyDB database;
        public KonServiceFake(ZakladyDB zaklady)
        {
            database = zaklady;
        }

        public bool DodajKonia(KonDTO kon)
        {
            throw new NotImplementedException();
        }

        public bool ModyfikujKonia(KonDTO kon)
        {
            throw new NotImplementedException();
        }

        public KonDTO PobierzKonia(int id)
        {
            return KonDTO.toKonDTO(database.Konie.Where(s => s.ID_Konia == id).First());
        }

        public IEnumerable<KonDTO> PobierzKonie()
        {
            var k = database.Konie.ToList();
            return KonDTO.toKonDTO(k);
        }
    }
}
