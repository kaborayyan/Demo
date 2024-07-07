using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

// Access Modifiers indicate Accessibilty Scope
// From the narrowest to the widest
//   1. Private 
//   2. Private Protected
//   3. Protected
//   4. Internal
//   5. Internal Protected
//   6. Public

// Largest scope is the NameSpace
// Inside a namespace you can write
//   1. Class
//   2. Struct
//   3. Interface
//   4. Enums

// Access modifiers inside Namespace are only:
// 1. Internal (default)
// 2. Public

// Internal means accessible in its own project only
// Public will be accessible to other projects after using a reference:
// use ClassLibraryName

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
