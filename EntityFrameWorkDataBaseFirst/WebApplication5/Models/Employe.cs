using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Employe
    {
        public Employe()
        {
            Contrat = new HashSet<Contrat>();
            Voyage = new HashSet<Voyage>();
        }

        public decimal EmpNo { get; set; }
        public string EmpPrenom { get; set; }
        public string EmpNom { get; set; }
        public string EmpEmploi { get; set; }
        public decimal? EmpSal { get; set; }
        public decimal? EmpComm { get; set; }
        public decimal? EmpSup { get; set; }
        public string EmpBureau { get; set; }

        public ICollection<Contrat> Contrat { get; set; }
        public ICollection<Voyage> Voyage { get; set; }
    }
}
