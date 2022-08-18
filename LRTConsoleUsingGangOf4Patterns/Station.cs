using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    abstract class Station
    {
        private String stationName;
        private String railwayType;

        public String getStationName() { return stationName; }
        public void setStationName(String newName) { stationName = newName; }

        public String getRailwayType() { return railwayType; } 
        public void setRailwayType(String newRailway) {railwayType = newRailway; }

        public String getDateOfCreation()
        {
            return DateTime.Now.ToString();
        }

        public void displayStationSchedule()
        {
            Console.WriteLine("Normal Sched: 4:30 am - 9:00 pm");
        }

    }
}
