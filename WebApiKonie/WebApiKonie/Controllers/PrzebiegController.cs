using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.DTO;
using WebApiKonie.Services;

namespace WebApiKonie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrzebiegController : ControllerBase
    {
        IPrzebiegService service;

        public PrzebiegController(IPrzebiegService przebieg)
        {
            this.service = przebieg;
        }

        [HttpGet("{id}")]
        public ActionResult<PrzebiegDTO> get(int id)
        {
            return Ok(service.pobierzPrzebieg(id));
        }
    }
}
