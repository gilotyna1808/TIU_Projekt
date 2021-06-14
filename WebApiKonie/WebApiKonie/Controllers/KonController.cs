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
    public class KonController : ControllerBase
    {
        private readonly IKonService konService;

        public KonController(ZakladyDB zaklady)
        {
            this.konService = new KonService(zaklady);
        }


        [HttpGet]
        public ActionResult <IEnumerable<KonDTO>> getAll()
        {
            var wynik = konService.PobierzKonie();
            return Ok(wynik);
        }

        [HttpGet("{id}")]
        public ActionResult<KonDTO> getById(int id)
        {
            var wynik = konService.PobierzKonia(id);
            return Ok(wynik);
        }

        [HttpPost]
        public ActionResult<bool> add([FromBody]KonDTO kon)
        {
            konService.DodajKonia(kon);
            return Ok(true);
        }

        [HttpPut]
        public ActionResult<bool> update([FromBody] KonDTO kon)
        {
            konService.ModyfikujKonia(kon);
            return Ok(true);
        }
    }
}
