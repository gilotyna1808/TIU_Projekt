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
        private readonly IKlientServices klientService;

        public KlientController(ZakladyDB zaklady)
        {
            this.klientService = new KlientService(zaklady);
        }

        [HttpGet]
        public ActionResult<IEnumerable<KlientDTO>> getAll()
        {
            var klienci = klientService.getAll();
            return Ok(klienci);
        }

        [HttpGet("{id}")]
        public ActionResult<KlientDTO> getById(int id)
        {
            return Ok(klientService.getById(id));
        }

        [HttpPut]
        public ActionResult<bool> update([FromBody]KlientDTO klient)
        {
            return Ok(klientService.modyfikujKlienta(klient));
        }
    }
}
