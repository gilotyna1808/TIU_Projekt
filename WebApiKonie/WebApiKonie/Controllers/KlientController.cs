using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;
using WebApiKonie.Services;

namespace WebApiKonie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlientController : ControllerBase
    {
        private readonly IKlientServices _klientService;

        public KlientController(IKlientServices klientServices)
        {
            this._klientService = klientServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<KlientDTO>> getAll()
        {
            var klienci = _klientService.getAll();
            return Ok(klienci);
        }

        [HttpGet("{id}")]
        public ActionResult<KlientDTO> getById(int id)
        {
            return Ok(_klientService.getById(id));
        }

        [HttpPut]
        public ActionResult<bool> update([FromBody]KlientDTO klient)
        {
            return Ok(_klientService.zmienStanKonta(klient));
        }

        [HttpPost]
        public ActionResult<bool> add([FromBody] KlientDTO klient)
        {
            return Ok(_klientService.dodajKlienta(klient));
        }
    }
}
