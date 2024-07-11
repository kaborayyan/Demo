using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        
        #region Constructors
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        // Methods "Must be linked to an Object"
        public int Product() // Must be virtual to allow override
        {
            return X * Y;
        } 
        #endregion
    }
}
