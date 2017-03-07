using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Deck
    {
        public Dictionary<int, Card> cards;//maps a value to each card in a deck, will be used for random selection; Dictionary used for O(1) search

        public Deck()
        {
            cards = new Dictionary<int, Card>();
            loadDeck();
        }

        public void loadDeck()
        {
            cards.Clear();
            int cardNum = 1;
            for(int i = 1; i < 5; i++)//loops through each suit
            {
                for(int j = 1; j < 14; j++)//loops through each card in a suit
                {
                    Card currCard = new Card();

                    string suit = "";
                    switch (i)
                    {
                        case 1:
                            suit = "spades";
                            break;
                        case 2:
                            suit = "clubs";
                            break;
                        case 3:
                            suit = "hearts";
                            break;
                        case 4:
                            suit = "diamonds";
                            break;
                    }
                    currCard.suit = suit;
                    currCard.value = j;
                    cards.Add(cardNum, currCard);
                    cardNum++;
                }
            }
        }

        public Card findCard(int num)
        {
            return cards[num];
        }
    }
}
