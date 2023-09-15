using System;
namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade du Elin i meter?");
            string Elinshopp = Console.ReadLine();
            double längdtext1 = double.Parse(Elinshopp);
            Console.WriteLine("Hur långt Hoppade du Alva i meter?");
            string Alvashopp = Console.ReadLine();
            double längdtext2 = double.Parse(Alvashopp);
            double Skillnad = längdtext1 - längdtext2;
            Console.WriteLine("Elin hoppade " + Skillnad + " m längre");
            Console.ReadKey();
        }
    }
}
