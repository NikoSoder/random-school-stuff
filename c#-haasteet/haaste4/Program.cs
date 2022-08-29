using System;

namespace haaste4
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.Clear();
                // get y file value
                Console.WriteLine("Anna arvo y:lle");
                int yFileNum = GetUserCoordinates();

                // get x file value
                Console.Clear();
                Console.WriteLine("Anna arvo x:lle");
                int xFileNum = GetUserCoordinates();

                Console.Clear();
                Console.WriteLine($"y arvo: {yFileNum}, x arvo: {xFileNum}");
                // print enemy coordinates
                GetEnemyCoordinates(yFileNum, xFileNum);
                
                // ask if user wants to continue
                Console.WriteLine("Haluatko jatkaa ohjelmaa (k) kyllä, (e) ei");
                string option = Console.ReadLine();
                if(option == "k") continue;
                else break;
            }
            Console.WriteLine();
            Console.WriteLine("Lopetetaan ohjelma");
        }
        static void GetEnemyCoordinates(int y, int x) 
        {
            if(y == 0 && x == 0) Console.WriteLine("The enemy is in the base!");
            else if(y == 0 && x > 0) Console.WriteLine("The enemy is to the east!");
            else if(y == 0 && x < 0) Console.WriteLine("The enemy is to the west!");
            else if(y > 0 && x > 0) Console.WriteLine("The enemy is to the north east!");
            else if(y > 0 && x == 0) Console.WriteLine("The enemy is to the north!");
            else if(y > 0 && x < 0) Console.WriteLine("The enemy is to the north west!");
            else if(y < 0 && x < 0) Console.WriteLine("The enemy is to the south west!");
            else if(y < 0 && x == 0) Console.WriteLine("The enemy is to the south!");
            else if(y < 0 && x > 0) Console.WriteLine("The enemy is to the south east!");
        }

        static int GetUserCoordinates() 
        {
            while(true)
            {
                string file = Console.ReadLine();
                int fileNum;
                bool success = int.TryParse(file, out fileNum);
                if (success)
                {
                    Console.WriteLine("Kiitos");
                    return fileNum;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kirjoita numero");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }
    }
}
