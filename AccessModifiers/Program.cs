using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

// Access Modifiers indicate Accessibilty Scope
// Largest scope is the name space inside you can write(Class struct interface enums)
// From the narrowest to the widest

// Private 
// Private Protected
// Protected
// Internal
// Internal Protected
// Public

// Access modifiers inside Namespace are internal (default) and public only
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
