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
    public class WyscigController : ControllerBase
    {
        private readonly IWyscigService wyscigService;

        public WyscigController(ZakladyDB zaklady)
        {
            this.wyscigService = new WyscigService(zaklady);
        }

        [HttpGet]
        public ActionResult<List<WyscigDTO>> get()
        {
            var wynik = wyscigService.pobierzWyscigi();
            return Ok(wynik);
        }

        [HttpGet("{id}")]
        public ActionResult<WyscigDTO> getById(int id)
        {
            var wynik=wyscigService.pobierzWyscig(id);
            return Ok(wynik);
        }

        [HttpPut]
        public ActionResult<bool> update([FromBody] WyscigDTO wyscig)
        {
            var wynik = wyscigService.modyfikujWyscig(wyscig);
            return Ok(wynik);
        }

        [HttpPost]
        public ActionResult<bool> add([FromBody] WyscigDTO wyscig)
        {
            var wynik = wyscigService.dodajWyscig(wyscig);
            return Ok(wynik);
        }
    }
}
