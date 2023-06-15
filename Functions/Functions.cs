// Setting a default value for a parameter
void printWithPrefix(string str, string prefix = "")
{
    Console.WriteLine($"{prefix} {str}");
}

printWithPrefix("Hello");
printWithPrefix("Hello", ">: ");

// Call with named parameters
printWithPrefix(str: "Hello", prefix: "% ");

// Ordinary value arguments cannot be modified by the function (ie pass-by-value)
static void TestFunc1(int arg1)
{
    arg1 += 10;
    Console.WriteLine(arg1);
}

int arg1 = 10;
TestFunc1(arg1);
Console.WriteLine(arg1);

// You can pass a variable by reference using the "ref" keyword
// This allows you to change a value and reflect it outside function
static void TestFunc2(ref int arg1)
{
    arg1 += 10;
    Console.WriteLine(arg1);
}

TestFunc2(ref arg1);
Console.WriteLine(arg1);

// You can specify that a variable should be the return value
// rather than supply data to the function
// NOTE: This is old syntax. Recommendation for returning multiple values is now tuple structure
static void PlusTimes(int arg1, int arg2, out int sum, out int product)
{
    sum = arg1 + arg2;
    product = arg1 * arg2;  
}

int a, b;
PlusTimes(arg1, arg1, out a, out b);
Console.WriteLine($"{a} {b}");

// Returning multiple values
// Tuples are grouped values that can be typed
(int a, int b) tup1 = (5, 10);
var tup2 = ("Some text", 10.5f);

// Tuples can be accessed using the attribute notation, and by default, each element is named Item1, Item2, etc
tup1.b = 20;
tup2.Item1 = "New String";

Console.WriteLine($"{tup1.a}, {tup1.b}");
Console.WriteLine($"{tup2.Item1}, {tup2.Item2}");

// Adding a return with tuples
static (int, int) PlusTimesTup(int a, int b)
{
    return (a + b, a * b);
}

(int, int) tup3 = PlusTimesTup(6, 12);
Console.WriteLine($"{tup3.Item1}, {tup3.Item2}");