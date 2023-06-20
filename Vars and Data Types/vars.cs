namespace C_Sharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Core data types
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = default;
            char c = 'c';

            // Strings
            string str = "a string";

            // Implicit declaration - determines data type automatically
            var x = 10;
            var z = "Hello";

            // Arrays
            int[] vals = new int[5];
            string[] strs = { "one", "two", "three" };

            // Writing to console
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, f, d, b, c, str, x, z);

            // Null means "No Value"
            object obj = null;
            Console.WriteLine(obj);

            // Implicit conversion between types
            long bignum;
            bignum = i;

            // Explicit conversions
            float i_to_f = (float)i;
            Console.WriteLine(i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine(f_to_i);
        }
    }
}