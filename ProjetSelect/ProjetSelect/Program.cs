using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSelect
{
    class Program
    {
        static void Main(string[] args)
        {
         IEnumerable<String> subject=   Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string item in subject)
            {
                Console.WriteLine(item);
            }
            var y = from st in Student.GetAllStudetns()
                    from sub in st.Subjects
                    select subject;
            //recuper les subject differnet
            Console.WriteLine("elimnier les duplicat");

            var subDiffernt = Student.GetAllStudetns().SelectMany(s => s.Subjects).Distinct();

            var subdiffernt2 = (from s in Student.GetAllStudetns()
                               from sub in s.Subjects
                               select sub).Distinct();
            
            foreach( var s in subDiffernt)
            {
                Console.WriteLine(s);
            }
            //recuperer le sujet pour chaque client
            Console.WriteLine("sujet pour chaque etudiant");
           var sujet= Student.GetAllStudetns().SelectMany(s => s.Subjects, (stduent, sub) =>
                new
                {
               name=stduent.Name,
               sujetName=sub
                });
            foreach (var item in sujet)
            {
                Console.WriteLine(item.name + "\t" + item.sujetName);
            }
            var sujet2 = from stud in Student.GetAllStudetns()
                         from suj in stud.Subjects
                         select new
                         {
                             name = stud.Name,
                             sujetName = suj
                         };
            Console.WriteLine("differnce entre select et select Many");
            IEnumerable<List<String>> s7 = Student.GetAllStudetns().Select(s => s.Subjects);
            //il le faut deux boucle pour parcourir la liste dans une autre liste
            foreach( List<String> s in s7)
            {
              foreach( string stre in s)
                {
                    Console.WriteLine(stre);
                }
            }
            
            //avec select many on a besoin d'une seule boucle foreach

            /*string[] stringArray =
{
    "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
    "0123456789"
};
       IEnumerable<char> st2=    stringArray.SelectMany(s => s);
            foreach (char item in st2)
            {
                Console.WriteLine(item);

                var y2 = from s in stringArray
                        from c in s
                        select c;*/

            Console.WriteLine("------------------------");
            Console.WriteLine("class employee");
        IEnumerable<int> em=  Employee.GetAllEmployees().Select(e => e.EmployeeID);
            foreach (var item in em)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("requete select avec une classe annonyme");
            //recuper le first name et le gender
            var em2 = Employee.GetAllEmployees().Select(e => new {prenom=e.FirstName,gendre=e.Gender });
            foreach (var item in em2)
            {
                Console.WriteLine(item.prenom + "\t" + item.gendre);
            }
            Console.WriteLine("------------------------------");
            // recuperer le nom prenom et salaire mensulle
            var em3 = Employee.GetAllEmployees().Select(e => new
            {
                nomComplet = e.FirstName + " " + e.LastName,
                salaireMensuelle = e.AnnualSalary / 12
            });
            Console.WriteLine("------------------------------");
            foreach (var item in em3)
            {
                Console.WriteLine(item.nomComplet + "\t" + item.salaireMensuelle);
            }
            Console.WriteLine("------------------------------");
            //reqeute augumenter le bonus pour les employe dans le salaire est superieur 50000
            var em4 = Employee.GetAllEmployees().Where(e => e.AnnualSalary > 50000).Select(e => new
            {
             name=e.FirstName,
             salary=e.AnnualSalary,
             bonus=e.AnnualSalary*.1
            });
            Console.WriteLine("------------------------------");
            Console.WriteLine("requete  select where ajout de bonus");
            foreach (var item in em4)
            {
                Console.WriteLine(item.name + "\t" + item.salary + "\t" + item.bonus);
            }
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}
