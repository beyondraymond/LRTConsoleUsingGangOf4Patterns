using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Anonas : Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Anonas")
            {
                switch (journey.getDestination())
                {
                    case "Santolan":
                    case "Katipunan":
                    case "Cubao":
                    case "Betty Go":
                    case "Gilmore":
                        fare = 15;
                        break;

                    case "Antipolo":
                    case "Marikina":
                    case "J Ruiz":
                    case "V Mapa":
                    case "Pureza":
                    case "Legarda":
                        fare = 20;
                        break;

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
