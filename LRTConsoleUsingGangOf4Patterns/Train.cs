using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    public class Train
    {
        //required parameters
        private int numberOfTrainCoach;
        private int engineID;
        private string railwayType;

        //optional parameters
        private Boolean isAirconEnabled;
        private Boolean isAdCustomizable;

        public int getNumberOfTrainCoach() { return numberOfTrainCoach; }
        public int getEngineID() { return engineID; }
        public String getRailwayType() { return railwayType; }

        public bool getAirconType() { return isAirconEnabled; }
        public bool getAdCustomizable() { return isAdCustomizable; }    

        public Train(TrainBuilder builder)
        {
            this.numberOfTrainCoach = builder.getNumberOfTrainCoach();
            this.engineID = builder.getEngineID();
            this.railwayType = builder.getRailwayType();
            this.isAirconEnabled = builder.getAirconType();
            this.isAdCustomizable = builder.getAdCustomizable();
        }

    }
}
