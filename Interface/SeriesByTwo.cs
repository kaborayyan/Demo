using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Developer 02 Implementing the Contract
    internal class SeriesByTwo : ISeries
    {
        public int Current { get; set; }
        public void GetNext() => Current += 2;
    }
}
