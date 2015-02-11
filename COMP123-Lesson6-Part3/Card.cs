using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part3
{
    class Card
    {
        // INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++
        private string _face;
        private string _suit;

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string Face
        {
            get
            {
                return this._face; // Read-Only
            }
        }

        public string Suit
        {
            get
            {
                return this._suit; // Read-Only
            }
        }

        // CONSTRUCTOR(S) ++++++++++++++++++++++++++++++++++++++++++++++++
        public Card(string face, string suit)
        {
            this._face = face;
            this._suit = suit;
        }

        // METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Show()
        {
            Console.WriteLine("{0} of {1}", this._face, this._suit);
        }
    }
}
