using System;

namespace Exercise020
{
  public class Program
  {
    public static void Main(string[] args)
    {
      PrintStars(3);
      PrintSquare(4);
      PrintRectangle(17, 3);
      PrintTriangle(4);
      
    }
    
    public static void PrintStars(int number) 
    {
      while(number > 0) 
      {
        Console.Write("*");
        number--;
      }
      Console.WriteLine("");
    }

    public static void PrintSquare(int size) 
    {
      for(int i = 0; i < size; i++) 
      {
        for(int j = 0; j < size; j++) 
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
      
    }

    public static void PrintRectangle(int width, int height) 
    {
      for(int i = 0; i < height; i++) 
      {
        for(int j = 0; j < width; j++) 
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    public static void PrintTriangle(int size) 
    {
      for(int i = 0; i < size; i++) 
      {
        for(int j = 0; j <= i; j++) 
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }
  }
}
