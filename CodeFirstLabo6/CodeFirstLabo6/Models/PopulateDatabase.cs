using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstLabo6.Models
{
    public class PopulateDatabase
    {
        public static void EnsurePopulated(Labo6Context context)
        {
            context.Database.EnsureCreated();
            if (context.Clients.Any())
            {
                context.Clients.AddRange(

                new Client { CliPrenom = "Justin", CliNom = "Trudeau", CliDateNaiss = Convert.ToDateTime("2000/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                new Client { CliPrenom = "Stephen", CliNom = "Harper", CliDateNaiss = Convert.ToDateTime("2001/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                new Client { CliPrenom = "Pauline", CliNom = "Marois", CliDateNaiss = Convert.ToDateTime("2002/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                new Client { CliPrenom = "Jean", CliNom = "Charset", CliDateNaiss = Convert.ToDateTime("2003/10/10"), CliRue = "", CliVille = "", CliTelephone = "" }

                    );
            }
        }
    }
}
