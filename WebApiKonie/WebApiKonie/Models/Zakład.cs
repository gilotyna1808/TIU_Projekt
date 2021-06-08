using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("Zaklady")]
    public class Zakład
    {
        [Key]
        [Required(ErrorMessage = "Id jest wymagane")]
        public int ID_Zakladu { get; set; }
        [ForeignKey("ID_Klienta")]
        [Required(ErrorMessage = "Klient jest wymagany")]
        public Klient Klient { get; set; }
        [ForeignKey("ID_Wyscigu")]
        [Required(ErrorMessage = "Wyscig jest wymagany jest wymagane")]
        public Wyscig Wyscig { get; set; }
        [Required(ErrorMessage = "Kwota jest wymagana")]
        Decimal KwotaZakladu { get; set; }
        [Required(ErrorMessage = "Kurs jest wymagany")]
        public double Kurs { get; set; }
        public bool Wygrany { get; set; }
        public bool Wyplacony { get; set; }
    }
}
