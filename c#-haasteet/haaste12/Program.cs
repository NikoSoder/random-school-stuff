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
            Console.Write("Kirjoita kalorimäärä: ");
            Laskin(option);
        }
        else if(option == "2") 
        {
            Console.Write("Kirjoita joulimäärä: ");
            Laskin(option);
        }
        else Console.WriteLine("Kirjoita 1, 2 tai q");
    }
}

void Laskin(string option) 
{
    string maara = Console.ReadLine();
    int maaraInt;
    
    bool success = int.TryParse(maara, out maaraInt);
    if (success) 
    {
        // jos kalorit jouleiksi
        if(option == "1") 
        {
            Console.WriteLine($"Kalorit jouleiksi: {Math.Round(maaraInt * 4.184, 2)}");
        }
        // jos joulet kaloreiksi
        else Console.WriteLine($"Joulet kaloreiksi: {Math.Round(maaraInt * 0.2390, 2)}");  
    }
    else Console.WriteLine("Kirjoita numero");
      
}

