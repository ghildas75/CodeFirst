using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBYASCDESC
{
    class Program
    {
        static void Main(string[] args)
        {

          IOrderedEnumerable<Student> result=  Student.GetAllStudents().OrderBy(s => s.Name);
            foreach (Student st in result)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("------2eme methode");
            IEnumerable<String> req = from Student s in Student.GetAllStudents()
                      orderby s.Name
                      select s.Name;
           var y= Student.GetAllStudents().OrderByDescending(s => s.Name);
            IEnumerable<String> req2 = from Student s in Student.GetAllStudents()
                                      orderby s.Name descending
                                      select s.Name;
            foreach (String s in req2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("3 order ordonne en premier par total en deuxieme par nom en dernier id");
            var x = Student.GetAllStudents().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenByDescending(s => s.StudentID);
            foreach(Student s in x)
            {
                Console.WriteLine(s.TotalMarks + "\t" + s.Name + "\t" + s.StudentID);
            }
            var x2 = from Student s in Student.GetAllStudents()
                     orderby s.Name, s.TotalMarks, s.TotalMarks descending
                     select s;
            // Since we are using Count() operator, the LINQ Query is executed at this point
            List<Student> listStudents = Student.GetAllStudents();
            int resulta = (from student in listStudents
                          where student.TotalMarks == 800
                          select student).Count();

            // Adding a new student object with TotalMarks = 800 to the source
            // will have no effect on the result as the query is already executed
            listStudents.Add(new Student { StudentID = 104, Name = "Tim", TotalMarks = 800 });

            // The above query is executed at the point where it is defined.
            // This is proved as Tim is not included in the count
            Console.WriteLine("Students with Total Marks = 800 : " + resulta)
           Console.ReadKey();
        }
    }
}
