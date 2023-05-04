using System;
using System.Runtime.InteropServices.ComTypes;

namespace krokodillespill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            bool flag = true;
            while (flag)
            {
                var random = new Random();
                var tall1 = random.Next(0, 12);
                var tall2 = random.Next(0, 12);

                Console.WriteLine("Poeng: " + points);
                Console.WriteLine("Use: <, > or =");
                Console.WriteLine(tall1 + " _ " + tall2);
                var input = Console.ReadLine();

                switch (input)
                {
                    case "<":
                    case ">":
                    case "=":
                    {
                        if ((tall1 > tall2 && input == ">") || (tall1 < tall2 && input == "<") ||
                            (tall1 == tall2 && input == "="))
                        {
                            points++;
                        }
                        else
                        {
                            points--;
                        }

                        Console.Clear();
                        break;
                    }
                    default:
                        Console.WriteLine("Ikke gyldig tegn!");
                        flag = false;
                        break;
                }
            }
        }
    }
}