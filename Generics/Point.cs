using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Point: IComparable<Point>
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is Point PassedPoint)
        //    {
        //        if (this.X == PassedPoint.X)
        //        {
        //            return this.Y.CompareTo(PassedPoint.Y);
        //        }
        //        else
        //        {
        //            return this.X.CompareTo(PassedPoint.X);
        //        }
        //    }
        //    return 1; // if the passed object is null consider the caller the bigger
        //}

        public int CompareTo(Point? other)
        {
            // three situations
            // null
            // Point
            // object from class that inherit from Point
            if (other == null) return 1 ;
            if (this.X == other.X) return this.Y.CompareTo(other.Y);
            else return this.X.CompareTo(other.X);
        }
    }
}
