using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Voyage = new HashSet<Voyage>();
        }

        public decimal HotNo { get; set; }
        public string HotNom { get; set; }
        public decimal? HotCote { get; set; }
        public string HotPiscine { get; set; }
        public decimal? HotNbChambreTot { get; set; }

        public ICollection<Voyage> Voyage { get; set; }
    }
}
