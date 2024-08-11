namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Anonymous Type

            Employee Emp01 = new Employee() { Id = 12, Name = "Karim", Salary = 3000 };
            var Emp02 = new { Id = 12, Name = "Karim", Salary = 3000 }; // Anonymous Type
            var Emp03 = new { Id = 10, Name = "Yasmin", Salary = 2500 }; // Anonymous Type
            // The compiler will detect data type based on the initial value

            Console.WriteLine(Emp02.Id);
            Console.WriteLine(Emp02.Name);
            Console.WriteLine(Emp02.Salary);

            Console.WriteLine(Emp02.GetType().Name); // Anonymous
            Console.WriteLine(Emp03.GetType().Name); // Anonymous

            // The compiler can use the same anonymous datatype for other variables if
            // 1. They have the same property names "Case sensitive"
            // 2. They have the same order of properties
            // 3. The same property datatype

            // The properties will immutable however
            // Emp02.Id = 15; // invalid

            var Emp04 = Emp02; // valid
            var Emp05 = Emp02 with { Id = 16 }; // valid new feature in C# 10.0

            if (Emp02.Equals(Emp04))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            // Will give equal since comparing references

            // Performance wise
            // var is better with anonymous data than dynamic

        }
    }
}
