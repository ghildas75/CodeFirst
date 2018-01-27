using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Voyage
    {
        public Voyage()
        {
            Contrat = new HashSet<Contrat>();
        }

        public decimal VoyNo { get; set; }
        public string VoyDestination { get; set; }
        public DateTime? VoyDateDepart { get; set; }
        public DateTime? VoyDateArrive { get; set; }
        public decimal? VoyRepas { get; set; }
        public decimal? VoyNbPlace { get; set; }
        public string VoyActivite { get; set; }
        public decimal? EmpNo { get; set; }
        public decimal? Hotno { get; set; }
        public decimal? TarifSimple { get; set; }
        public decimal? TarifDouble { get; set; }
        public decimal? TarifTriple { get; set; }
        public decimal? TarifQuadruple { get; set; }
        public decimal? NbChambreRes { get; set; }

        public Employe EmpNoNavigation { get; set; }
        public Hotel HotnoNavigation { get; set; }
        public ICollection<Contrat> Contrat { get; set; }
    }
}
