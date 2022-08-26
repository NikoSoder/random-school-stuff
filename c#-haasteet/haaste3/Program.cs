using System;
using System.Collections.Generic;

namespace haaste3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ritari> ritarit = new List<Ritari>();

            // kysy kuninkaan koordinaatit
            Console.WriteLine("Kohde rivi? (1-8) ");
            int rivi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kohde sarake? (1-8) ");
            int sarake = Convert.ToInt32(Console.ReadLine());

            // luo ritarit ja laske niiden koordinaatit
            Ritari ritari1 = new Ritari("Ritari yksi", rivi, sarake - 1);
            Ritari ritari2 = new Ritari("Ritari kaksi", rivi - 1, sarake);
            Ritari ritari3 = new Ritari("Ritari kolme", rivi, sarake + 1);
            Ritari ritari4 = new Ritari("Ritari neljä", rivi + 1, sarake);

            // lisää ritarit listalle
            ritarit.Add(ritari1);
            ritarit.Add(ritari2);
            ritarit.Add(ritari3);
            ritarit.Add(ritari4);

            foreach (Ritari ritari in ritarit)
            {
                ritari.PrinttaaKoordinaatit();
            }
        }
    }
}
