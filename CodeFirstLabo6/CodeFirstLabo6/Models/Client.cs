using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstLabo6.Models
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }
        public string CliPrenom { get; set; }
        public string CliNom { get; set; }
        public DateTime CliDateNaiss { get; set; }
        public string CliRue { get; set; }
        public string CliVille{ get; set; }
        public string CliTelephone { get; set; }


    }
}
