using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static List<string> inventory = new List<string>();

    static void Main(string[] args)
    {

        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");



        while (true)
        {

            Console.WriteLine("\nVälj en åtgärd:");

            Console.WriteLine("1. Lägg till produkt");

            Console.WriteLine("2. Visa inventarie");

            Console.WriteLine("3. Ta bort produkt");

            Console.WriteLine("4. Sök produkt");



            string val = Console.ReadLine();

            switch (val)
            {

                case "1":

                    LäggTillProdukt();

                    break;

                case "2":

                    VisaInventarie();

                    break;

                case "3":
                    TaBortProdukt();
                    break;

                case "4":
                    SökProdukt();
                    break;

                default:

                    Console.WriteLine("Ogiltigt val. Försök igen.");

                    break;

            }

        }

    }

    static void LäggTillProdukt()
    {

        // TODO: Implementera metod för att lägga till produkt

    }

    static void VisaInventarie()
    {

        // TODO: Implementera metod för att visa inventarie

    }

    static void TaBortProdukt()
    {
        Console.WriteLine("Ange produkten du vill ta bort:  ");
        Console.WriteLine();
        string name = Console.ReadLine();
    
        if (inventory.Contains(name))
        {
            inventory.Remove(name);
            Console.WriteLine($"Du tog bort {name}.");
        }
        else
        {
            Console.WriteLine($"Produkten {name} du beskrev finns ej med. Försök igen.");
        }
       
    }

    static void SökProdukt()
    {

    }

}
