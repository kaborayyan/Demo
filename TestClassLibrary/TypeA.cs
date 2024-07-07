using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestClassLibrary
{
    public class TypeA
    {
        #region Access Modifiers inside Class Struct
        // What's allowed inside Classes
        //    1. Attributes = fields = variables
        //    2. Functions(Constructors - Getters Setters - Methods)
        //    3. Properties (Full - Automatic - Indexer)
        //    4. Events

        // All Access Modifiers are allowed inside Classes
        //   1. Private (default) 
        //   2. Private Protected
        //   3. Protected
        //   4. Internal
        //   5. Internal Protected
        //   6. Public
        // Since Classes allow inheritance, Protected can be used

        // This is not the case with structs
        // They don't allow inheritance
        // Thus 3 access modifiers are allowed
        //   1. Private (default) 
        //   2. Internal
        //   3. Public

        // Lock => Private
        // Heart => Internal
        // Nothing => Public

        #endregion

        //public TypeA()
        //{
        //    TypeB TestObjectB = new TypeB(); // possible inside the same project
        //}
        private int X; // access inside this code block only
        internal int Y; // access within the project
        public int Z; // access even to other projects after using the namespace


    }
}
