using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.DTO;

namespace WebApiKonie.Services
{
    public interface IPrzebiegService
    {
        public PrzebiegDTO pobierzPrzebieg(int i);
    }
}
