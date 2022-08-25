using System;

namespace haaste2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start() 
        {
            // kuinka monta pistettä per tila
            int pisteetPerMaatila = 1;
            int pisteetPerHerttuakunta = 3;
            int pisteetPerMaakunta = 6;

            // kysytään käyttäjän pisteet
            Console.WriteLine("Montako maatilaa?");
            int maatilat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Montako herttuakuntaa?");
            int herttuakunnat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Montako maakuntaa?");
            int maakunnat = Convert.ToInt32(Console.ReadLine());

            // lasketaan pisteet per tila
            int maatilaPisteet = pisteetPerMaatila * maatilat;
            int herttuakuntaPisteet = pisteetPerHerttuakunta * herttuakunnat;
            int maakuntaPisteet = pisteetPerMaakunta * maakunnat;

            // summataan pisteet 
            int pisteetYhteensä = maatilaPisteet + herttuakuntaPisteet + maakuntaPisteet;
            Console.WriteLine($"Sait {pisteetYhteensä} pistettä");
        }
    }
}
