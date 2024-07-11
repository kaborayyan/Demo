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

        #region Getter & Setter
        // Getters & Setters
        // Getter
        public int GetPersonNumber(string name)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (Names[i] == name)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1; // if not found or the array is null
        }

        // Setter
        public void ChangePersonNumber(string name, int newNumber)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (Names[i] == name)
                    {
                        Numbers[i] = newNumber;
                        break;
                    }
                }
            }
        } 
        #endregion

        #region Indexer
        // Indexer
        // Special type of Property that accept parameters
        // To achieve: Phonebook["Karim"] = 123;
        public int this[string name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Numbers.Length; i++)
                    {
                        if (Names[i] == name)
                        {
                            return Numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Numbers.Length; i++)
                    {
                        if (Names[i] == name)
                        {
                            Numbers[i] = value;
                            break;
                        }
                    }
                }
            } 
            #endregion
        }
    }
}
