using System.Text;
using System.Globalization;

// Declare strings
string outstr;
string str1 = "Hello, I am Jono";
string str2 = "My best friend is Monkey";
string str3 = "His best friend is Wald";
string[] strs = { "one", "two", "three", "four" };

// Length of string
Console.WriteLine(str1.Length);

// Access letters in string
Console.WriteLine(str1[5]);

// Iterate over letters in string
foreach (var s in str1)
{
    if (s == 'J')
    {
        Console.WriteLine("J found");
        break;
    }
}

// String concatenation
outstr = String.Concat(strs);
Console.WriteLine(outstr);

// Join strings together
outstr = String.Join("...", strs);
Console.WriteLine(outstr);

// String comparison
// Ordinal comparison of 2 strings:
// < 0: first string comes BEFORE the second one in sort order
// 0: They would come together
// > 0: first string comes AFTER second in sort order
int result = String.Compare(str1, str1);
Console.WriteLine(result);

// If you just want a boolean, you can just use the equals operator
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

// String searching
// Index of will return -1 if it does not find a the char/string
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("Jono"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("Jono"));

outstr = str1.Replace("Jono", "Kate");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf("Jono"));

// String formatting
int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] intlMixPct = { 0.25, 0.5, 0.75, 0.85 };
int val1 = 1234;
decimal val2 = 1234.5678m;

// Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (number), G (general), F (fixed-point),
// E (exponential), D (decimal), P (percent), X (hexadecimal),
// C (Currency in local format)
Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

// Add a number to specify precision
Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

// Formatting with alignment and spacing
Console.WriteLine("{0,12}, {1,12}, {2,12}, {3,12}", quarters[0], quarters[1], quarters[2], quarters[3]);
Console.WriteLine("{0,12:C0}, {1,12:C0}, {2,12:C0}, {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);
Console.WriteLine("{0,12:P0}, {1,12:P0}, {2,12:P1}, {3,12:P2}", intlMixPct[0], intlMixPct[1], intlMixPct[2], intlMixPct[3]);

// String interpolation - allows you to place variables directly into a string
// Intitiated with a $ right before the string
// You can still use the same formatting options as with string formatting, and you can also add expressions
// To escape a curly brace, you need to escape it using another curly brace {{}}
string make = "Mercedes-Benz";
string model = "G Class";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

Console.WriteLine($"This car is a {year} {make} {model}, with {{{miles * 1.6:F2}}} km and costs {price:C2}");

// StringBuilder
int jumpCount = 10;
string[] animals = { "goats", "cats", "pigs" };

// Create a StringBuilder
StringBuilder sb = new StringBuilder("Initial string.", 200);

// Print basic stats about the String Builder
Console.WriteLine($"Capacity {sb.Capacity}; Length: {sb.Length}");

// Add some strings to the builder using Append
sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog.");

// AppendLine can append a line ending;
sb.AppendLine();

// AppendFormat can be used to append formatted strings;
sb.AppendFormat("He did this {0} times.", jumpCount);
sb.AppendLine();

// AppendJoin can iterate over a set of values
sb.Append("He also jumped over ");
sb.AppendJoin(',', animals);

// Modify the content using replace
sb.Replace("fox", "cat");

// Insert content at any index
sb.Insert(0, "this is the ");

// Convert to a final string
Console.WriteLine($"Capacity {sb.Capacity}; Length: {sb.Length}");
Console.WriteLine(sb.ToString());

// String Parsing
string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

// The parse function attempts to parse a string into a number
// but it might throw an exception, se we need to catch that
int targetNum = 0;
try
{
    // Use Parse to try to convert string to integer
    targetNum = int.Parse(numStr1);
    Console.WriteLine(targetNum);

    // Parse float to integer - this only works if trailing decimals are 0.
    // Requires System.Globalization namespace
    targetNum = int.Parse(numStr2, NumberStyles.Float);
    Console.WriteLine(targetNum);

    // Use parse to try a number with a thousands marker
    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);

    // Use parse to try a number with thousands marker AND Decimal
    // Also only works if you trailing decimals are 0
    targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);

    // This works with other types too
    Console.WriteLine(bool.Parse("True"));
    Console.WriteLine(float.Parse("1.235"));
}
catch
{
    Console.WriteLine("Conversion failed");
}

// The TryParse function is similar but handles the exception for us
bool succeeded = false;
    succeeded = Int32.TryParse(numStr1, out targetNum);
    if (succeeded)
    {
        Console.WriteLine(targetNum);
    }

