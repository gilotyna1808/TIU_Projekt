using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    public class LogowanieDTO
    {
        public int ID_Autoryzacja { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Rola { get; set; }

        public static LogowanieDTO toLogowanieDTO(Autoryzacja autoryzacja)
        {
            LogowanieDTO temp = new LogowanieDTO();
            temp.ID_Autoryzacja = autoryzacja.ID_Autoryzacja;
            temp.Login = autoryzacja.Login;
            temp.Password = autoryzacja.Password;
            temp.Rola = autoryzacja.Rola;
            return temp;
        }

        public static List<LogowanieDTO> toLogowanieDTO(List<Autoryzacja> autoryzacje)
        {
            List<LogowanieDTO> temp = new List<LogowanieDTO>();
            foreach(Autoryzacja a in autoryzacje)
            {
                temp.Add(LogowanieDTO.toLogowanieDTO(a));
            }
            return temp;
        }

        public static Autoryzacja toLogowanie(LogowanieDTO autoryzacjaDTO)
        {
            Autoryzacja temp = new Autoryzacja();
            temp.Login = autoryzacjaDTO.Login;
            temp.Password = autoryzacjaDTO.Password;
            temp.Rola = autoryzacjaDTO.Rola;
            return temp;
        }

    }
}
