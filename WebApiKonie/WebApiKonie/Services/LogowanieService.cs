using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class LogowanieService : ILogowanieService
    {
        private static ZakladyDB database;

        public LogowanieService(ZakladyDB zaklady)
        {
            database = zaklady;
        }
        public ZalogowanyUzytkownikDTO Login(LogowanieDTO login)
        {
            var uzytkownikZalogowany = new ZalogowanyUzytkownikDTO();
            if(database.Autoryzacja.Where(res=>res.Login==login.Login && res.Password==login.Password && res.Rola=="admin").Count()==1)
            {
                uzytkownikZalogowany.Rola = "admin";
            }else if(database.Autoryzacja.Where(res => res.Login == login.Login && res.Password == login.Password && res.Rola == "user").Count() == 1)
            {
                uzytkownikZalogowany.Rola = "user";
                int idAut = database.Autoryzacja.Where(res => res.Login == login.Login && res.Password == login.Password).Single().ID_Autoryzacja;
                uzytkownikZalogowany.ID = database.Klienci.Where(s => s.Autoryzacja.ID_Autoryzacja == idAut).Single().ID_Klienta;
            }
            else
            {
                throw new Exception("Bledny login lub haslo");
            }
            var klucz = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bardzotrudnehaslotokena"));
            var zaszyfrowanyKlucz = new SigningCredentials(klucz, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken("http://localhost:44350", null, new List<Claim> { new Claim(ClaimTypes.Role, uzytkownikZalogowany.Rola) },
                null, DateTime.Now.AddMinutes(30), zaszyfrowanyKlucz);
            uzytkownikZalogowany.Token = new JwtSecurityTokenHandler().WriteToken(token);
            return uzytkownikZalogowany;
        }
    }
}
