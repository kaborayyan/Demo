using System.Collections;
using static LINQ.ListGenerator;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ
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
            #endregion

            #region LINQ Syntax
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
            Console.WriteLine();

            // 1.2. LINQ Operator as Extension method through sequence "Recommended"
            var result = Numbers02.Where(N => N % 2 == 0);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

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
            Console.WriteLine();
            // some will be easier using the Query Syntax
            // like join, group by, let, into
            #endregion

            #region LINQ Execution Ways
            // LINQ Execution Ways
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
            Console.WriteLine();
            #endregion

            #region Testing The Data
            // Load the data for the work
            // Testing the data for work

            Console.WriteLine(ListGenerator.ProductsList[0]);
            Console.WriteLine(ListGenerator.CustomersList[0]);

            // Add above name space
            // using static LINQ.ListGenerator

            Console.WriteLine(ProductsList[0]);
            Console.WriteLine(CustomersList[0]);
            #endregion

            #region Filtration Operators
            // 1. Filtration Operators [where-OfType] Differed Execution

            // Where
            // EX to get: All products that are out of stock

            Console.WriteLine("\nAll products that are out of stock");
            Console.WriteLine("==========");

            // Fluent Syntax
            var Result05 = ProductsList.Where(P => P.UnitsInStock == 0);

            // Query Syntax
            Result05 = from P in ProductsList
                       where P.UnitsInStock == 0
                       select P;

            foreach (var item in Result05)
            {
                Console.WriteLine(item);
            }

            // EX02
            Console.WriteLine("\nMeat & Poultry");
            Console.WriteLine("==========");

            // Fluent Syntax
            var Result06 = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            // Query Syntax
            Result06 = from P in ProductsList
                       where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
                       select P;

            foreach (var item in Result06)
            {
                Console.WriteLine(item);
            }

            // Indexed where
            Console.WriteLine("\nIndexed Where");
            Console.WriteLine("==========");

            // Indexed Where is only valid in Fluent Syntax, No query version for it
            // It's an overload of the normal Where
            // It accepts two parameters
            // The first is the object and the second is its index

            var Result07 = ProductsList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            // The first 10 units that has 0 in stock
            foreach (var item in Result07)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var Result08 = ProductsList.Where((P, I) => I < 5 && P.UnitsInStock > 0);
            // The first 5 units in stock
            foreach (var item in Result08)
            {
                Console.WriteLine(item);
            }

            // OfType
            Console.WriteLine("\nOfType");
            Console.WriteLine("==========");
            ArrayList list = new ArrayList() { 1, 1.2, "Karim", 12, 6, 7, "Ali", "Fayez", 9.1 };
            // This ArrayList is a sequence
            var result01 = list.OfType<int>();
            var result02 = list.OfType<string>();
            var result03 = list.OfType<double>();
            foreach (var item in result02)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Transformation Operators
            // 2. Transformation Operator - Select / SelectMany

            // Select

            // Fluent Syntax
            Console.WriteLine("\nShow Product Names Only");
            Console.WriteLine("==========");
            // Show Product names only
            var Result09 = ProductsList.Select(P => P.ProductName);

            //Query Syntax
            Result09 = from P in ProductsList
                       select P.ProductName;
            foreach (var item in Result09)
            {
                Console.WriteLine(item);
            }

            // EX02 .. IMPORTANT

            // Fluent Syntax
            Console.WriteLine("\nShow Customer Names Only");
            Console.WriteLine("==========");
            // Show Customer Names Only
            var Result10 = CustomersList.Select(C => C.CustomerName);

            foreach (var item in Result10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nShow ProductID and Product Name");
            Console.WriteLine("==========");
            // Show ProductID and Product Name
            // var Result11 = ProductsList.Select(P => { return new { Id = P.ProductID, Name = P.ProductName }; });
            var Result11 = ProductsList.Select(P => new { Id = P.ProductID, Name = P.ProductName });
            var Result12 = ProductsList.Select(P => new { P.ProductID, P.ProductName });

            // Query Syntax
            // var Result12 = from P in ProductsList select P; // to select the whole product
            Result12 = from P in ProductsList
                       select new { P.ProductID, P.ProductName };

            foreach (var item in Result12)
            {
                Console.WriteLine(item);
            }

            // SelectMany
            // If the property is a list or array
            Console.WriteLine("\nShow Orders");
            Console.WriteLine("==========");
            // Fluent Syntax
            var Result13 = CustomersList.SelectMany(C => C.Orders);

            // Query Syntax
            Result13 = from C in CustomersList
                       from O in C.Orders
                       select O;
            foreach (var item in Result13)
            {
                Console.WriteLine(item);
            }

            // EX03
            Console.WriteLine("\nUsing where and select together");
            Console.WriteLine("==========");
            // using where and select together
            var Result14 = ProductsList.Where(P => P.UnitsInStock > 0).Select(P => new
            {
                P.ProductID,
                P.ProductName,
                NewPrice = P.UnitPrice - P.UnitPrice * 0.1m
            });

            foreach (var item in Result14)
            {
                Console.WriteLine(item);
            }

            // Indexed select
            // An overload of select
            // Can't be written using query expression
            Console.WriteLine("\nIndexed Select");
            Console.WriteLine("==========");
            var Result15 = ProductsList.Select((P, I) => new { I, P.ProductName });
            foreach (var item in Result15)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Ordering Operators
            // 3. Ordering Operators

            Console.WriteLine("\nOrderBy");
            Console.WriteLine("==========");
            // OrderBy
            var Result16 = ProductsList.Select(P => new { P.ProductName, P.UnitPrice }).OrderBy(P => P.UnitPrice);
            Result16 = ProductsList.Select(P => new { P.ProductName, P.UnitPrice }).OrderByDescending(P => P.UnitPrice);

            // Query Syntax
            var Result17 = from P in ProductsList
                           orderby P.UnitPrice
                           select new
                           {
                               P.ProductName,
                               P.UnitPrice
                           };

            Result17 = from P in ProductsList
                       orderby P.UnitPrice descending
                       select new
                       {
                           P.ProductName,
                           P.UnitPrice
                       };

            foreach (var item in Result17)
            {
                Console.WriteLine(item);
            }

            // Using OrderBy & ThenBy to sort based on two parameters
            Console.WriteLine("\nThenBy");
            Console.WriteLine("==========");

            var Result18 = ProductsList.Select(P => new { P.ProductName, P.UnitPrice, P.UnitsInStock }).OrderBy(P => P.UnitsInStock).ThenBy(P => P.UnitPrice);
            // REMEMBER
            // The parameters used for ordering must me displayed in the select sentence

            var Result19 = from P in ProductsList
                           orderby P.UnitsInStock, P.UnitPrice descending
                           select new
                           {
                               P.ProductName,
                               P.UnitsInStock,
                               P.UnitPrice
                           };

            foreach (var item in Result19)
            {
                Console.WriteLine(item);
            }

            var Result20 = ProductsList.Reverse<Product>();
            foreach (var item in Result19)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Elements Operators
            // 4. Elements Operators - Immediate Execution

            var Result21 = ProductsList.First();
            // Shows first product
            // May throw exception if empty sequence
            Console.WriteLine(Result20);

            var Result22 = ProductsList.Last();
            // Shows last product
            // May throw exception if empty sequence

            var Result23 = ProductsList.FirstOrDefault();
            // Will not throw exception if empty, it will return the default value null

            var Result24 = ProductsList.LastOrDefault();
            // Will not throw exception if empty, it will return the default value null


            // Overload for First()
            var Result25 = ProductsList.First(P => P.UnitsInStock == 0);
            // May throw exception if the condition can not be met

            // Overload for Last()
            var Result26 = ProductsList.Last(P => P.UnitsInStock == 0);
            // May throw exception if the condition can not be met

            // Overload for FirstOrDefault
            var Result27 = ProductsList.FirstOrDefault(new Product() { ProductName = "Default Value" });
            var Result28 = ProductsList.FirstOrDefault(P => P.UnitsInStock == 100);
            var Result29 = ProductsList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Value" });

            // Overload for LastOrDefault
            var Result30 = ProductsList.LastOrDefault(new Product() { ProductName = "Default Value" });
            var Result31 = ProductsList.LastOrDefault(P => P.UnitsInStock == 100);
            var Result32 = ProductsList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Value" });


            // ElementAt()
            var Result33 = ProductsList.ElementAt(1); // May return Exception
            Console.WriteLine(Result33);

            var Result34 = ProductsList.ElementAtOrDefault(1000);

            // var Result35 = ProductsList.Single();
            // if the sequence has only one item it will return it
            // otherwise it will throw exception

            var Result36 = ProductsList.Single(P => P.ProductID == 1);
            var Result37 = ProductsList.Single(P => P.UnitsInStock == 5);

            // var Result38 = ProductsList.SingleOrDefault();
            var Result39 = ProductsList.SingleOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Value" });

            var Result40 = ProductsList.DefaultIfEmpty();

            #endregion

            #region Aggregate Operators
            // 5. Aggregate Operators - Immediate Execution
            // Count Sum Average Min Max

            var Result41 = ProductsList.Count(P => P.UnitsInStock == 0);
            // var Result41 = ProductsList.Count; // Better Performance
            Console.WriteLine(Result41);

            var Result42 = ProductsList.Sum(P => P.UnitPrice); // Total of all prices
            // The Property must be numerical

            var Result43 = ProductsList.Average(P => P.UnitPrice);

            var Result44 = ProductsList.Max();
            // To use Max() you need IComparable in Products Class
            // The default will be the unit price which is implemented in the IComparable implementation

            var Result45 = ProductsList.Max(new CompareProductsBasedOnUnitsInStock());
            // You need to create a class that implement IComparer to get the max based on other properties

            // var Result45 = ProductsList.Max(P => P.UnitPrice);
            // This will return the highest price not the object with the highest price

            // Another indirect way to get the Product with the highest units in stock
            var MaxUnitsInStock = ProductsList.Max(P => P.UnitsInStock);
            var Result46 = ProductsList.Where(P => P.UnitsInStock == MaxUnitsInStock);

            // Same with Min()
            var Result47 = ProductsList.Max(P => P.UnitsInStock);
            var Result48 = ProductsList.Max(P => P.UnitPrice);

            // MaxBy()
            var Result49 = ProductsList.MaxBy(P => P.UnitPrice);
            // Will return the product itself

            // MinBy()
            var Result50 = ProductsList.MinBy(P => P.UnitPrice);
            // Will return the product itself

            // Aggregate
            List<string> Names01 = new List<string>() { "Ahmed", "Ali", "Omar", "Mohamed" };

            var Result = Names01.Aggregate((str01, str02) => $"{str01} {str02}");
            // Aggregate takes two parameters of string type and returns string also
            // str01 = Ahmed, str02 = Ali -> Ahmed Ali
            // The next time str01 = Ahmed Ali, str02 = Omar -> Ahmed Ali Omar
            // The last cycle str01 = Ahmed Ali Omar, str02 = Mohamed -> Ahmed Ali Omar Mohamed

            #endregion

            #region Casting Operators
            // 6.Casting Operators
            
            // List<Product> Result51 = (List<Product>)ProductsList.Where(P => P.UnitsInStock == 0);
            // It will give Exception

            List<Product> Result52 = ProductsList.Where(P => P.UnitsInStock == 0).ToList();

            Product[] Result53 = ProductsList.Where(P => P.UnitsInStock == 0).ToArray();

            Dictionary<long, Product> Result54 = ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);

            HashSet<Product> Result55 = ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();

            #endregion

            #region Generation Operators
            // 7. Generation Operators
            // The only way to call them as a class member method
            // Through enumerable

            // Range
            Console.WriteLine("\n\nGeneration Operator: Range()");
            var Result56 = Enumerable.Range(10, 50);
            // Will generate 50 numbers starting from 10
            foreach (var item in Result56)
            {
                Console.Write($"{item} ");
            }

            // Repeat
            Console.WriteLine("\n\nGeneration Operator: Repeat()");
            var Result57 = Enumerable.Repeat(new Product() { ProductName = "Repeated Product" }, 20);
            // Will create 20 products with name "Repeated Product"
            foreach (var item in Result57)
            {
                Console.WriteLine(item);
            }

            // Empty
            Console.WriteLine("\nGeneration Operator: Empty()");
            var Result58 = Enumerable.Empty<Product>();
            // Will create empty sequence
            #endregion

            #region Set Operators
            // 8. Set Operators - Union Family
            var Seq01 = Enumerable.Range(0, 100); // 0 .. 99 
            var Seq02 = Enumerable.Range(50, 100); // 50 ..149 

            var Result59 = Seq01.Union(Seq02); // Without duplication
            var Result60 = Seq01.Concat(Seq02); // With duplication ~ like union all
            
            Result60 = Result60.Distinct(); // To remove the duplicates
            
            foreach (var item in Result60)
            {
                Console.Write($"{item} ");
            }

            var Result61 = Seq01.Intersect(Seq02); // 50-99
            var Result62 = Seq01.Except(Seq02); // 0-49
            #endregion

            #region Quantifier Operators
            // 9. Quantifier Operators
            // All of them Return Bool True / False
            // Any All SequenceEqual Contains

            // Any()
            // return true if the sequence has at least one parameter
            // return true if at least one member matches the sequence

            var Result63 = ProductsList.Any();
            var Result64 = ProductsList.Any(P => P.UnitsInStock == 10);
            
            // All()
            // return true if the sequence is empty
            // return true if all members matches the condition
            var Result65 = ProductsList.Any();
            var Result66 = ProductsList.Any(P => P.UnitsInStock == 10);


            // SequenceEqual
            var Result67 = Seq01.SequenceEqual(Seq02);
            var Result68 = Seq01.Contains(1); 
            #endregion
        }
    }
}
