using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class JRuiz: Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "J Ruiz")
            {
                switch (journey.getDestination())
                {
                    case "Cubao":
                    case "Betty Go":
                    case "Gilmore":
                    case "V Mapa":
                    case "Pureza":
                    case "Legarda":
                        fare = 15;
                        break;

                    case "Santolan":
                    case "Katipunan":
                    case "Anonas":                    
                    case "Recto":
                        fare = 20;
                        break;

                    case "Antipolo":
                    case "Marikina":
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
