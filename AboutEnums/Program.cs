namespace AboutEnums
{
    internal class Program
    {
        // Enums are a special data type
        // that enable a variable to be a preset constants
        // As default they are stored as int even if you did not write ": int"
        // They are case sensitive
        // default value is 0 so avoid using it
        // Always try to assign values
        public enum Days : int
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        // You can assign different values instead of the default 012
        public enum Roles : byte // 0 => 255 so we can't assign values > 255
        {
            Admin = 10,
            Editor = 20,
            Viewer = 30
        }
        [Flags]
        public enum Permission : byte // to be able to use binary
        {
            Delete = 1,
            Write = 2,
            Read = 4,
            Execute = 8
        }
        static void Main(string[] args)
        {
            Days Day = Days.Wednesday; // you can not use any values other than that were defined in the enums
            // Days Day = Days.Weekend => not valid
            Days AnotherDay = (Days)3; // expilcit casting
            
            if (Day == Days.Wednesday) // this is how to use logical operators
            {
                Console.WriteLine(Day);
                Console.WriteLine(AnotherDay);
            }

            // How to read data from user
            // Several ways
            // two that do boxing-unboxing many times

            // First the bad way to do it
            Console.WriteLine("Enter your job");
            Roles MyJob = (Roles) Enum.Parse(typeof(Roles), Console.ReadLine()); // can cause exception

            // A better method
            Console.WriteLine("Enter your job");
            Enum.TryParse(typeof(Roles), Console.ReadLine(), out object MyJob02);

            // A better way that ignores case sensitivity
            Console.WriteLine("Enter your job");
            Enum.TryParse<Roles>(Console.ReadLine(), out Roles MyJob03);
            Console.WriteLine("Enter your job");
            Enum.TryParse<Roles>(Console.ReadLine(), true, out Roles MyJob04); // true to ignore case

            Permission Admin = (Permission)6;
            Console.WriteLine(Admin);

            // Use bitwise operators to modify the value ^ & |
            // ^ XOR likes 0 different 1
            // & AND all 0 except 1+1 = 1 => to check if present or not
            // | OR all 1 except 0+0 = 0 => to check if present and if not, it will add it
            Admin = Admin ^ Permission.Delete; // ^ will add it or remove it if present
            Console.WriteLine(Admin);

        }
    }
}
