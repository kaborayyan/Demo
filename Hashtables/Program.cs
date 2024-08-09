using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hashtables
            // Collections in C#
            // Lists
            // Hashtables

            // Lists
            // Non-generic: ArrayList
            // Generic: Lists, LinkedList, Stack, Queue

            // Hashtables
            // Non generic: Hashtables
            // Generic: Dictionary

            // HashTable: Non-generic
            // Key & Value Pairs
            // Key is unique
            // Key is used to search for the Value
            // Hashing Method
            #endregion

            #region EX01
            Hashtable Note = new Hashtable();
            // The keys must be unique
            Note.Add("Ahmed", 123456789);
            Note.Add("Karim", 012345678);
            Note.Add("Fayez", 111222333);
            Note.Add("Mahmoud", 987654321);
            foreach (DictionaryEntry item in Note)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine();
            foreach (object item in Note.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Note["Mahmoud"] = 112233445;
            foreach (DictionaryEntry item in Note)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine(Note.ContainsKey("Ahmed")); // to check for key => true
            Console.WriteLine(Note.ContainsValue(123456789)); // to check for value => true

            // Speed of code
            // O(n^2)
            // O(n)
            // O(n * log(n))
            // O(log(n))
            // O(1)

            Note.Remove("Ahmed");
            Console.WriteLine();
            Console.WriteLine(Note.ContainsKey("Ahmed")); // to check for key => false
            Console.WriteLine(Note.ContainsValue(123456789)); // to check for key => false
            #endregion

            #region Ex02
            Console.WriteLine("\nDictionary");
            Dictionary<string, int> Notes = new Dictionary<string, int>();
            // The keys must be unique
            Notes.Add("Ahmed", 123456789);
            Notes.Add("Karim", 012345678);
            Notes.Add("Fayez", 111222333);
            Notes.Add("Mahmoud", 987654321);
            foreach (KeyValuePair<string, int> item in Notes)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine();
            foreach (object item in Notes.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Notes["Mahmoud"] = 112233445;
            foreach (DictionaryEntry item in Note)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Notes.EnsureCapacity(10);
            Console.WriteLine();
            Console.WriteLine(Notes.ContainsKey("Ahmed")); // to check for key => true
            Console.WriteLine(Notes.ContainsValue(123456789)); // to check for value => true

            // Speed of code
            // O(n^2)
            // O(n)
            // O(n * log(n))
            // O(log(n))
            // O(1)

            Notes.Remove("Ahmed");
            Console.WriteLine();
            Console.WriteLine(Notes.ContainsKey("Ahmed")); // to check for key => false
            Console.WriteLine(Notes.ContainsValue(123456789)); // to check for key => false
            #endregion
        }
    }
}
