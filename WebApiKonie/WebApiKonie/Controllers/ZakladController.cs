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
    public class ZakladController : ControllerBase
    {
        IZakladService service;

        public ZakladController(IZakladService zakladService)
        {
            this.service = zakladService;
        }
        
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<ZakladDTO>> getByIDKlienta(int id)
        {
            return Ok(service.wyswietlZakladyKlienta(id));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ZakladDTO>> getAll()
        {
            return Ok(service.wyswietlZaklady());
        }


        [HttpPost]
        public ActionResult<bool> post([FromBody] ZakladDTO zaklad)
        {
            return Ok(service.dodajZaklad(zaklad));
        }

        [HttpPut]
        public ActionResult<bool> put([FromBody] ZakladDTO zaklad)
        {
            return Ok(service.zrealizujZaklad(zaklad));
        }
    }
}
