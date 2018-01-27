using System;
using System.Collections.Generic;
using System.Linq;
namespace ProjetLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcalaration de data source
            int[] data = new int[] { 60, 65, 20, 30 };
            //linq query
            var req1 = from num in data
                       where (num < 50)
                       orderby (num) descending
                       select num;

            foreach (var n in req1)
            {
                Console.WriteLine("requete"+n);
            }
            Console.ReadKey();
        }
        IList<Etudiant> etudiants = new List<Etudiant>
        {
            new Etudiant{ id=1, nom="samir", age=25},
            new Etudiant{ id=2, nom="ghilas", age=35},
       };

        // query syntax
        var req2 = from e in etudiants
                   where (e.age > 20)
                   select e;
    }
}
