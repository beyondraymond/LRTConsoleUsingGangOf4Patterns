using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class lrt2Station : Station
    {
        public lrt2Station(String stationName)
        {
            base.setStationName(stationName);
            base.setRailwayType("LRT-2: Purple Line");
        }
    }
}
