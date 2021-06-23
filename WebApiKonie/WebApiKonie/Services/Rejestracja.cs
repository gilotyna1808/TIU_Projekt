using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.DTO;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class Rejestracja:IRejestracja
    {
        private readonly ZakladyDB database;

        public Rejestracja(ZakladyDB zaklady)
        {
            this.database = zaklady;
        }

        public bool Rejestruj(RejestracjaDTO klient)
        {
            Autoryzacja a = new Autoryzacja();
            a.Login = klient.Login;
            a.Password = klient.Password;
            a.Rola = "user";
            database.Autoryzacja.Add(a);
            database.SaveChanges();
            Klient k = new Klient();
            k.Autoryzacja = a;
            k.Email = klient.Email;
            k.Imie = klient.Imie;
            k.Nazwisko = klient.Nazwisko;
            k.StanKonta = klient.StanKonta;
            k.Wiek = klient.Wiek;
            database.Klienci.Add(k);
            database.SaveChanges();
            return true;
        }
    }
}
