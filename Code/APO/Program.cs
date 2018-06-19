using System;
using static APO.Substitution;

namespace APO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pricer pricer = new Pricer();
            double prix = pricer.Price();

            Console.WriteLine("Prix forward = " + prix);

            Console.Read();
        }

        //static void Main(string[] args)
        //{
        //    //Initialisation Pricer
        //    PricerEngine engine = new PricerEngine();

        //    while (true)
        //    {
        //        Console.WriteLine("******************************");
        //        // Choix utilisateur
        //        Console.WriteLine("Voulez vous pricer :");
        //        Console.WriteLine("1- Forward");
        //        Console.WriteLine("Entrez le numero de votre choix ?");
        //        string choix = Console.ReadLine();
        //        if (choix == "1")
        //        {
        //            double forwardPrice = engine.Price("Forward");
        //            Console.WriteLine("Prix forward = " + forwardPrice);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Choix inconnu !");
        //        }
        //        Console.WriteLine("******************************");
        //        Console.WriteLine();
        //    }
        //}
    }
}
