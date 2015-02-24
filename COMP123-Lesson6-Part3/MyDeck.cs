using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part3
{
    class MyDeck : Deck, IAddJoker
    {
        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++
        public MyDeck()
            :base()
        {

        }

        // INTERFACE METHODS +++++++++++++++++++++++++++++++++++     
        public void AddJoker()
        {
            Console.WriteLine("Added Joker");
        }
        
    }
}
