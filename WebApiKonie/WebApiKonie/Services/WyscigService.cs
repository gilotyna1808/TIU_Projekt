using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class WyscigService : IWyscigService
    {
        ZakladyDB database;

        public WyscigService(ZakladyDB zaklady)
        {
            database = zaklady;
        }


        public bool dodajWyscig(WyscigDTO wyscig)
        {

            Wyscig tempWyscig = new Wyscig();
            tempWyscig.DateTime = wyscig.DateTime;
            tempWyscig.Wygrany = null;
            tempWyscig.Zakonczony = wyscig.Zakonczony;
            database.Wyscigi.Add(tempWyscig);
            database.SaveChanges();
            SkladWyscigu tempSklad = new SkladWyscigu();
            tempSklad.ID_Wyscigu = tempWyscig.ID_Wyscigu;
            tempSklad.Kon1 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon1).Single();
            tempSklad.Kon2 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon2).Single();
            tempSklad.Kon3 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon3).Single();
            tempSklad.Kon4 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon4).Single();
            tempSklad.Kon5 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon5).Single();
            tempSklad.KursKon1 = wyscig.KursKon1;
            tempSklad.KursKon2 = wyscig.KursKon2;
            tempSklad.KursKon3 = wyscig.KursKon3;
            tempSklad.KursKon4 = wyscig.KursKon4;
            tempSklad.KursKon5 = wyscig.KursKon5;
            database.SkladWyscigow.Add(tempSklad);
            database.SaveChanges();
            return true;
        }

        public bool modyfikujWyscig(WyscigDTO wyscig)
        {
            Wyscig tempWyscig = database.Wyscigi.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single();
            tempWyscig.DateTime = wyscig.DateTime;
            if(wyscig.Wygrany!=0 && wyscig.Wygrany!=null) tempWyscig.Wygrany = database.Konie.Where(s => s.ID_Konia == wyscig.Wygrany).Single();
            else tempWyscig.Wygrany = null;
            tempWyscig.Zakonczony = wyscig.Zakonczony;
            database.SaveChanges();
            SkladWyscigu tempSklad = database.SkladWyscigow.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single();
            tempSklad.Kon1 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon1).Single();
            tempSklad.Kon2 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon2).Single();
            tempSklad.Kon3 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon3).Single();
            tempSklad.Kon4 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon4).Single();
            tempSklad.Kon5 = database.Konie.Where(s => s.ID_Konia == wyscig.Kon5).Single();
            tempSklad.KursKon1 = wyscig.KursKon1;
            tempSklad.KursKon2 = wyscig.KursKon2;
            tempSklad.KursKon3 = wyscig.KursKon3;
            tempSklad.KursKon4 = wyscig.KursKon4;
            tempSklad.KursKon5 = wyscig.KursKon5;
            database.SaveChanges();
            return true;
        }

        public WyscigDTO pobierzWyscig(int id)
        {
            var wyscig = database.Wyscigi.Include(x=>x.Wygrany).Where(s => s.ID_Wyscigu == id).SingleOrDefault();
            var sklad = database.SkladWyscigow.Include(x => x.Kon1).Include(x => x.Kon2).Include(x => x.Kon3).Include(x => x.Kon4).Include(x => x.Kon5).Where(s => s.ID_Wyscigu == id).Single();
            return WyscigDTO.toWyscigDTO(wyscig,sklad);
        }

        public IEnumerable<WyscigDTO> pobierzWyscigi()
        {
            var wyscig = database.Wyscigi.Include(x => x.Wygrany).ToList();
            List<SkladWyscigu> sklad = new List<SkladWyscigu>();
            foreach(Wyscig w in wyscig)
            {
                sklad.Add(database.SkladWyscigow.Include(x => x.Kon1).Include(x => x.Kon2).Include(x => x.Kon3).Include(x => x.Kon4).Include(x => x.Kon5).Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single());
            }
            return WyscigDTO.toWyscigDTO(wyscig, sklad);
        }
    }
}
