public class User 
{
    public string pinCode {get; set;}
    public string pukCode {get; set;} 
    public User(string pinCode, string pukCode) 
    {
        this.pinCode = pinCode;
        this.pukCode = pukCode;
    }

    public void Login() 
    {
        while (true)
        {
            bool isPinCodeCorrect = TypePinCode();
            if(isPinCodeCorrect) 
            {
                Console.WriteLine("Correct");
                break;
            }
        
            Console.WriteLine("PIN code is locked.Type your PUK code");
            bool isPukCodeCorrect = PukCodeCheck();
            if(isPukCodeCorrect) 
            {
                Console.WriteLine("Correct");
                Console.WriteLine($"Your PIN code is {this.pinCode}");
                Console.WriteLine("Try to login again.");
                continue;
            }
            else 
            {
                Console.WriteLine("PUK code wrong. Shutting down...");
                break;
            }
        }
    }

    public  bool TypePinCode() 
    {
        Console.WriteLine("Type your PIN code");

        for (int i = 0; i < 4; i++)
        {
            // if three wrong PIN codes
            if(i == 3) 
            {
                break;
            }
            string pcode = Console.ReadLine();

            // if correct PIN code
            if(pcode == this.pinCode) 
            {
                return true;
            }
            Console.WriteLine("Try again");
        }
        return false;
    }

    public bool PukCodeCheck() 
    {
        for (int i = 0; i < 4; i++)
        {
            // if three wrong PUK codes
            if(i == 3) 
            {
                break;
            }
            string pukcode = Console.ReadLine();

            // if correct PUK code
            if(pukcode == this.pukCode) 
            {
                return true;
            }
            Console.WriteLine("Try again");
        }
        return false;
    }
}