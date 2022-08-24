namespace Exercise002 
{
    using System;
    using System.Collections.Generic;
    public class UserInterface 
    {
        private JokeManager manager;

        public UserInterface(JokeManager manager) 
        {
            this.manager = manager;
        }

        public void Start() 
        {
            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine(" 1 - add a joke");
                Console.WriteLine(" 2 - draw a joke");
                Console.WriteLine(" 3 - list jokes");
                Console.WriteLine(" X - stop");

                string command = Console.ReadLine();

                if (command == "X") break;
                
                else if (command == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    string joke = Console.ReadLine();
                    manager.AddJoke(joke);
                }
                else if (command == "2")
                {
                    Console.WriteLine("Drawing a joke.");
                    Console.WriteLine(manager.DrawJoke());

                }
                else if (command == "3")
                {
                    manager.PrintJokes();
                }
            }
        }
    }
}