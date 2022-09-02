string pincode = SetPinCode();
string pukcode = SetPukCode();
User newUser = new User(pincode, pukcode);
newUser.Login();

string SetPinCode() 
{
    while (true)
    {
        Console.Write("Set your PIN code. Needs to be four numbers. ");
        string pin = Console.ReadLine();
        bool isIntString = pin.All(char.IsDigit);

        // check if lenght is 4 and all chars are numbers
        if(pin.Length == 4 && isIntString) 
        {
            Console.Clear();    
            return pin;    
        }
        Console.WriteLine("Invalid input");
    }
}

string SetPukCode() 
{
    while (true)
    {
        Console.Write("Set your PUK code. Needs to be eight numbers. ");
        string puk = Console.ReadLine();
        bool isIntString = puk.All(char.IsDigit);

        // check if lenght is 8 and all chars are numbers
        if(puk.Length == 8 && isIntString) 
        {
            Console.Clear();    
            return puk;    
        }
        Console.WriteLine("Invalid input");
    }
}