using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public interface IZakladService
    {
        public bool dodajZaklad(ZakladDTO zaklad);
        public bool zrealizujZaklad(ZakladDTO zaklad);
        public IEnumerable<ZakladDTO> wyswietlZaklady();
        public IEnumerable<ZakladDTO> wyswietlZakladyKlienta(int id);
        public ZakladDTO wyswietlZaklad(int id);
    }
}
