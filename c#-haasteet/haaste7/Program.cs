public static class Program { 
    public static void Main(string[] args) 
    {
        string[] computerChoiceList = new string[3]{ "r", "p", "s" };
        int computerWins = 0;
        int userWins = 0;
        while(true) 
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(computerChoiceList.Length);
            string randomComputerChoice = computerChoiceList[randomIndex];

            Console.WriteLine("Chooce rock, paper or scissors (r),(p),(s), (q) to quit");
            string userChoice = Console.ReadLine();
            
            
            if(userChoice == "q")
            {
                Console.WriteLine("Bye!");
                break;
            } 
            
            switch(userChoice + randomComputerChoice)
            {
                case "rr":
                case "pp":
                case "ss":
                    Console.WriteLine("Draw");
                    break;
                case "rs":
                case "sp":
                case "pr":
                    Console.WriteLine("You win");
                    userWins++;
                    break;
                case "rp":
                case "ps":
                case "sr":
                    Console.WriteLine("Computer wins");
                    computerWins++;
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"User wins: {userWins}");
            Console.WriteLine($"Computer wins: {computerWins}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
