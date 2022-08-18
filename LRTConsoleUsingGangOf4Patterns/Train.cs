using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Train
    {
        //required parameters
        private int numberOfTrainCoach;
        private int engineID;
        private string railwayType;

        //optional parameters
        public Boolean isAirconEnabled;
        public Boolean isAdCustomizable;

        public int getNumberOfTrainCoach() { return numberOfTrainCoach; }
        public int getEngineID() { return engineID; }
        public String getRailwayType() { return railwayType; }

        public Train(TrainBuilder builder)
        {
            this.numberOfTrainCoach = builder.numberOfTrainCoach;
            this.engineID = builder.engineID;
            this.railwayType = builder.railwayType;
            this.isAirconEnabled = builder.isAirconEnabled;
            this.isAdCustomizable = builder.isAdCustomizable;
        }


        public class TrainBuilder
        {
            //required parameters
            public int numberOfTrainCoach;
            public int engineID;
            public string railwayType;

            //optional parameters
            public Boolean isAirconEnabled;
            public Boolean isAdCustomizable;

            public TrainBuilder(int numberOfTrainCoach, int engineID, string railwayType)
            {
                this.numberOfTrainCoach = numberOfTrainCoach;
                this.engineID = engineID;
                this.railwayType = railwayType;
            }

            public TrainBuilder setAirconEnabled(Boolean isAirconEnabled) { this.isAirconEnabled = isAirconEnabled; return this; }

            public TrainBuilder setAdCustomizable(Boolean isAdCustomizable) { this.isAdCustomizable = isAdCustomizable; return this; }

            public Train build() { return new Train(this); }


        }

    }
}
