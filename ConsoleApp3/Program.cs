using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Calc();
                    Console.WriteLine("==");
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

        }

        private static void Calc()
        {
            Console.WriteLine("Ile miałeś wydatków w tym tygodniu: ");
            int number = int.Parse(Console.ReadLine());
            decimal[] wydatki = new decimal[number];


            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Wprwoadź wydatek: {i + 1}");
                wydatki[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("===");
            Array.Sort(wydatki);
            Console.WriteLine("Twoje wydatki w kolejności do największych do najmnieszych:");
            for (int j = wydatki.Length - 1; j >= 0; j--)
            {
                Console.WriteLine($"{wydatki[j]}");
            }
        }
    }
}
