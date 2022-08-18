using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class BettyGo : Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Betty Go")
            {
                switch (journey.getDestination())
                {
                    case "Katipunan":
                    case "Anonas":
                    case "Cubao":
                    case "Gilmore":
                    case "J Ruiz":
                    case "V Mapa":
                        fare = 15;
                        break;

                    case "Marikina":
                    case "Santolan":
                    case "Pureza":
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
