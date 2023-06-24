using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game_Card
{
    class Card
    {
        public string Value { get; private set; }
        public string Suit { get; private set; }
        public string Name { get { return $"{Value} {Suit}"; }  }

        public Card(EValue value, ESuit suit)
        {
            this.Value = value.ToString();
            this.Suit = suit.ToString();
        }

        public override string ToString()
        {
            return $"{Value} {Suit}";
        }
    }
}
