using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("Konie")]
    public class Kon
    {
        [Key]
        [Required(ErrorMessage = "Id jest wymagane")]
        public int ID_Konia { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public String Nazwa { get; set; }
        [Required(ErrorMessage = "Wiek jest wymagany")]
        public int Wiek { get; set; }
        [Required(ErrorMessage = "Kraj pochodzenia jest wymagany")]
        public String Kraj { get; set; }
        [Required(ErrorMessage = "Kondycja jest wymagana")]
        public int Kondycja { get; set; }
        [Required(ErrorMessage = "Predkosc jest wymagana")]
        public int Predkosc { get; set; }
    }
}
