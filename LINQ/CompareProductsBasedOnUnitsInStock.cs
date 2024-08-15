using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class CompareProductsBasedOnUnitsInStock : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x.UnitsInStock.CompareTo(y.UnitsInStock);
        }
    }
}
