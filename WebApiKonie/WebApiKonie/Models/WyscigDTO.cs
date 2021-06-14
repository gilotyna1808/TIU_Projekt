using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    public class WyscigDTO
    {
        public int ID_Wyscigu { get; set; }
        public DateTime DateTime { get; set; }
        public bool Zakonczony { get; set; }
        public int Wygrany { get; set; }
        public int Kon1 { get; set; }
        public int Kon2 { get; set; }
        public int Kon3 { get; set; }
        public int Kon4 { get; set; }
        public int Kon5 { get; set; }
        public double KursKon1 { get; set; }
        public double KursKon2 { get; set; }
        public double KursKon3 { get; set; }
        public double KursKon4 { get; set; }
        public double KursKon5 { get; set; }

        public static WyscigDTO toWyscigDTO(Wyscig w, SkladWyscigu s)
        {
            WyscigDTO temp = new WyscigDTO();
            temp.DateTime = w.DateTime;
            temp.ID_Wyscigu = w.ID_Wyscigu;
            temp.Kon1 = s.Kon1.ID_Konia;
            temp.Kon2 = s.Kon2.ID_Konia;
            temp.Kon3 = s.Kon3.ID_Konia;
            temp.Kon4 = s.Kon4.ID_Konia;
            temp.Kon5 = s.Kon5.ID_Konia;
            temp.KursKon1 = s.KursKon1;
            temp.KursKon2 = s.KursKon2;
            temp.KursKon3 = s.KursKon3;
            temp.KursKon4 = s.KursKon4;
            temp.KursKon5 = s.KursKon5;
            if(w.Wygrany!=null) temp.Wygrany = w.Wygrany.ID_Konia;
            temp.Zakonczony = w.Zakonczony;
            return temp;
        }

        public static List<WyscigDTO> toWyscigDTO(List<Wyscig>w, List<SkladWyscigu>s)
        {
            List<WyscigDTO> temp = new List<WyscigDTO>();

            int i = 0;
            foreach(Wyscig x in w)
            {
                temp.Add(WyscigDTO.toWyscigDTO(x, s[i++]));
            }

            return temp;
        }
    }
}
