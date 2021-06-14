using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public interface IKlientServices
    {
        KlientDTO getById(int id);
        bool dodajKlienta(KlientDTO klient);
        bool modyfikujKlienta(KlientDTO klient);
        bool zmienStanKonta(int id, decimal kwota);
        IEnumerable<KlientDTO> getAll();
    }
}
