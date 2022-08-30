

Console.Write("User 1, enter a number between 0 and 100: ");

int userOneInt;
while(true) 
{   string userOneInput = Console.ReadLine();
    
    bool success = int.TryParse(userOneInput, out userOneInt);
    if (success)
    {
        Console.WriteLine($"Thank you!");
        break;
    }
    else
    {
        Console.WriteLine($"Write a number");
    }
}
Console.Clear();


Console.WriteLine("User 2, quess the number.");
Console.Write("What is your next quess? ");
//int userTwoInput = Convert.ToInt32(Console.ReadLine());
