using System;
using System.Linq;
namespace projetGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeGroups = Employee.GetAllEmployees()
                                        .GroupBy(x => new { x.Department, x.Gender })
                                        .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                                        .Select(g => new
                                        {
                                            Dept = g.Key.Department,
                                            Gender = g.Key.Gender,
                                            Employees = g.OrderBy(x => x.Name)
                                        });

            foreach (var group in employeeGroups)
            {
                Console.WriteLine("{0} department {1} employees count = {2}",
                    group.Dept, group.Gender, group.Employees.Count());
                Console.WriteLine("--------------------------------------------");
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Gender
                        + "\t" + employee.Department);
                }
                Console.WriteLine(); Console.WriteLine();
                var employeeGroups = from employee in Employee.GetAllEmployees()
                                     group employee by new
                                     {
                                         employee.Department,
                                         employee.Gender
                                     } into eGroup
                                     orderby eGroup.Key.Department ascending,
                                                   eGroup.Key.Gender ascending
                                     select new
                                     {
                                         Dept = eGroup.Key.Department,
                                         Gender = eGroup.Key.Gender,
                                         Employees = eGroup.OrderBy(x => x.Name)
                                     };

            }
            var lst=   Employee.GetAllEmployees().GroupBy(x => x.Department);
            foreach(var ls in lst)
            {
                Console.WriteLine(ls.Key + "\t");
                foreach (var h in ls)
                {
                    Console.WriteLine(h.Name);
                }

            }
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            var employeeGroup = from employee in Employee.GetAllEmployees()
                               group employee by employee.Department;

            foreach (var group in employeeGroup)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());
            }
            Console.WriteLine("Hello World!");
            var employeeGroup2 = from employee in Employee.GetAllEmployees()
                                group employee by employee.Department;

            foreach (var group in employeeGroup2)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());
                Console.WriteLine("----------");
                foreach (var employee in group)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }
                Console.WriteLine(); Console.WriteLine();
            }
            var employeeGroup3 = from employee in Employee.GetAllEmployees()
                                group employee by employee.Department into eGroup
                                orderby eGroup.Key
                                select new
                                {
                                    Key = eGroup.Key,
                                    Employees = eGroup.OrderBy(x => x.Name)
                                };

            foreach (var group in employeeGroup3)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Employees.Count());
                Console.WriteLine("----------");
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }
                Console.WriteLine(); Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
