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
        private int _cardPointer = 0;


        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Deck()
        {

            this._buildDeck(); // Build Deck of Cards with all Faces and Suits
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++
        
        // PRIVATE UTILITY METHOD - Adds card to Deck
        private void _addCard(int card, int face, string suit)
        {
            this._cards[card] = new Card(face, suit);
        }

        // PRIVATE UTILITY METHOD - Builds Deck of Cards 
        private void _buildDeck()
        {
            string[] suits = { Suits.CLUBS, Suits.DIAMONDS, Suits.HEARTS, Suits.SPADES };
            int card = 0;

            foreach (string suit in suits)
            {
                for (int face = 1; face < 14; face++)
                {
                    this._addCard(card, face, suit);
                    card++;
                }
            } 
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++
        
        // PeekAtTopCard Method - picks top card of the deck
        public string PeekAtTopCard()
        {
            return this._cards[0].ToString();
        }

        // DealCards Method - deals a variable number of cards
        public void DealCards(int numCards)
        {
            int cardsLeft = 52 - this._cardPointer;
            
            // Ensure that there are enough cards to deal
            if ((this._cardPointer < 52) && (cardsLeft - numCards >= 0))
            {
                while (numCards > 0)
                {
                    Console.WriteLine(this._cards[this._cardPointer].ToString());
                    numCards--;
                    this._cardPointer++; // Move card pointer ahead
                }
            }
            else
            {
                Console.WriteLine("No more cards in the deck");
            }
            
        }

        // Shuffle Method - randomly shuffles deck
        public void Shuffle()
        {
            Random rnd = new Random(); // Pseudo-Random number seed

            this._cardPointer = 0; // Reset card pointer to first card

            for (int first = 0; first < this._cards.Length; first++)
            {
                int second = rnd.Next(52); // pick a random card
                Card tempCard = this._cards[first];
                this._cards[first] = this._cards[second];
                this._cards[second] = tempCard;
            }

        }
    }
}
