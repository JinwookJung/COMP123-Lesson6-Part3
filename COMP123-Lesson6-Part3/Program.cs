using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part3
{
    class Program
    {
        static void Main()
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();

            myDeck.DealCards(7); // Deal 5 cards

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
