namespace Exercise002
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            JokeManager manager = new JokeManager();
            UserInterface ui = new UserInterface(manager);
            ui.Start();
        }
    }
}
