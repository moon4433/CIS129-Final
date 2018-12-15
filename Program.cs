using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JohnsonK_Final
{
    class Program
    {
        Player currentPlayer;
        Card deck = new Card();
        

        static void Main(string[] args)
        {
            Card.DealDeck();
            WriteLine(Player.playerHand[0]);
            Read();
        }
    }
    class Player
    {
        public static ArrayList matchPile = new ArrayList();
        public static ArrayList playerHand = new ArrayList();
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
        public static int cardNum;
        public static string name;
        public static int cardAmount = 0;
        public static int greenThumbGertAmount = 0;
        public static int arnieAnglerAmount = 0;
        public static int haySeedHankAmount = 0;
        public static int milkManMoAmount = 0;
        public static int lassoLouieAmount = 0;
        public static int freddieFallOffAmount = 0;
        public static int carelessCarrieAmount = 0;
        public static int fiFiFluffAmount = 0;
        public static int altoAnnieAmount = 0;
        public static int balletBettyAmount = 0;
        public static int oldMaidAmount = 0;
        public static bool isGreenThumbGertOut = false;
        public static bool isArnieAnglerOut = false;
        public static bool isHaySeedHankOut = false;
        public static bool isMilkManMoOut = false;
        public static bool isOldMaidOut = false;
        public static bool isLassoLouieOut = false;
        public static bool isFreddieFallOffOut = false;
        public static bool isCarelessCarrieOut = false;
        public static bool isFiFiFluffOut = false;
        public static bool isAltoAnnieOut = false;
        public static bool isBalletBettyOut = false;
        public static bool isDealing = false;

        public static void DealDeck()
        {
            isDealing = true;
            while(isDealing)
            {
                Random random = new Random();
                int rndSpawn = random.Next(0, 11);

                if(rndSpawn == 10 && isGreenThumbGertOut == false)
                {
                    name = "Greenthumb Gert";
                    cardNum = 10;
                    greenThumbGertAmount += 1;
                    cardAmount = greenThumbGertAmount;
                    if(greenThumbGertAmount == 2)
                    {
                        isGreenThumbGertOut = true;
                    }


                }
                else if(rndSpawn == 9 && isArnieAnglerOut == false)
                {
                    name = "Arnie Angler";
                    cardNum = 9;
                    arnieAnglerAmount += 1;
                    cardAmount = arnieAnglerAmount;
                    if(arnieAnglerAmount == 2)
                    {
                        isArnieAnglerOut = true;
                    }
                }
                else if(rndSpawn == 8 && isHaySeedHankOut == false)
                {
                    name = "Hayseed Hank";
                    cardNum = 8;
                    haySeedHankAmount += 1;
                    cardAmount = haySeedHankAmount;
                    Player.playerHand.Add(this);
                    if(haySeedHankAmount == 2)
                    {
                        isHaySeedHankOut = true;
                        isDealing = false;
                    }

                }
                else if(rndSpawn == 7 && isMilkManMoOut == false)
                {
                    name = "Milkman Mo";
                    cardNum = 7;
                    milkManMoAmount += 1;
                    cardAmount = milkManMoAmount;
                    if(milkManMoAmount == 2)
                    {
                        isMilkManMoOut = true;
                    }
                }
                else if (rndSpawn == 6 && isLassoLouieOut == false)
                {

                }
                else if (rndSpawn == 5 && isFreddieFallOffOut == false)
                {

                }
                else if (rndSpawn == 4 && isCarelessCarrieOut == false)
                {

                }
                else if (rndSpawn == 3 && isFiFiFluffOut == false)
                {

                }
                else if (rndSpawn == 2 && isAltoAnnieOut == false)
                {

                }
                else if (rndSpawn == 1 && isBalletBettyOut == false)
                {

                }
                else if (rndSpawn == 0 && isOldMaidOut == false)
                {

                }
                
                
            }
        }
    }
}
