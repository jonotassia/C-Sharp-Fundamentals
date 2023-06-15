using System.Text;

(bool, int) IsPalindrome(string str)
{ 
    StringBuilder modStr = new StringBuilder(str.Length);
    bool isPal = true;

    foreach (char ch in str)
    {
        if (char.IsLetterOrDigit(ch))
        {
            modStr.Append(char.ToLower(ch));
        }
    }

    for (int i = 0; i < modStr.Length / 2; i++)
    {
        if (modStr[i] != modStr[modStr.Length - i - 1])
        {
            isPal = false;
            break;
        }
    }

    return (isPal, modStr.Length);
}

(bool isPal, int length) output;
string input;

do
{
    Console.WriteLine("Enter a palindrome: ");
    input = Console.ReadLine();

    if (input == "exit") { break; }

    output = IsPalindrome(input);

    Console.WriteLine($"Palindrome: {output.isPal}, Length: {output.length}");
} while (input != "exit");

