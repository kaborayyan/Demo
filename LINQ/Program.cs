namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ
            // Language Integrated Query
            // 40+ Extension Methods can be used against any data
            // data must be in sequence, regardless the data store
            // 13 category
            // in class Enumerable

            // Sequence: Object from class that implement interface IEnumerable
            // Local sequence: L2O "to object", L2XML "to XML"
            // Remote sequence: L2EF "To Entity Framework"

            // Input Sequence -> LINQ Operator -> Output Sequence
            // Input Sequence -> LINQ Operator -> Output one value
            // Input Nothing  -> LINQ Operator -> Output Sequence

            List<int> Numbers01 = new List<int>() { 1, 2, 3, 4, 5 };
            var Result01 = Enumerable.Where(Numbers01, N => N % 2 == 0);
            // Check Where original code
            Numbers01.Any(); // ???

            foreach (var item in Result01)
            {
                Console.Write($"{item} ");
            }

            // LINQ Syntax
            // 1. Fluent Syntax
            // 1.1. LINQ Operator as class member method = Enumerable.Method()
            // Where
            List<int> Numbers02 = new List<int>() { 1, 2, 3, 4, 5 };
            var Result02 = Enumerable.Where(Numbers02, N => N % 2 == 0);
            foreach (var item in Result02)
            {
                Console.Write($"{item} ");
            }
            
            // 1.2. LINQ Operator as Extension method through sequence "Recommended"
            var result = Numbers02.Where(N => N % 2 == 0);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            // 2. Query Syntax "Like SQL Style"
            // start with from
            // end with select or group by
            List<int> Numbers03 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Result03 = from N in Numbers03
                           where N % 2 == 0
                           select N;
            // The code is written exactly like the sequence of execution
            foreach (var item in Result03)
            {
                Console.Write($"{item} ");
            }
            // some will be easier using the Query Syntax
            // like join, group by, let, into

            // LINQ Execution ways
            // 1. Differed Execution way: 10 Categories = executed when needed
            // 2. Immediate Execution way: 3 Categories
            // [Elements operators - Casting Operators - Aggregate Operators]            
            List<int> Numbers04 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Result04 = Numbers04.Where(N => N % 2 == 0);
            Numbers04.AddRange(new int[] { 10, 11, 12 });
            foreach (var item in Result04) // where is executed here when needed
            {
                Console.Write($"{item} "); // the result will include 10 and 12
            }

            // Load the data for the work
        }
    }
}
