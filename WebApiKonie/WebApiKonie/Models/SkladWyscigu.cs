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
        public Kon Kon1 { get; set; }
        public Kon Kon2 { get; set; }
        public Kon Kon3 { get; set; }
        public Kon Kon4 { get; set; }
        public Kon Kon5 { get; set; }
        public int KursKon1 { get; set; }
        public int KursKon2 { get; set; }
        public int KursKon3 { get; set; }
        public int KursKon4 { get; set; }
        public int KursKon5 { get; set; }

    }
}
