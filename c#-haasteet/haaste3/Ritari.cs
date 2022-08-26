namespace haaste3 
{
    using System;
    public class Ritari 
    {
        public string name {get; set;}
        public int ritariRivi {get; set;}
        public int ritariSarake {get; set;}

        public Ritari(string name, int rivi, int sarake) 
        {
            this.name = name;
            this.ritariRivi = rivi;
            this.ritariSarake = sarake;
        }

        public void PrinttaaKoordinaatit() 
        {
            if(this.ritariRivi < 1 || this.ritariRivi > 8 || this.ritariSarake < 1 || this.ritariSarake > 8) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{this.name} ei ole tilaa liikkua");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{this.name} kohteeseen ({this.ritariRivi}, {this.ritariSarake})");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}