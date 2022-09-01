// get user name and how much money in wallet
string userName = GetUserName();
Console.Clear();
double userMoney = GetUserMoney();

// create wallet and interface
Wallet userWallet = new Wallet(userName, userMoney);
UserInterface ui = new UserInterface(userWallet);
ui.Start();


string GetUserName()
{
    Console.Write("Hello what's your name? ");
    string name = Console.ReadLine();
    return name;
}

double GetUserMoney()
{
    double userMoneyDouble;
    while (true)
    {
        Console.Write("How much money do you got? ");
        string userStringMoney = Console.ReadLine();
        bool success = double.TryParse(userStringMoney, out userMoneyDouble);
        if (!success)
        {
            Console.WriteLine("Type a number");
            continue;
        }

        return userMoneyDouble;
    }
}