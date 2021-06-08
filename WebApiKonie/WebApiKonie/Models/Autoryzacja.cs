using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("Autoryzacja")]
    public class Autoryzacja
    {
        [Key]
        [Column("ID_Autoryzacja")]
        [Required(ErrorMessage ="Id jest wymagane")]
        public int ID_Autoryzacja { get; set; }
        
        [Column("Login")]
        [Required(ErrorMessage ="Login jest wymagany")]
        public String Login { get; set; }
        [Column("Password")]
        [Required(ErrorMessage ="Hasło jest wymagane")]
        public String Password { get; set; }
        [Column("Rola")]
        [Required(ErrorMessage ="Rola jest wymagana")]
        public String Rola { get; set; }
    }
}
