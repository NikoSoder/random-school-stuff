Start();


void Start() 
{
    while (true)
    {
        Console.Write("Haluatko kalorit jouleiksi (1), joulet kaloreiksi (2), (q) lopettaa. ");
        string option = Console.ReadLine();
        if(option == "q") break;
        if(option == "1") 
        {
            KaloritJouleiksi();
        }
        else if(option == "2") 
        {
            JouletKaloreiksi();
        }
        else
        {
            Console.WriteLine("Paina 1, 2 tai q");
            continue;
        }
    }
    
}

void KaloritJouleiksi() 
{
    Console.Write("Kirjoita kalorimäärä: ");
    string kalorit = Console.ReadLine();
    int kaloritInt;
    
    bool success = int.TryParse(kalorit, out kaloritInt);
    if (success) 
    {
        Console.WriteLine($"Kalorit jouleiksi: {Math.Round(kaloritInt * 4.184, 2)}");
    }
    else Console.WriteLine("Kirjoita numero");
      
}

void JouletKaloreiksi() 
{
    Console.Write("Kirjoita joulimäärä: ");
    string joulet = Console.ReadLine();
    int jouletInt;
    
    bool success = int.TryParse(joulet, out jouletInt);
    if (success) 
    {
        Console.WriteLine($"Joulet kaloreiksi: {Math.Round(jouletInt * 0.2390, 2)}");
    }
    else Console.WriteLine("Kirjoita numero");
        
}
