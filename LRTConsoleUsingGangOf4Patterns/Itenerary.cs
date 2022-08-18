using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal class Itenerary
    {
        private String origin;
        private String destination;

        public Itenerary(string origin, string destination)
        {
            this.origin = origin;
            this.destination = destination;
        }

        public String getOrigin() { return origin; }
        public String getDestination() { return destination; }

    }
}
