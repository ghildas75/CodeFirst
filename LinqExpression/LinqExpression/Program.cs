using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         IEnumerable<int> num  = numbers.Where(x => x % 2 == 0);
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("menthode 2 en utilisant une fonction");

            Func<int, bool> prdicate = x => x % 2 == 0;

            IEnumerable<int> num2 = numbers.Where(prdicate);
            foreach (var item in num2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("menthode 3 en utilisant une fonction");
            IEnumerable<int> num3 = numbers.Where(isEven);
            foreach (var item in num3)
            {
                Console.WriteLine(item);
            }
            //methode select avec deux parametre
            Console.WriteLine("numero est index");
        var number  = numbers.Select((nums, index) => new { number = nums, Index = index })
                .Where(x=>x.number%2==0);


            foreach (var item in number)
            {
                Console.WriteLine("numero" + item.number + "index" + item.Index);
            }
            //si on veux recupere juste les index

            var indexy = number.Select(x=> x.Index);
            foreach (var item in indexy)
            {
                Console.WriteLine("indexy" + item);
            }
            Console.ReadKey();
        }
        private static bool isEven(int n)
        {
            return n%2==0;
        }
    }
}
