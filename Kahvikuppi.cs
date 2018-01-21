using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har3Teht6
{
    class Coffeecup
    {
        private int MaxCoffee = 100;

        public int coffee;
        public int Coffee
        {
            get { return coffee; }
            set
            {
                if (value <= MaxCoffee)
                    coffee = value;
                else
                {
                    coffee = MaxCoffee;
                    Console.WriteLine("You poured too much. The cup is filled to the brim and some spilled over.");
                }
            }
        }

        public string Color { get; set; }
        public bool Decoration { get; set; }
        public bool Handle { get; set; }



        public Coffeecup(string color, bool decoration, bool handle)
        {
            Color = color;
            Decoration = decoration;
            Handle = handle;
            Coffee = 0;
        }
        public void Pour()
        {
            Coffee += 25;
            Console.WriteLine("You poured some.");
        }

        public void Drink()
        {
            Coffee -= 25;
            Console.WriteLine("You drank some.");
        }

        public void LookAtCup()
        {
            Console.WriteLine("Your cup is: ");
            Console.WriteLine(Coffee + "% full");
            Console.WriteLine("And it's " + Color);
            if (Handle == true)
                Console.WriteLine("It seems to be decorated.");
            else
                Console.WriteLine("It's just a plain, " + Color + " cup.");
            if (Decoration == true)
                Console.WriteLine("It has a handle.");
            else
                Console.WriteLine("It doesn't have a handle.");
        }
    }
}
