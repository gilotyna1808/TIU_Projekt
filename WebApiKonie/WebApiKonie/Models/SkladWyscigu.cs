using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiKonie.Models
{
    [Table("SkladyWyscigow")]
    public class SkladWyscigu
    {
        [Key]
        public int ID_Skladu { get; set; }
        [ForeignKey("ID_Wyscigu")]
        public int ID_Wyscigu { get; set; }
        public virtual Kon Kon1 { get; set; }
        public virtual Kon Kon2 { get; set; }
        public virtual Kon Kon3 { get; set; }
        public Kon Kon4 { get; set; }
        public Kon Kon5 { get; set; }
        public double KursKon1 { get; set; }
        public double KursKon2 { get; set; }
        public double KursKon3 { get; set; }
        public double KursKon4 { get; set; }
        public double KursKon5 { get; set; }

    }
}
