using System;

namespace cse210_tc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our collaborative program!");

            DisplayGreetingNash();
            
            DisplayGreetingKennion();
            
            elijahWilson();

        }

        static void DisplayGreetingNash()
        {
            Console.WriteLine("Live long and prosper from Curtis Nash");
        }   

        }
        
        static void DisplayGreetingKennion()
        {
            Console.WriteLine("reH ponglu'choH je!");
        }
        static void elijahWilson()
        {
            
            Console.Write("Wassup guys! Scale of 1-10 how familiar are you guys with these processes? ");
            string response = Console.ReadLine();
            int responseI = int.Parse(response);
            if (responseI >= 5)
            {
                Console.Writeline("Keep up the great work!");
            }
            else
            {
                Console.WriteLine("Keep working at it!");
            }
            return;

        }
    }
}
