using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class mrt3Station : Station
    {
        public mrt3Station(String stationName)
        {
            base.setStationName(stationName);
            base.setRailwayType("LRT-1: Yellow Line");
        }
    }
}
