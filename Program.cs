using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnsonK_Final
{
    class Program
    {
        Player currentPlayer;
        Card deck = new Card();

        static void Main(string[] args)
        {
        }
    }
    class Player
    {
        ArrayList matchPile = new ArrayList();
        static ArrayList playerHand = new ArrayList();
        public bool isPickingCard = false;
        Card firstCard;
        Card secondCard;

        public Player()
        {
            checkForMatches();
        }
        public void checkForMatches()
        {
            foreach (Card firstCard in playerHand)
            {
                foreach(Card secondCard in playerHand)
                {
                    if(firstCard.cardNum == secondCard.cardNum)
                    {
                        if(firstCard.cardAmount == 1 && secondCard.cardAmount == 2)
                        {

                        }
                    }
                }
            }
        }
    }
    class Card
    {
        public int cardNum;
        public string name;
        public int cardAmount;
        private int greenThumbGertAmount = 0;
        private int arnieAnglerAmount = 0;
        private int haySeedHankAmount = 0;
        private int milkManMoAmount = 0;
        private int lassoLouieAmount = 0;
        private int freddieFallOffAmount = 0;
        private int carelessCarrieAmount = 0;
        private int fiFiFluffAmount = 0;
        private int altoAnnieAmount = 0;
        private int balletBettyAmount = 0;
        private int oldMaidAmount = 0;
        public bool isGreenThumbGertOut = false;
        public bool isArnieAnglerOut = false;
        public bool isHaySeedHankOut = false;
        public bool isMilkManMoOut = false;
        public bool isOldMaidOut = false;
        public bool isLassoLouieOut = false;
        public bool isFreddieFallOffOut = false;
        public bool isCarelessCarrieOut = false;
        public bool isFiFiFluffOut = false;
        public bool isAltoAnnieOut = false;
        public bool isBalletBettyOut = false;

        public static void DealDeck()
        {

        }
    }
}
