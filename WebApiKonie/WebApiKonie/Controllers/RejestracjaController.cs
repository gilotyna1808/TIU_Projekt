using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.DTO;
using WebApiKonie.Models;
using WebApiKonie.Services;

namespace WebApiKonie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RejestracjaController : ControllerBase
    {
        private readonly IRejestracja service;

        public RejestracjaController(IRejestracja rejestracja)
        {
            this.service = rejestracja;
        }

        [HttpPost]
        public ActionResult<bool> post(RejestracjaDTO rejestracja)
        {
            return Ok(service.Rejestruj(rejestracja));
        }
    }
}
