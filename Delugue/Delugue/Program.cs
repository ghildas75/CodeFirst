using System;

namespace Delugue
{
    class Program
    {
        //declaration de type de delugue
        public delegate void typeDelegue();
        public delegate int typeDelegueParm(int val);
        public static void Traitement1() { Console.WriteLine("code traitement1"); }
        public static void Traitement2() { Console.WriteLine("code traitement 2"); }
        public static int Carre(int val) { return val * val; }
        static void Main(string[] args)
        {
            /* Action<String> affiche = s => Console.WriteLine(s);
           affiche("Hello World!");*/
            Console.WriteLine("appel via la methode");
            Traitement1();
            typeDelegue Odel;
            Odel = new typeDelegue(Traitement1);
            Odel();
            Console.WriteLine("----------------------");
            Odel += new typeDelegue(Traitement2);
            Odel();
            Console.WriteLine("---------avec paramatre-------------");
            typeDelegueParm odelParm;
            odelParm = Carre;
            int res = odelParm(5);
            Console.WriteLine("resulat avec parmatre" + res);
           // Console.ReadKey();
            Console.WriteLine("---------avec paramatre-------------");
            typeDelegueParm odelp;
            odelp = new typeDelegueParm(Carre);
            int res2 = odelp(4);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
