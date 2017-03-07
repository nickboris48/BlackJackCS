using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Card
    {
        public string suit { set; get; }
        public int value { set; get; }
        public int cardNumber { set; get; }

        public Card()
        {
            value = -1;
            suit = "";
            cardNumber = -1;
        }
    }
}
