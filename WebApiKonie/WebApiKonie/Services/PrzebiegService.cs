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
    }
}
