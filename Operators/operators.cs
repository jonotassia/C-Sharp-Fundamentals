// Declar variables to exercise the operators
int x = 10, y = 5;
string a = "abcd", b = "efgh";

// Basic math operators
Console.WriteLine("---BASIC MATH---");
Console.WriteLine(x / y);
Console.WriteLine(a + b);

// Increment and Decrement operators
Console.WriteLine("---INPUT STREAM---");
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);

// String concatenation
a += b;
Console.WriteLine(a);

// Logical operators
Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);

// Null-coalescing operators - This sets/uses the value on the left unless it is null, in which case it will use the value on the right
string str = null;
Console.WriteLine(str ?? "Unknwon string");

str ??= "New String";
Console.WriteLine(str);