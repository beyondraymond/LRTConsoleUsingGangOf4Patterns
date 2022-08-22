using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    public class TrainBuilder
    {
        //required parameters
        private int numberOfTrainCoach;
        private int engineID;
        private string railwayType;

        //optional parameters
        private Boolean isAirconEnabled;
        private Boolean isAdCustomizable;

        public TrainBuilder(int numberOfTrainCoach, int engineID, string railwayType)
        {
            this.numberOfTrainCoach = numberOfTrainCoach;
            this.engineID = engineID;
            this.railwayType = railwayType;
        }

        public TrainBuilder setAirconEnabled(Boolean isAirconEnabled) { this.isAirconEnabled = isAirconEnabled; return this; }

        public TrainBuilder setAdCustomizable(Boolean isAdCustomizable) { this.isAdCustomizable = isAdCustomizable; return this; }

        public int getNumberOfTrainCoach() { return numberOfTrainCoach; }
        public int getEngineID() { return engineID; }
        public String getRailwayType() { return railwayType; }

        public bool getAirconType() { return isAirconEnabled; }
        public bool getAdCustomizable() { return isAdCustomizable; }

        public Train build() { return new Train(this); }
    }
}
