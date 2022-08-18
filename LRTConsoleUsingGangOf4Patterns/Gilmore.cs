using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Gilmore: Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Gilmore")
            {
                switch (journey.getDestination())
                {
                    case "Anonas":
                    case "Cubao":
                    case "Betty Go":
                    case "J Ruiz":
                    case "V Mapa":
                    case "Pureza":
                        fare = 15;
                        break;

                    case "Marikina":
                    case "Santolan":
                    case "Katipunan":
                    case "Legarda":
                    case "Recto":
                        fare = 20;
                        break;

                    case "Antipolo":
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
