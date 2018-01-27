using System;
using System.Collections.Generic;
using System.Linq;


namespace Labo5
{
    class Program
    {
        public static List<Employe> employes = new List<Employe>();
        public static List<Contrat> contrats = new List<Contrat>();
        static void Main(string[] args)
        {

            // Remplir la liste des employés
            employes.Add(new Employe(1001, "toto", "LeBeau", 777));
            employes.Add(new Employe(1002, "France", "Bedard", 14.5));
            employes.Add(new Employe(1003, "Jean", "Sergio", 8.50));
            employes.Add(new Employe(1004, "Martin", "Cochon", 278.5));
            employes.Add(new Employe(1005, "Martine", "Lachance", 850));
            employes.Add(new Employe(1006, "Claude", "Coté", 77));
            employes.Add(new Employe(1007, "Lise", "Lavoie", 770));
            employes.Add(new Employe(1008, "Marc", "Bodormir", 75));
            employes.Add(new Employe(1009, "Marcel", "LeBeau", 777));
            employes.Add(new Employe(1010, "Paul", "Coté", 150.5));
            employes.Add(new Employe(1011, "Angelique", "Lavoie", 87.5));
            employes.Add(new Employe(1012, "Angele", "Vitiro", 77.5));
            employes.Add(new Employe(1013, "Virgule", "Deguillemets", 377));
            employes.Add(new Employe(1014, "Ti", "LeBeau", 475));

            // Remplir la liste des contrats
            contrats.Add(new Contrat(404001, 250.00, 1006));
            contrats.Add(new Contrat(404002, 125.00, 1003));
            contrats.Add(new Contrat(404003, 225.00, 1003));
            contrats.Add(new Contrat(404004, 325.00, 1005));
            contrats.Add(new Contrat(404005, 425.00, 1003));
            contrats.Add(new Contrat(404006, 255.00, 1007));
            contrats.Add(new Contrat(404007, 258.00, 1006));
            contrats.Add(new Contrat(404008, 325.00, 1008));
            contrats.Add(new Contrat(404009, 265.00, 1006));
            contrats.Add(new Contrat(404010, 275.00, 1005));
            contrats.Add(new Contrat(404011, 525.00, 1005));
            contrats.Add(new Contrat(404012, 625.00, 1003));
            contrats.Add(new Contrat(404013, 525.00, 1005));
            contrats.Add(new Contrat(404014, 625.00, 1007));
            contrats.Add(new Contrat(404015, 325.00, 1006));
            contrats.Add(new Contrat(404016, 275.00, 1006));
            contrats.Add(new Contrat(404017, 25.00, 1003));
            contrats.Add(new Contrat(404018, 25.00, 1003));

            var req3 = from e in employes select e;
            Console.WriteLine("-----requete-3----------------");
            //// Ici, la classe de unProf n'est pas anonyme. Il s'agit d'une instance de la classe Professeur
            foreach (Employe unEmploye in req3)
               {
                   Console.WriteLine("{0}: {1}, {2},{3}",unEmploye.numero, unEmploye.prenom, unEmploye.nom, unEmploye.salaire);
               }
            Console.WriteLine("------------requete 4---------------");
            var req4 = from employe in employes
                       select new { employe.prenom, employe.nom };

            foreach (var e in req4)
            {
                Console.WriteLine("{0},{1}", e.prenom, e.nom);
            }
            //requete 5
            Console.WriteLine("-----requete 5-----------------");
            var req5 = from em in employes
                         where em.salaire<150
                          select new{ em.nom,em.prenom,em.salaire}; // Ce qu'on doit sélectionner

            foreach ( var ey in req5)
            {
                Console.WriteLine("{0},{1},{2},", ey.nom, ey.prenom, ey.salaire);

            }
           
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
