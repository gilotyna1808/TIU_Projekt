using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogowanieController : ControllerBase
    {
        private ZakladyDB database;

        public LogowanieController(ZakladyDB zaklady)
        {
            this.database = zaklady;
        }

        //Później zmiana z bool na token
        [HttpPost]
        public bool Logowanie([FromBody]Autoryzacja login)
        {
            if (database.Autoryzacja.Where(res => res.Login == login.Login && res.Password == login.Password).Count() == 1) return true;

            return false;
        }
       
    }
}
