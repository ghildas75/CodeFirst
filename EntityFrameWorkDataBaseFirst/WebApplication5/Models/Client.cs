using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Client
    {
        public Client()
        {
            Contrat = new HashSet<Contrat>();
            FaitLeVoyage = new HashSet<FaitLeVoyage>();
        }

        public decimal CliNo { get; set; }
        public string CliPrenom { get; set; }
        public string CliNom { get; set; }
        public string CliRue { get; set; }
        public string CliVille { get; set; }
        public string CliTelephone { get; set; }

        public ICollection<Contrat> Contrat { get; set; }
        public ICollection<FaitLeVoyage> FaitLeVoyage { get; set; }
    }
}
