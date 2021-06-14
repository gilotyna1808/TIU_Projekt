using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    public class KlientDTO
    {
        public int ID_Klienta { get; set; }
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int Wiek { get; set; }
        public String Email { get; set; }
        public Decimal StanKonta { get; set; }

        public static KlientDTO toKlientDTO(Klient klient) {
            KlientDTO temp=new KlientDTO();
            temp.ID_Klienta = klient.ID_Klienta;
            temp.Imie = klient.Imie;
            temp.Nazwisko = klient.Nazwisko;
            temp.Wiek = klient.Wiek;
            temp.Email = klient.Email;
            temp.StanKonta = klient.StanKonta;
            return temp;
        }

        public static List<KlientDTO> toKlientDTO(List<Klient> klients)
        {
            List<KlientDTO> temp=new List<KlientDTO>();
            foreach(Klient k in klients)
            {
                temp.Add(KlientDTO.toKlientDTO(k));
            }
            return temp;
        }

        public static Klient toKlient(KlientDTO klientDTO)
        {
            Klient temp = new Klient();
            temp.Email = klientDTO.Email;
            temp.Imie = klientDTO.Imie;
            temp.Nazwisko = klientDTO.Nazwisko;
            temp.StanKonta = klientDTO.StanKonta;
            temp.Wiek = klientDTO.Wiek;
            return temp;
        }
    }
}
