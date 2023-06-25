using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Card;

namespace RandomCardList
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
           Enum.TryParse<ESuit>(x.Suit, out ESuit xsuit);
           Enum.TryParse<ESuit>(y.Suit, out ESuit ysuit);
            Enum.TryParse<EValue>(x.Value, out EValue xValue);
            Enum.TryParse<EValue>(y.Value, out EValue yValue);

            if (xsuit > ysuit) return 1;
            else if (xsuit < ysuit) return -1;
            else
            {
                if(xValue>yValue) return 1;
                else if(xValue <yValue) return -1;
                else return 0;
            }
            
        }
    }
}
