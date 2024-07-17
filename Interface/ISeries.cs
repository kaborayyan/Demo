using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    // Developer 01 Contract written
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetNext();
        
        // Default Implemented Method
        public void Reset()
        {
            Current = 0;
        }
    }
}
