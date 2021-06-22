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
        private readonly IWyscigService _wyscigService;

        public WyscigController(IWyscigService wyscigService)
        {
            this._wyscigService = wyscigService;
        }

        [HttpGet]
        public ActionResult<List<WyscigDTO>> get()
        {
            var wynik = _wyscigService.pobierzWyscigi();
            return Ok(wynik);
        }

        [HttpGet("{id}")]
        public ActionResult<WyscigDTO> getById(int id)
        {
            var wynik=_wyscigService.pobierzWyscig(id);
            return Ok(wynik);
        }

        [HttpPut]
        public ActionResult<bool> update([FromBody] WyscigDTO wyscig)
        {
            var wynik = _wyscigService.modyfikujWyscig(wyscig);
            return Ok(wynik);
        }

        [HttpPost]
        public ActionResult<bool> add([FromBody] WyscigDTO wyscig)
        {
            var wynik = _wyscigService.dodajWyscig(wyscig);
            return Ok(wynik);
        }
    }
}
