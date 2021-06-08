using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("Przebiegi")]
    public class Przebieg
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID_Wyscigu")]
        [Required(ErrorMessage = "Id wyścigu jest wymagane")]
        public int ID_wyscigu { get; set; }
        [ForeignKey("ID_Konia")]
        [Required(ErrorMessage = "Id konia jest wymagane")]
        public int ID_konia { get; set; }
        [Required(ErrorMessage = "Krok jest wymagany")]
        public int Krok { get; set; }
        [Required(ErrorMessage = "Dystans jest wymagany")]
        public int Dystans { get; set; }
        [Required(ErrorMessage = "Suma przebytego dystansu jest wymagana")]
        public int DystansSuma { get; set; }
    }
}
