using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
        // Allowed Access Modifiers
        // 1. Private (Default)
        // 2. Default
        // 3. Public
    internal struct Point
    {
        // What can you write inside a struct?
        // 1. Attributes = fields = variables
        // 2. Functions(Constructors - Getters Setters - Methods)
        // 3. Properties (Full - Automatic - Indexer)
        // 4. Events

        public int X;
        public int Y;

        #region Constructors
        // Constructors
        // 1. Special function
        // 2. Same name as Class or Struct
        // 3. No return
        // 4. By default the compiler will generate parameterless Constructor
        // that will initialize the attributes with their default values
        // in older versions of .net, you had to assign the values yourself
        // 5. You can create several constructors "Overloading"
        // 6. If so each Constructor must have different regarding how may parameters are passed

        public Point() // ctor shortcut
        {

        }

        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Methods
        public override string ToString() // Overriding the original method
        {
            return $"({this.X}, {this.Y})";
        }

        #endregion
    }
}
