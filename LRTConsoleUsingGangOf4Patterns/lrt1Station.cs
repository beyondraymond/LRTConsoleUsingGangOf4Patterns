using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class lrt1Station : Station
    {
        public lrt1Station(String stationName)
        {
            base.setStationName(stationName);
            base.setRailwayType("LRT-1: Yellow Line");
        }
    }
}
