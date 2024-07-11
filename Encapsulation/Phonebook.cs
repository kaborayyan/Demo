using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal struct Phonebook
    {
        // Attributes
        string[] Names;
        int[] Numbers;
        int ArraySize;

        // Properties
        public int Size
        {
            get { return ArraySize; }
        }

        // Constructors
        public Phonebook(int _size)
        {
            ArraySize = _size;
            Names = new string[ArraySize];
            Numbers = new int[ArraySize];
        }

        // Methods
        // A method to add new person
        public void AddPerson(int position, string name, int number)
        {
            if (Names is not null && Numbers is not null) // Code protection against null
            {
                if (position < Size) // Code protection against out of range
                {
                    Names[position] = name;
                    Numbers[position] = number;
                }
            }
        }
    }
}
