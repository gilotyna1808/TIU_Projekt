using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.DTO
{
    public class PrzebiegDTO
    {
        public List<Przebieg1DTO> Kon1 { get; set; }
        public List<Przebieg1DTO> Kon2 { get; set; }
        public List<Przebieg1DTO> Kon3 { get; set; }
        public List<Przebieg1DTO> Kon4 { get; set; }
        public List<Przebieg1DTO> Kon5 { get; set; }
    }
}
