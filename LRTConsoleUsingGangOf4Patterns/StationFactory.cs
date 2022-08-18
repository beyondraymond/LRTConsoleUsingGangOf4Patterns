using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class StationFactory
    {
        public Station makeNewStation(int railway, String stationName)
        {
            switch (railway)
            {
                case 1:
                    return new lrt1Station(stationName);
                    break;

                case 2:
                    return new lrt2Station(stationName);
                    break;

                case 3:
                    return new mrt3Station(stationName);
                    break;

                default:
                    Console.WriteLine("Invalid Raleway");
                    return null;
                    break;
            }
        }
    }
}
