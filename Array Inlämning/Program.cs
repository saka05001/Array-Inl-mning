using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv hur många namn du ska skriva");
            int antal = int.Parse(Console.ReadLine());
            string[] namn = new string[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv ett namn");
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("Här är dem namnen du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
