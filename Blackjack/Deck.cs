namespace Blackjack
{
    internal class Deck
    {
        int numb = 0;
        Card[] cards = new Card[52];
       public void cardList()
        {
            int cardIcon = 3;
            int cardName = 13;
            int cardValue = 0;
            for (int i = 0; i < cardIcon; i++)
            {
                for (int j = 0; j < cardName; j++)
                {
                    cards[0] = new Card(i, j);
                    cardValue++;
                }
            }
        }

        public void shuffleDeck()
        {
            var shuffledList = cards.OrderBy(item => Guid.NewGuid());
        }

        public Card nextCard()
        {
            return cards[numb]; 
            numb++;
        }

    }
}
