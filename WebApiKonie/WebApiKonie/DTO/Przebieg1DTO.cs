using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiKonie.Models;

namespace WebApiKonie.DTO
{
    public class Przebieg1DTO
    {
        public int Kon { get; set; }
        public int Krok { get; set; }
        public int Dystans { get; set; }
        public int DystansSuma { get; set; }

        public static Przebieg1DTO toPrzebieg1DTO(Przebieg przebieg)
        {
            Przebieg1DTO temp = new Przebieg1DTO();
            temp.Kon = przebieg.ID_konia;
            temp.Krok = przebieg.Krok;
            temp.Dystans = przebieg.Dystans;
            temp.DystansSuma = przebieg.DystansSuma;
            return temp;
        }

        public static List<Przebieg1DTO> toPrzebieg1DTO(List<Przebieg> przebieg)
        {
            List<Przebieg1DTO> temp = new List<Przebieg1DTO>();
            foreach(Przebieg p in przebieg)
            {
                temp.Add(toPrzebieg1DTO(p));
            }
            return temp;
        }
    }
}
