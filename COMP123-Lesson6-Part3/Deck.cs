using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part3
{
    class Deck
    {
        // INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++
        private Card[] _cards = new Card[52];


        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Deck()
        {
            this._addCard(0, Face.ACE, Suits.HEARTS);












        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++
        private void _addCard(int card, int face, string suit)
        {
            this._cards[card] = new Card(face, suit);
        }



        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++
        public string pickCard(int card)
        {


            return this._cards[card].ToString();
        }
    }
}
