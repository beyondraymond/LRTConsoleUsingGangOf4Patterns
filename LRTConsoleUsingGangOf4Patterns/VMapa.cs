using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class VMapa: Chain
    {
        private Chain nextInChain;
        private int fare = 0;

        public int calculateFare(Itenerary journey)
        {
            if (journey.getOrigin() == "V Mapa")
            {
                switch (journey.getDestination())
                {                    
                    case "Betty Go":
                    case "Gilmore":
                    case "J Ruiz":
                    case "Pureza":
                    case "Legarda":
                    case "Recto":
                        fare = 15;
                        break;

                    case "Katipunan":
                    case "Anonas":
                    case "Cubao":
                        fare = 20;
                        break;

                    case "Antipolo":
                    case "Marikina":
                    case "Santolan":
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
