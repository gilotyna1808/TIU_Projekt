using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.DTO;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public interface IRejestracja
    {
        public bool Rejestruj(RejestracjaDTO logowanie);
    }
}
