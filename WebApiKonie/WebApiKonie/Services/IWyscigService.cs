using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public interface IWyscigService
    {
        public IEnumerable<WyscigDTO> pobierzWyscigi();
        public WyscigDTO pobierzWyscig(int id);
        public bool dodajWyscig(WyscigDTO wyscig);
        public bool modyfikujWyscig(WyscigDTO wyscig);
    }
}
