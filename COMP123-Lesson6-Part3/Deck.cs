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

            this._buildDeck();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++
        private void _addCard(int card, int face, string suit)
        {
            this._cards[card] = new Card(face, suit);
        }

        private void _buildDeck()
        {
            string[] suits = { Suits.CLUBS, Suits.DIAMONDS, Suits.HEARTS, Suits.SPADES };


            for (int suit = 0; suit < suits.Length; suit++)
            {

                for (int face = 1; face < 14; face++)
                {
                    this._addCard(suit, face, suits[suit]);
                }


                    

            }


                
        }



        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++
        public string pickCard(int card)
        {


            return this._cards[card].ToString();
        }
    }
}
