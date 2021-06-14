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
    public class RejestracjaController : ControllerBase
    {
        private ZakladyDB database;

        public RejestracjaController(ZakladyDB zaklady)
        {
            this.database = zaklady;
        }

        [HttpGet]
        public IEnumerable<Autoryzacja> GetUsers()
        {
            List<Autoryzacja> temp=new List<Autoryzacja>();
            temp = database.Autoryzacja.ToList();
            return temp;
        }

        [HttpPost]
        public bool Rejestracja([FromBody] Autoryzacja autoryzacja)
        {
            try
            {
                autoryzacja.Rola = "Klient";
                database.Autoryzacja.Add(autoryzacja);
                database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
