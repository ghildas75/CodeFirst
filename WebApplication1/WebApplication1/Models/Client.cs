﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
 
    




    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }
        public string CliPrenom { get; set; }
        public string CliNom { get; set; }
        public DateTime cliDateNaiss { get; set; }
        public string CliRue { get; set; }
        public string CliVille { get; set; }
        public string CliTelephone { get; set; }
    }
}
