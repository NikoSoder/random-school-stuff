public class Wallet
{
    public string name { get; set; }
    public double money { get; set; }

    public Wallet(string name, double money)
    {
        this.name = name;
        this.money = money;
    }

    public void BuyMeatPie(double meatPieCost)
    {
        if (this.money >= meatPieCost)
        {
            this.money -= meatPieCost;
            Console.WriteLine($"You have {this.money} euros left in you wallet.");
        }
        else
        {
            Console.WriteLine("You dont have enough money in your wallet.");
        }
    }
}