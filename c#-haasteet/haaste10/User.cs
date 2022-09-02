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
        }
    }

    public  bool TypePinCode() 
    {
        Console.WriteLine("Type your PIN code");

        for (int i = 0; i < 4; i++)
        {
            // if three wrong pin codes
            if(i == 3) 
            {
                break;
            }
            string pcode = Console.ReadLine();

            // if correct pin code
            if(pcode == this.pinCode) 
            {
                return true;
            }
            Console.WriteLine("Try again");
        }
        return false;
    }

    public void PukCodeCheck() 
    {
        Console.WriteLine("Type your PUK code");
    }
}