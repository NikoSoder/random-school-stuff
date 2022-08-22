namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string identifierInput = Console.ReadLine();
                if (identifierInput == "")
                {
                    break;
                }

                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                Item item = new Item(identifierInput, name);

                if(items.Contains(item))
                {
                    continue;
                }
                else 
                {
                    items.Add(item);
                }

            }


            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}