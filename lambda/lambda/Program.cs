using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lambda
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int[] nombre =  { 1, 5, 7, 8, 10 };
            int nbrepair = nombre.Count(n => n % 2 == 0);
            Console.WriteLine("nombre paire" + nbrepair);
            var somPQue6 = nombre.Sum((n=> n<6?n:0));
        }
    }
}
