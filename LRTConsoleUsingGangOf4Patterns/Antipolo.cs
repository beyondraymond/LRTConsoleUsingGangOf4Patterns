using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Antipolo : Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Antipolo")
            {
                switch (journey.getDestination())
                {
                    case "Marikina":
                    case "Santolan":
                        fare = 15;
                        break;

                    case "Katipunan":
                    case "Anonas":
                    case "Cubao":
                        fare = 20;
                        break;

                    case "Betty Go":
                    case "Gilmore":
                    case "J Ruiz":
                    case "V Mapa":
                        fare = 25;
                        break;

                    case "Pureza":
                    case "Legarda":
                    case "Recto":
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
