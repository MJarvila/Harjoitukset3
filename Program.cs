using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// coffee, color, decoration, handle

namespace Har3Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Coffeecup first = new Coffeecup("blue", true, true);
            first.Coffee = 95;

            first.LookAtCup();
            Console.ReadLine();
            first.Drink();
            first.Drink();
            first.Drink();
            first.Drink();
            first.Pour();
            first.LookAtCup();
        }
    }
}
