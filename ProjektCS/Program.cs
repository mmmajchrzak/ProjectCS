using System;

namespace ProjektCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zmienną a: ");
            double a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj zmienną b: ");
            double b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj zmienną c: ");
            double c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj zmienną d: ");
            double d = Int32.Parse(Console.ReadLine());
            double wynik = ((4 * a) + (Math.Sqrt(b * c))) / ((Math.Log(d)) - Math.Cos((b / c)));
            Console.WriteLine("Wynik działania wynosi:{0} ", wynik);
        }
        
    }
}
