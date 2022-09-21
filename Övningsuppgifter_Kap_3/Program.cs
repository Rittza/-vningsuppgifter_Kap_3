using System;
namespace Övningsuppgfiter_kap_3
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilken plats kom du på i den senaste idrottsturneringen du deltog i ?");
            string plats = Console.ReadLine();

            switch (plats)
            {
                case "1":
                    Console.WriteLine("Du fick guld");
                    break;
                case "2":
                    Console.WriteLine("Du fick silver");
                    break;
                case"3":
                    Console.WriteLine("Du fick brons");
                    break;
                default:
                    Console.WriteLine("Du fick tyvärr ingen medalj");
                    break;
            }
        }
    }
}