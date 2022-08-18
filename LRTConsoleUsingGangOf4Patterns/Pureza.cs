using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Pureza: Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Pureza")
            {
                switch (journey.getDestination())
                {                    
                    case "Gilmore":
                    case "J Ruiz":
                    case "V Mapa":
                    case "Legarda":
                    case "Recto":
                        fare = 15;
                        break;

                    case "Katipunan":
                    case "Anonas":
                    case "Cubao":
                    case "Betty Go":
                        fare = 20;
                        break;

                    case "Marikina":
                    case "Santolan":
                        fare = 25;
                        break;

                    case "Antipolo":
                        fare = 30;
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
