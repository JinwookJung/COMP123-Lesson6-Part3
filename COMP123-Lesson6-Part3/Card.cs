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
        private int _face;
        private string _suit;

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int Face
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
        public Card(int face, string suit)
        {
            this._face = face;
            this._suit = suit;
        }

        // OVERRIDDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            return this._face + " of " + this._suit;
        }
    }
}
