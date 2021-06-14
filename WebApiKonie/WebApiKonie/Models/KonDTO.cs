using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    public class KonDTO
    {
        public int ID_Konia { get; set; }
        public String Nazwa { get; set; }
        public int Wiek { get; set; }
        public String Kraj { get; set; }
        public int Kondycja { get; set; }
        public int Predkosc { get; set; }

        public static KonDTO toKonDTO(Kon kon)
        {
            KonDTO temp=new KonDTO();

            temp.ID_Konia = kon.ID_Konia;
            temp.Kondycja = kon.Kondycja;
            temp.Kraj = kon.Kraj;
            temp.Nazwa = kon.Nazwa;
            temp.Predkosc = kon.Predkosc;
            temp.Wiek = kon.Wiek;
            return temp;
        }

        public static List<KonDTO>toKonDTO(List<Kon> konie)
        {
            List<KonDTO> temp = new List<KonDTO>();

            foreach(Kon k in konie)
            {
                temp.Add(toKonDTO(k));
            }

            return temp;
        }

        public static Kon toKon(KonDTO kon)
        {
            Kon temp = new Kon();
            //temp.ID_Konia = kon.ID_Konia; //Bez id bo bazadanych sama przydizela ID
            temp.Kondycja = kon.Kondycja;
            temp.Kraj = kon.Kraj;
            temp.Nazwa = kon.Nazwa;
            temp.Predkosc = kon.Predkosc;
            temp.Wiek = kon.Wiek;
            return temp;
        }
    }
}
