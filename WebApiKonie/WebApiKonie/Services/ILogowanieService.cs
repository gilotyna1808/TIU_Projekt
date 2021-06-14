using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public interface ILogowanieService
    {
        ZalogowanyUzytkownikDTO Login(LogowanieDTO login);

    }
}
