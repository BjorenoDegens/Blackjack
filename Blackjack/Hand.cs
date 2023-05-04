using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Hand
    {

        Deck game = new Deck();
        int handNumb = 0;
        int handValue = 0;
        Card[] handUser = new Card[5];
        /* 
         * list met max value van 5
         * deck(shuffle aanroepen)
         * seeHand() om je hand te zien
         * deck(nextcard aanroepen) if statement voor wanneer je om een nieuwe card vraagt zodat je kan zien
         */
        public Card hit()
        { 
            handUser[handNumb] = game.nextCard();
            handNumb++;
            return game.nextCard();
        }

        

        public Card seeHand()
        {
            return handUser[0];
            //forloop van alle handUser
        }
    }
}
