using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareable_Interface
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? EmpX = (Employee?)x;
            Employee? EmpY = (Employee?)y;
            //if (EmpX.Id > EmpY.Id)
            //    return 1;
            //else if (EmpX.Id < EmpY.Id)
            //    return -1;
            //else
            //    return 0;
            return EmpX?.Id.CompareTo(EmpY?.Id) ?? (EmpY is null ? 0 : -1);

        }
    }
}
