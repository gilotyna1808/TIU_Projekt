using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.DTO
{
    public class RejestracjaDTO
    {
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int Wiek { get; set; }
        public String Email { get; set; }
        public Decimal StanKonta { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Rola { get; set; }
    }
}
