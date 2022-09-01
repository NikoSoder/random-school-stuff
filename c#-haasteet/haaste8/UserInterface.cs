public class UserInterface
{
    public Wallet wallet;
    public UserInterface(Wallet wallet)
    {
        this.wallet = wallet;
    }

    public void Start()
    {
        double meatPie;
        while (true)
        {
            Console.Write("How much meat pie costs? ");
            string meatPieString = Console.ReadLine();
            bool success = double.TryParse(meatPieString, out meatPie);
            if (!success)
            {
                Console.WriteLine("Type a number");
                continue;
            }
            break;
        }

        while (true)
        {
            Console.Write("Do you want to buy meat pie? yes(y) no(n) ");
            string userOption = Console.ReadLine();
            if (userOption == "n")
            {
                Console.WriteLine("Bye...");
                break;
            }
            wallet.BuyMeatPie(meatPie);
        }
    }
}