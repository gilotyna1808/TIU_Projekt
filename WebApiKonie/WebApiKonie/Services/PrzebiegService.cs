using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.DTO;
using WebApiKonie.Models;

namespace WebApiKonie.Services
{
    public class PrzebiegService : IPrzebiegService
    {
        private readonly ZakladyDB database;

        public PrzebiegService(ZakladyDB zaklady)
        {
            this.database = zaklady;
        }

        public PrzebiegDTO pobierzPrzebieg(int id)
        {
            PrzebiegDTO temp=new PrzebiegDTO();

            int kon1 = database.SkladWyscigow.Include(x=>x.Kon1).Where(s => s.ID_Wyscigu == id).Single().Kon1.ID_Konia;
            int kon2 = database.SkladWyscigow.Include(x => x.Kon2).Where(s => s.ID_Wyscigu == id).Single().Kon2.ID_Konia;
            int kon3 = database.SkladWyscigow.Include(x => x.Kon3).Where(s => s.ID_Wyscigu == id).Single().Kon3.ID_Konia;
            int kon4 = database.SkladWyscigow.Include(x => x.Kon4).Where(s => s.ID_Wyscigu == id).Single().Kon4.ID_Konia;
            int kon5 = database.SkladWyscigow.Include(x => x.Kon5).Where(s => s.ID_Wyscigu == id).Single().Kon5.ID_Konia;
            temp.Kon1 = Przebieg1DTO.toPrzebieg1DTO((database.Przebiegi.Where(s => s.ID_wyscigu == id).Where(s => s.ID_konia == kon1).ToList()));
            temp.Kon2 = Przebieg1DTO.toPrzebieg1DTO((database.Przebiegi.Where(s => s.ID_wyscigu == id).Where(s => s.ID_konia == kon2).ToList()));
            temp.Kon3 = Przebieg1DTO.toPrzebieg1DTO((database.Przebiegi.Where(s => s.ID_wyscigu == id).Where(s => s.ID_konia == kon3).ToList()));
            temp.Kon4 = Przebieg1DTO.toPrzebieg1DTO((database.Przebiegi.Where(s => s.ID_wyscigu == id).Where(s => s.ID_konia == kon4).ToList()));
            temp.Kon5 = Przebieg1DTO.toPrzebieg1DTO((database.Przebiegi.Where(s => s.ID_wyscigu == id).Where(s => s.ID_konia == kon5).ToList()));
            return temp;
        }

        public bool uruchomWyscig(WyscigDTO w)
        {
            SkladWyscigu wyscig = database.SkladWyscigow.Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single();
            Random rnd = new Random();
            Kon kon1 = database.SkladWyscigow.Include(x => x.Kon1).Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single().Kon1;
            Kon kon2 = database.SkladWyscigow.Include(x => x.Kon2).Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single().Kon2;
            Kon kon3 = database.SkladWyscigow.Include(x => x.Kon3).Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single().Kon3;
            Kon kon4 = database.SkladWyscigow.Include(x => x.Kon4).Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single().Kon4;
            Kon kon5 = database.SkladWyscigow.Include(x => x.Kon5).Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single().Kon5;
            int i = 0;
            int krok = 1;
            List<int> sumaDystansow = new List<int>();
            while (i < 2300)
            {
                int rand = rnd.Next(100);
                int dystans = 0;
                if (150 - kon1.Kondycja < rand) dystans = kon1.Predkosc * 10;
                else if (100 - kon1.Kondycja < rand) dystans = kon1.Predkosc * 8;
                else dystans = kon1.Predkosc * 5;
                if (i + dystans >= 2300)
                {
                    sumaDystansow.Add(i + dystans);
                    dystans = 2300 - i;
                    i = 2300;
                }
                else
                {
                    i += dystans;
                }
                Przebieg p = new Przebieg { Dystans = dystans, DystansSuma = i, ID_konia = wyscig.Kon1.ID_Konia, ID_wyscigu = wyscig.ID_Wyscigu, Krok = krok++ };
                database.Przebiegi.Add(p);
            }
            
            i = 0;
            krok = 1;
            while (i < 2300)
            {
                int rand = rnd.Next(100);
                int dystans = 0;
                if (150 - kon2.Kondycja < rand) dystans = kon2.Predkosc * 10;
                else if (100 - kon2.Kondycja < rand) dystans = kon2.Predkosc * 8;
                else dystans = kon2.Predkosc * 5;
                if (i + dystans >= 2300)
                {
                    sumaDystansow.Add(i + dystans);
                    dystans = 2300 - i;
                    i = 2300;
                }
                else
                {
                    i += dystans;
                }
                Przebieg p = new Przebieg { Dystans = dystans, DystansSuma = i, ID_konia = wyscig.Kon2.ID_Konia, ID_wyscigu = wyscig.ID_Wyscigu, Krok = krok++ };
                database.Przebiegi.Add(p);
            }

            i = 0;
            krok = 1;
            while (i < 2300)
            {
                int rand = rnd.Next(100);
                int dystans = 0;
                if (150 - kon3.Kondycja < rand) dystans = kon3.Predkosc * 10;
                else if (100 - kon3.Kondycja < rand) dystans = kon3.Predkosc * 8;
                else dystans = kon3.Predkosc * 5;
                if (i + dystans >= 2300)
                {
                    sumaDystansow.Add(i + dystans);
                    dystans = 2300 - i;
                    i = 2300;
                }
                else
                {
                    i += dystans;
                }
                Przebieg p = new Przebieg { Dystans = dystans, DystansSuma = i, ID_konia = wyscig.Kon3.ID_Konia, ID_wyscigu = wyscig.ID_Wyscigu, Krok = krok++ };
                database.Przebiegi.Add(p);
            }

            i = 0;
            krok = 1;
            while (i < 2300)
            {
                int rand = rnd.Next(100);
                int dystans = 0;
                if (150 - kon4.Kondycja < rand) dystans = kon4.Predkosc * 10;
                else if (100 - kon4.Kondycja < rand) dystans = kon4.Predkosc * 8;
                else dystans = kon4.Predkosc * 5;
                if (i + dystans >= 2300)
                {
                    sumaDystansow.Add(i + dystans);
                    dystans = 2300 - i;
                    i = 2300;
                }
                else
                {
                    i += dystans;
                }
                Przebieg p = new Przebieg { Dystans = dystans, DystansSuma = i, ID_konia = wyscig.Kon4.ID_Konia, ID_wyscigu = wyscig.ID_Wyscigu, Krok = krok++ };
                database.Przebiegi.Add(p);
            }

            i = 0;
            krok = 1;
            while (i < 2300)
            {
                int rand = rnd.Next(100);
                int dystans = 0;
                if (150 - kon5.Kondycja < rand) dystans = kon5.Predkosc * 10;
                else if (100 - kon5.Kondycja < rand) dystans = kon5.Predkosc * 8;
                else dystans = kon5.Predkosc * 5;
                if (i + dystans >= 2300)
                {
                    sumaDystansow.Add(i + dystans);
                    dystans = 2300 - i;
                    i = 2300;
                }
                else
                {
                    i += dystans;
                }
                Przebieg p = new Przebieg { Dystans = dystans, DystansSuma = i, ID_konia = wyscig.Kon5.ID_Konia, ID_wyscigu = wyscig.ID_Wyscigu, Krok = krok++ };
                database.Przebiegi.Add(p);
            }

            int index = sumaDystansow.IndexOf(sumaDystansow.Max());
            if (index == 0) database.Wyscigi.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single().Wygrany = database.Konie.Where(s => s.ID_Konia == wyscig.Kon1.ID_Konia).Single(); 
            else if (index == 1) database.Wyscigi.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single().Wygrany = database.Konie.Where(s => s.ID_Konia == wyscig.Kon2.ID_Konia).Single() ;
            else if (index == 2) database.Wyscigi.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single().Wygrany = database.Konie.Where(s => s.ID_Konia == wyscig.Kon3.ID_Konia).Single() ;
            else if (index == 3) database.Wyscigi.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single().Wygrany = database.Konie.Where(s => s.ID_Konia == wyscig.Kon4.ID_Konia).Single() ;
            else database.Wyscigi.Where(s => s.ID_Wyscigu == wyscig.ID_Wyscigu).Single().Wygrany = database.Konie.Where(s=>s.ID_Konia==wyscig.Kon5.ID_Konia).Single();
            database.Wyscigi.Where(s => s.ID_Wyscigu == w.ID_Wyscigu).Single().Zakonczony = true;
            database.SaveChanges();
            return true;
        }
    }
}
