using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    // Sealed Class means no Class can inherit from the Sealed Class
    // NewClass : GrandChild => Invalid
    sealed internal class GrandChild : Child
    {
        // Can't override Salary
        // Can't override Print()
    }
}
