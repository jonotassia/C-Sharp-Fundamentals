// If-else
int val = 0;

if (val > 0)
{
    Console.WriteLine(val);
}
else
{
    Console.WriteLine("Too small");
}

// Ternary operator - (condition) ? true output : false output
Console.WriteLine(val > 0 ? val : "Too small");

// Switch - useful when you need to control for many different conditions. The variable can be any data type.
switch (val)
{
    case 0: 
        Console.WriteLine("Zero"); 
        break;
    case > 0:
        Console.WriteLine(val);
        break;
    default:
        Console.WriteLine("Too small");
        break;
}

// Foreach - the equivalent of "for x in y" in Python
int[] x = { 3, 41, 325, 12, 34 };

foreach (int i in x)
{
    Console.WriteLine(i);
}

// Do while loops - ensures it runs at least once before breaking
string inputStr = null;

do
{
    Console.WriteLine("Enter a value: ");
    inputStr = Console.ReadLine();
} while (inputStr != "exit");


// Exception handling - Try-catch expressions

int n = 1002;
int m = 0;
int result;

try
{
    if (n > 1000) {
        throw new ArgumentOutOfRangeException("n", "n must be 1000 or less.");
    }
    
    result = n / m;
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Sorry, 1000 is the limit.");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("This is a good place to clean up files or any resources that need to be released.");
}