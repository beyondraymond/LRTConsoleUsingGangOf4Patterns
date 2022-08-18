using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Katipunan: Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Katipunan")
            {
                switch (journey.getDestination())
                {
                    case "Marikina":
                    case "Santolan":
                    case "Anonas":
                    case "Cubao":
                    case "Betty Go":
                        fare = 15;
                        break;

                    case "Antipolo":
                    case "Gilmore":
                    case "J Ruiz":
                    case "V Mapa":
                    case "Pureza":
                        fare = 20;
                        break;

                    case "Legarda":
                    case "Recto":
                        fare = 25;
                        break;

                    default:
                        Console.WriteLine("Invalid Destination! Go back to main menu and try again.");
                        fare = 0;
                        break;
                }
            }
            else
            {
                fare = nextInChain.calculateFare(journey);
            }
            return fare;
        }

        public void setNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
    }
}
