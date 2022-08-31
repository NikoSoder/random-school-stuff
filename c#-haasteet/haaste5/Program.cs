
public static class Program { 
    public static void Main(string[] args) 
    {
        // get user one input
        Console.Write("User 1, enter a number between 0 and 100: ");
        int userOneInt = GetUserOneInput();
        Console.Clear();

        // user two quessing user one number
        Console.WriteLine("User 2, quess the number.");
        Console.Write("What is your next quess? ");
        TryToQuess(userOneInt);
    }

    static int GetUserOneInput() 
    {
        int userOneInt;
        while(true) 
        {   string userOneInput = Console.ReadLine();
            
            bool success = int.TryParse(userOneInput, out userOneInt);
            if (!success)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Write a number");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            
            if(userOneInt < 0 || userOneInt > 100) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number is too low or too high");
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            break;
        }
        return userOneInt;
    }

    static void TryToQuess(int userOneNumber) 
    {
        int userTwoInt;
        while(true) 
        {   string userTwoInput = Console.ReadLine();
            
            bool success = int.TryParse(userTwoInput, out userTwoInt);
            // if not a number
            if (!success)
            {
                Console.WriteLine($"Write a number");
                continue;
            }

            if(userTwoInt < userOneNumber) 
            {
                Console.WriteLine($"{userTwoInt} is too low.");
                Console.Write("What is your next quess? ");
                continue;
            }
            else if(userTwoInt > userOneNumber) 
            {
                Console.WriteLine($"{userTwoInt} is too high.");
                Console.Write("What is your next quess? ");
                continue;
            }
            else 
            {
                Console.WriteLine("You quessed the number!");
                break;
            }
        }
    } 
}
