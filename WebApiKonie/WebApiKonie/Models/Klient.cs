using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("Klienci")]
    public class Klient
    {
        [Key]
        [Required(ErrorMessage = "Id jest wymagane")]
        public int ID_Klienta { get; set; }
        [ForeignKey("ID_Autoryzacja")]
        public Autoryzacja Autoryzacja { get; set; }
        [Required(ErrorMessage = "Imie jest wymagane")]
        public String Imie { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public String Nazwisko { get; set; }
        [Required(ErrorMessage = "Wiek jest wymagany")]
        public int Wiek { get; set; }
        [Required(ErrorMessage = "Email jest wymagany")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Stan konta jest wymagany")]
        public Decimal StanKonta { get; set; }
    }
}