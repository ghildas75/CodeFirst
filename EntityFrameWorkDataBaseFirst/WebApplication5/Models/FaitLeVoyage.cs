using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class FaitLeVoyage
    {
        public decimal ConNo { get; set; }
        public decimal CliNo { get; set; }

        public Client CliNoNavigation { get; set; }
        public Contrat ConNoNavigation { get; set; }
    }
}
