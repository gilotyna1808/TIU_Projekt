using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public interface IKonService
    {
        bool DodajKonia(KonDTO kon);
        bool ModyfikujKonia(KonDTO kon);

        IEnumerable<KonDTO> PobierzKonie();
        KonDTO PobierzKonia(int id);
    }
}
