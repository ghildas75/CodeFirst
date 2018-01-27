using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Contrat
    {
        public Contrat()
        {
            FaitLeVoyage = new HashSet<FaitLeVoyage>();
        }

        public decimal ConNo { get; set; }
        public DateTime? ConDate { get; set; }
        public decimal? ConAcompte { get; set; }
        public decimal? ConMontant { get; set; }
        public decimal? ConPaye { get; set; }
        public decimal? ConTypeOcc { get; set; }
        public decimal? EmpNo { get; set; }
        public decimal? VoyNo { get; set; }
        public decimal? CliNo { get; set; }

        public Client CliNoNavigation { get; set; }
        public Employe EmpNoNavigation { get; set; }
        public Voyage VoyNoNavigation { get; set; }
        public ICollection<FaitLeVoyage> FaitLeVoyage { get; set; }
    }
}
