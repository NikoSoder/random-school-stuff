using System;

namespace haaste6
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while(counter < 101) 
            {
                if(counter % 3 == 0 && counter % 5 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{counter}: Electric and Fire");
                    counter++;
                }
                else if(counter % 5 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{counter}: Electric");
                    counter++;
                }
                else if(counter % 3 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{counter}: Fire");
                    counter++;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{counter}: Normal");
                    counter++;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
