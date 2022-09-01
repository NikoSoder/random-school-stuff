public class Peli
{
    public void Start()
    {
        Console.Write("Pelaaja 1, kuinka kaukana kaupungista lohikäärme on? (0 - 100) ");
        int lohikaarmeMatka = HaeEtaisyys();
        Console.Clear();

        int kanuunaVoima;
        int peliKierros = 1;
        int kaupunkiKunto = 15;
        int lohikaarmeKunto = 10;
        Console.WriteLine("Pelaaja 2 vuoro.");
        Console.WriteLine("--------------------------------------------------------");
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"TILANNE: Kierros: {peliKierros} Kaupunki: {kaupunkiKunto}/15 Lohikäärme: {lohikaarmeKunto}/10");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (peliKierros % 5 == 0 && peliKierros % 3 == 0)
            {
                Console.WriteLine("Kanuuna tekee 10 pistettä vahinkoa tällä vuorolla.");
                kanuunaVoima = 10;
            }
            else if (peliKierros % 5 == 0 || peliKierros % 3 == 0)
            {
                Console.WriteLine("Kanuuna tekee 3 pistettä vahinkoa tällä vuorolla.");
                kanuunaVoima = 3;
            }
            else
            {
                Console.WriteLine("Kanuuna tekee 1 pistettä vahinkoa tällä vuorolla.");
                kanuunaVoima = 1;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Mille etäisyydelle kanuunalla ammutaan: ");
            int kanuunaEtaisyys = HaeEtaisyys();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            if (kanuunaEtaisyys < lohikaarmeMatka) Console.WriteLine("Tähtäys oli liian lyhyt ja osuma jäi vajaaksi.");
            else if (kanuunaEtaisyys > lohikaarmeMatka) Console.WriteLine("Tähtäys oli liian pitkä ja osuma ylitti kohteen.");
            else
            {
                Console.WriteLine("Osuma!");
                lohikaarmeKunto -= kanuunaVoima;
            }
            kaupunkiKunto--;
            peliKierros++;
            Console.WriteLine("--------------------------------------------------------");


            if (lohikaarmeKunto <= 0)
            {
                Console.WriteLine("Lohikäärme kuoli. Kaupunki voitti.");
                break;

            }
            else if (kaupunkiKunto <= 0)
            {
                Console.WriteLine("Kaupunki tuhoutui. Lohikäärme voitti.");
                break;

            }
        }

    }

    public int HaeEtaisyys()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int EtaisyysInt;
            string Etaisyys = Console.ReadLine();
            bool success = int.TryParse(Etaisyys, out EtaisyysInt);
            if (!success)
            {
                Console.WriteLine("Kirjoita numero");
                continue;
            }
            else
            {
                if (EtaisyysInt < 0 || EtaisyysInt > 100)
                {
                    Console.WriteLine("Numeron täytyy olla isompi kuin 0 ja pienempi kuin 100");
                    continue;
                }
            }

            return EtaisyysInt;
        }
    }
}