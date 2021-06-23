using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    public class ZakladDTO
    {
        public int ID_Zakladu { get; set; }
        public int KlientID { get; set; }
        public int WyscigID { get; set; }
        public int KonWybranyID { get; set; }
        public Decimal KwotaZakladu { get; set; }
        public double Kurs { get; set; }
        public bool? Wygrany { get; set; }
        public bool Wyplacony { get; set; }


        public static ZakladDTO toZakladDTO(Zakład zakład)
        {
            ZakladDTO temp = new ZakladDTO();
            temp.ID_Zakladu = zakład.ID_Zakladu;
            temp.KlientID = zakład.Klient.ID_Klienta;
            temp.KonWybranyID = zakład.Kon.ID_Konia;
            temp.Kurs = zakład.Kurs;
            temp.KwotaZakladu = zakład.KwotaZakladu;
            temp.Wygrany = zakład.Wygrany;
            temp.Wyplacony = zakład.Wyplacony;
            temp.WyscigID = zakład.Wyscig.ID_Wyscigu;
            return temp;
        }

        public static IEnumerable<ZakladDTO> toZakladDTO(IEnumerable<Zakład> zaklady)
        {
            List<ZakladDTO> temp=new List<ZakladDTO>();
            foreach(Zakład z in zaklady)
            {
                temp.Add(toZakladDTO(z));
            }
            return temp;
        }
    }
}
