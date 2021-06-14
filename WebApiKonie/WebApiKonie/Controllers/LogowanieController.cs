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
    public class LogowanieController : ControllerBase
    {
        private readonly ILogowanieService logowanieService;

        public LogowanieController(ZakladyDB zaklady)
        {
            this.logowanieService = new LogowanieService(zaklady);
        }

        //Później zmiana z bool na token
        [HttpPost]
        public ZalogowanyUzytkownikDTO Logowanie([FromBody]LogowanieDTO login)
        {
            var zalogowanyUzytkownik = logowanieService.Login(login);
            return zalogowanyUzytkownik;
        }
       
    }
}
