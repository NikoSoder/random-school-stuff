using System;

namespace haaste1
{
    class Program
    {
        static void Main(string[] args)
        {
            // kissa saa enemmän kalaa kuin karhut jos kaloja on 1, 2 tai 3kpl 
            int karhuja = 4;
            Console.WriteLine("Kuinka monta kalaa karhut ovat saaneet? ");
            int kalat = Convert.ToInt32(Console.ReadLine());

            if(kalat < karhuja) 
            {
                Console.WriteLine("Karhut saavat 0 kalaa");
                Console.WriteLine($"Kissa saa {kalat} kalaa");
            }
            else 
            {
                Calculate(kalat, karhuja);
            }
            
            // **
            // while looppi jolla voi testaa lukuja
            // **

            // int karhuja = 4;
            // int kalat = 1;
            // while(kalat < 20) 
            // {
            //     Console.WriteLine($"Kuinka monta kalaa karhut ovat saaneet? {kalat} ");
            //     if(kalat < karhuja) 
            //     {
            //         Console.WriteLine("Karhut saavat 0 kalaa");
            //         Console.WriteLine($"Kissa saa {kalat} kalaa");
            //         Console.WriteLine("-----------------------------------");
            //     }
            //     else 
            //     {
            //         Calculate(kalat, karhuja);
            //     }
            //     kalat++;
            // }
        }

        static void Calculate(int kaloja, int karhuja) 
        {
            int kalatPerKarhu = kaloja / karhuja;
            int kalaaKissalle = kaloja % karhuja;
            Console.WriteLine($"Karhut saavat {kalatPerKarhu} kalaa per karhu");
            Console.WriteLine($"Kissa saa {kalaaKissalle} kalaa");
            Console.WriteLine("-----------------------------------");
        }
    }
}
