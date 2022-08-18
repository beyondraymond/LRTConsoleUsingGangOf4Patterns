using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Marikina : Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "Marikina")
            {
                switch (journey.getDestination())
                {
                    case "Antipolo":
                    case "Santolan":
                    case "Katipunan":
                        fare = 15;
                        break;

                    case "Anonas":
                    case "Cubao":
                    case "Betty Go":
                    case "Gilmore":
                        fare = 20;
                        break;

                    case "J Ruiz":
                    case "V Mapa":
                    case "Pureza":
                    case "Legarda":
                        fare = 25;
                        break;

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
