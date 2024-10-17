using System.Net.Security;

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
        Console.Write("Ange namn: ");
        string name = Console.ReadLine();

        if (!string.IsNullOrEmpty(name))
        {
            inventory.Add(name);
            Console.WriteLine($"Produkten {name} lades till!");
        }

        else
        {
            Console.WriteLine("Namnet kan inte vara tomt");
        }
    }

    static void VisaInventarie()
    {
        Console.Clear();
        foreach (var item in inventory) 
        {
            Console.WriteLine($"{item} hittades!");
        }
        // TODO: Implementera metod för att visa inventarie

    }

    static void TaBortProdukt()
    {
                
    }

    static void SökProdukt()
    {
       
    }

}
