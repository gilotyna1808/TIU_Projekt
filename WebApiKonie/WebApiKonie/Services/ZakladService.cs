using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class ZakladService : IZakladService
    {

        private readonly ZakladyDB database;

        public ZakladService(ZakladyDB zaklady)
        {
            this.database = zaklady;
        }

        public bool dodajZaklad(ZakladDTO zaklad)
        {
            Zakład z = new Zakład();
            z.Klient = database.Klienci.Where(s => s.ID_Klienta == zaklad.KlientID).Single();
            z.Kon = database.Konie.Where(s => s.ID_Konia == zaklad.KonWybranyID).Single();
            z.Wyscig = database.Wyscigi.Where(s => s.ID_Wyscigu == zaklad.WyscigID).Single();
            double kurs = 0;
            if (database.SkladWyscigow.Include(x=>x.Kon1).Where(s => s.ID_Wyscigu == zaklad.WyscigID)
                .Where(s => s.Kon1.ID_Konia == zaklad.KonWybranyID).Count() == 1)
            {
                kurs = database.SkladWyscigow.Where(s => s.ID_Wyscigu == zaklad.WyscigID).Single().KursKon1;
            }
            if (database.SkladWyscigow.Include(x => x.Kon2).Where(s => s.ID_Wyscigu == zaklad.WyscigID)
                .Where(s => s.Kon2.ID_Konia == zaklad.KonWybranyID).Count() == 1)
            {
                kurs = database.SkladWyscigow.Where(s => s.ID_Wyscigu == zaklad.WyscigID).Single().KursKon2;
            }
            if (database.SkladWyscigow.Include(x => x.Kon3).Where(s => s.ID_Wyscigu == zaklad.WyscigID)
                .Where(s => s.Kon3.ID_Konia == zaklad.KonWybranyID).Count() == 1)
            {
                kurs = database.SkladWyscigow.Where(s => s.ID_Wyscigu == zaklad.WyscigID).Single().KursKon3;
            }
            if (database.SkladWyscigow.Include(x => x.Kon4).Where(s => s.ID_Wyscigu == zaklad.WyscigID)
                .Where(s => s.Kon4.ID_Konia == zaklad.KonWybranyID).Count() == 1)
            {
                kurs = database.SkladWyscigow.Where(s => s.ID_Wyscigu == zaklad.WyscigID).Single().KursKon4;
            }
            if (database.SkladWyscigow.Include(x => x.Kon5).Where(s => s.ID_Wyscigu == zaklad.WyscigID)
                .Where(s => s.Kon5.ID_Konia == zaklad.KonWybranyID).Count() == 1)
            {
                kurs = database.SkladWyscigow.Where(s => s.ID_Wyscigu == zaklad.WyscigID).Single().KursKon5;
            }
            z.Kurs = kurs;
            z.Wyplacony = false;
            z.KwotaZakladu = zaklad.KwotaZakladu;
            database.Klienci.Where(s => s.ID_Klienta == zaklad.KlientID).Single().StanKonta -= zaklad.KwotaZakladu;
            database.Zaklady.Add(z);
            database.SaveChanges();
            return true;
        }

        public ZakladDTO wyswietlZaklad(int id)
        {
            return ZakladDTO.toZakladDTO(database.Zaklady.Include(x => x.Klient).Include(x => x.Kon).Include(x => x.Wyscig)
                .Where(s=>s.ID_Zakladu==id).Single());
        }

        public IEnumerable<ZakladDTO> wyswietlZaklady()
        {
            return ZakladDTO.toZakladDTO(database.Zaklady.Include(x => x.Klient).Include(x => x.Kon).Include(x => x.Wyscig));
        }

        public IEnumerable<ZakladDTO> wyswietlZakladyKlienta(int id)
        {
            return ZakladDTO.toZakladDTO(database.Zaklady.Include(x => x.Klient).Include(x => x.Kon).Include(x => x.Wyscig)
                .Where(s => s.Klient.ID_Klienta == id));
        }

        public bool zrealizujZaklad(ZakladDTO zaklad)
        {
            Zakład z=database.Zaklady.Include(x=>x.Klient).Where(z=>z.ID_Zakladu==zaklad.ID_Zakladu).Single();
            if (z.Wygrany == true && !z.Wyplacony)
            {
                database.Klienci.Where(s => s.ID_Klienta == z.Klient.ID_Klienta).Single().StanKonta += (z.KwotaZakladu * Convert.ToDecimal(z.Kurs));
                database.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
