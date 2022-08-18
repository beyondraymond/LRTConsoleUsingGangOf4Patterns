using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRTConsoleUsingGangOf4Patterns
{
    internal interface Chain
    {
        public void setNextChain(Chain nextChain);

        public int calculateFare(Itenerary journey);
    }
}
