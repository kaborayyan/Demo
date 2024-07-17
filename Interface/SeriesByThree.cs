using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get; set; }
        public void GetNext() => Current += 3;
    }
}
