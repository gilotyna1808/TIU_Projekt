using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("Wyscigi")]
    public class Wyscig
    {
        [Key]
        [Required(ErrorMessage ="Id jest wymagane")]
        public int ID_Wyscigu { get; set; }
        [Required(ErrorMessage = "Skład jest wymagany")]
        SkladWyscigu SkladWyscigu { get; set; }
        [Required(ErrorMessage = "Data jest wymagana")]
        public DateTime DateTime { get; set; }
        public bool Zakonczony { get; set; }
        public Kon Wygrany { get; set; }

    }
}
