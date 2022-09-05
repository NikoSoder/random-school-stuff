List<int> numbers = new List<int>();

while (true)
{
    Console.Write("Add number to your list. (q) quits the program. ");
    string numberString = Console.ReadLine();
    if(numberString == "q") break;

    int numberInt;
    // checks if input is a number
    bool success = int.TryParse(numberString, out numberInt);
    if (success)
    {
        numbers.Add(numberInt);
    }
    else
    {
        Console.WriteLine("Type a number");
    }
}
Console.WriteLine();
Console.WriteLine("Converting to opposite numbers:");

foreach (int num in numbers)
{
    GetOppositeNumber(num);
}

void GetOppositeNumber(int num) 
{
    Console.WriteLine(num = num * -1); 
}
