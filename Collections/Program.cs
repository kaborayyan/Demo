using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        #region Functions
        public static int SumArrayList(ArrayList arrayList)
        {
            int Sum = 0;
            if (arrayList is not null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Sum += (int)arrayList[i]; // Casting from Object to int
                                              // Unboxing => unsafe
                }
            }
            return Sum;
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }
            }
            return Sum;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Collections
            // What are Collections?
            // they're the implementation of data structures in .net

            // What are data structures?            
            // It is a way of arranging data on a computer so that it can be accessed and updated efficiently.
            // A collection of data values, the relationships among them and the functions or operations that can be applied to the data

            // They can be classified into
            // 1. Non generic: based on Object "Older"
            // Arraylist
            // 2. - Generic Collections: based on generics "New"
            // List, LinkedList, Stack, Queue, Dictionary
            #endregion

            #region ArrayList
            // ArrayList
            // Non generic collections
            // Dynamic size
            ArrayList arrayList01 = new ArrayList();
            // arrayList = array of objects => initial size 0
            // You can also say = new ArrayList(5); 5 is the capacity
            // You can also say = new ArrayList(5) {1, 2, 3, 4, 5};
            // You can also say = new ArrayList(array); it will take the elements of the array and add them to the ArrayList you created

            Console.WriteLine("After creation");
            Console.WriteLine($"The count of ArrayList = {arrayList01.Count}. The size of ArrayList = {arrayList01.Capacity}"); // 0 & 0
            // Count is the actual number of elements
            // Capacity the no of elements that can be possibly carried
            Console.WriteLine();

            arrayList01.Add(1);
            // when you add an element.
            // the parameterless constructor creates an array with default capacity of 4 in the heap
            Console.WriteLine("After Adding One element");
            Console.WriteLine($"The count of ArrayList = {arrayList01.Count}. The size of ArrayList = {arrayList01.Capacity}"); // 1 & 4            
            Console.WriteLine();

            arrayList01.Add(2);
            arrayList01.AddRange(new int[] { 3, 4 });
            Console.WriteLine("After Adding 3 more element");
            Console.WriteLine($"The count of ArrayList = {arrayList01.Count}. The size of ArrayList = {arrayList01.Capacity}"); // 4 & 4            
            Console.WriteLine();

            arrayList01.Add(5); // Adding the 5th element
                                // Creates new array at heap with double size = 8
                                // It will add the old elements to the new array
                                // The old array will be unreachable object

            Console.WriteLine("After Adding the 5th element");
            Console.WriteLine($"The count of ArrayList = {arrayList01.Count}. The size of ArrayList = {arrayList01.Capacity}"); // 5 & 8            
            Console.WriteLine();

            arrayList01.TrimToSize(); // free || deallocate || delete unused bytes
                                      // creates new array at heap with size = count of elements
                                      // copy data from old array to new array
                                      // old array is unreachable
            Console.WriteLine("After TrimToSize()");
            Console.WriteLine($"The count of ArrayList = {arrayList01.Count}. The size of ArrayList = {arrayList01.Capacity}"); // 5 & 5         
            Console.WriteLine();

            int Result = SumArrayList(arrayList01);
            Console.WriteLine($"Sum of ArrayList is {Result}");

            // Problems with ArrayLists
            // Remember when any value is added we are doing boxing
            // We should avoid this as possible since boxing and unboxing is memory consuming
            arrayList01.Add("Karim"); // allowed. it will not cause error
                                      // ArrayList is a heterogeneous list
                                      // You can add boolean or char variables also
                                      // To loop through mixed ArrayList you need to use "var"

            // Compiler can't enforce type safety

            #endregion

            #region Lists
            // Generic Collection - List
            // A generic version of ArrayList
            // Solving the problems of ArrayList

            List<int> Numbers01 = new List<int>();
            // An array of int is created here
            Console.WriteLine("After creation");
            Console.WriteLine($"The count of List = {Numbers01.Count}. The size of List = {Numbers01.Capacity}"); // 0 & 0
            Console.WriteLine();

            Numbers01.Add(1);
            // Upon updating
            // creates new array of int default size 4
            Numbers01.Add(2);
            Numbers01.AddRange(new int[] { 3, 4 });
            Console.WriteLine("After Adding 3 More Elements");
            Console.WriteLine($"The count of List = {Numbers01.Count}. The size of List = {Numbers01.Capacity}"); // 4 & 4
            Console.WriteLine();

            Numbers01.Add(5);
            Console.WriteLine("After Adding 5th");
            Console.WriteLine($"The count of List = {Numbers01.Count}. The size of List = {Numbers01.Capacity}"); // 5 & 8
            Console.WriteLine();
            Numbers01.TrimExcess();
            // Creates new array with size = Count of elements
            // The old List is an unreachable object
            Console.WriteLine("After TrimExcess()");
            Console.WriteLine($"The count of List =  {Numbers01.Count} . The size of List = {Numbers01.Capacity}"); // 5 & 5
            Console.WriteLine();

            List<int> Numbers02 = new List<int>(5) { 1, 2, 3, 4, 5 };
            Console.WriteLine("After creation");
            Console.WriteLine($"The count of List = {Numbers02.Count}. The size of List = {Numbers02.Capacity}"); // 5 & 5
            Console.WriteLine();

            Numbers02.Add(6);
            Console.WriteLine("After Adding the 6th Element");
            Console.WriteLine($"The count of List = {Numbers02.Count}. The size of List = {Numbers02.Capacity}"); // 6 & 10
            Console.WriteLine();
            // Doubling the base value

            // You can loop using foreach or for since Lists have Index
            foreach (int number in Numbers02)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Numbers02[0] = 100; // To change a value directly
            Numbers02[3] = 40;
            // REMEMBER: You can't use the index to add elements e.g position 6
            // Numbers[6] = 200; // Invalid => OutOfRangeException

            foreach (int number in Numbers02)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            int Sum = SumList(Numbers02);
            Console.WriteLine($"The Sum of List = {Sum}.");
            #endregion

            #region List Methods
            // List Methods
            // Add and AddRange => will add at the end

            // Insert and InsertRange
            // To add at a specific index
            Numbers02.Insert(6, 8); // 6 is the location index
            Numbers02.InsertRange(4, new int[] { 9, 10 }); // 4 is the location index
            foreach (int number in Numbers02)
            {
                Console.Write($"{number} ");
            }

            int Index = Numbers02.BinarySearch(3); // will return the location "index" of no. 3
            Console.WriteLine(Index);
            // if not found it will return -ve number

            // BinarySearch() has several overloads one of them can accept objects from Class
            // implementing IComparer

            Numbers02.Clear(); // removes the elements without changing the capacity
            // Same capacity but the count will be zero

            Console.WriteLine(Numbers02.Contains(3)); // return true or false

            List<int> Numbers03 = new List<int>(4) { 1, 2, 3, 4 };
            int[] array01 = new int[10]; // if 4, it will run smoothly

            // CopyTo() has several overloads
            // Numbers03.CopyTo(array01);
            Numbers03.CopyTo(array01, 3); // starting index is 3
                                          // 0 0 0 1 2 3 4 0 0 0

            //Numbers03.CopyTo(1, array01, 5, 3);
            // Take 3 elements from Numbers03 at index 1 and copy them to array01 at index 5

            Numbers02.EnsureCapacity(5); // can increase capacity

            Console.WriteLine(Numbers02.IndexOf(4));
            Console.WriteLine(Numbers02.LastIndexOf(4));

            #endregion

            #region LinkedList
            // Linked List
            // Collection of nodes(data + link to next node)
            // LinkedList
            LinkedList<int> linkedList01 = new LinkedList<int>();
            // This creates the head in the linked list
            Console.WriteLine($"LinkedList Count = {linkedList01.Count}"); // 0

            linkedList01.AddFirst(1);
            linkedList01.AddFirst(2);
            foreach (int number in linkedList01)
            {
                Console.Write($"{number} "); // 2 then 1 because we used AddFirst()
            }

            linkedList01.AddLast(3); // at the end of the linked list

            LinkedListNode<int> AfterNode = linkedList01.Find(1);
            // will return the first node that has the value

            linkedList01.AddAfter(AfterNode, 6);
            linkedList01.AddBefore(AfterNode, 7);
            // can be written directly
            // linkedList01.AddBefore(linkedList01.Find(1), 7);

            foreach (int number in linkedList01)
            {
                Console.Write($"{number} "); // 2 then 1 because we used AddFirst()
            }
            #endregion

            #region Which is which

            // Heterogeneous => ArrayList
            // Homogeneous Fixed Length => Array
            // Homogeneous Dynamic Length => List or LinkedList

            // To Retrieve more => List
            // To Add more => LinkedList

            // IMPORTANT: Listen to this part carefully
            #endregion

            #region Stack
            // Stack
            // Two types non - generic and generic
            // Last in first out LIFO
            // we will use the generic type

            Stack<int> stack = new Stack<int>();
            // empty array size 4 bytes
            Console.WriteLine($"{stack.Count}"); // Only count, no capacity
                                                 // Push to add
                                                 // Pop to delete

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (int number in stack)
            {
                Console.Write($"{number} "); // 3 2 1
            }

            Console.WriteLine(stack.Peek()); // return element on top
            Console.WriteLine(stack.Pop()); // removes element on top

            bool Result02 = stack.TryPop(out int Element01);
            Console.WriteLine(Element01);

            // The main usage if you want to deal with data
            // as Last In, First Out

            #endregion

            #region Queue
            // queue
            // First In First Out FIFO

            Queue<int> queue = new Queue<int>();
            // Head Tail Size

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek()); // return the element at the beginning
            Console.WriteLine(queue.Dequeue()); // removes the element in the beginning
            bool Result03 = queue.TryDequeue(out int Element02);
            Console.WriteLine(Element02);
            #endregion
        }
    }
}
