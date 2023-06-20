using System.Text.RegularExpressions;
using System.Diagnostics;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";

// The IsMatch function is used to determine if the content of a string
// results in a match with the given RegEx
Regex CapWords = new Regex(@"[A-Z]\w+");
Console.WriteLine(CapWords.IsMatch(teststr1));
Console.WriteLine(CapWords.IsMatch(teststr2));

// The RegexOptions argument can be used to perform
// case-insensitive searches
Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);
Console.WriteLine(NoCase.IsMatch(teststr1));
Console.WriteLine(NoCase.IsMatch(teststr2));

// Use the Match (return match lazily) and Matches (returns collection of matches) method 
// to get information about specific Regex matches for a given pattern
Match m = CapWords.Match(teststr1);
while (m.Success)
{
    Console.WriteLine($"'{m.Value}' found at position {m.Index}");
    m = m.NextMatch();
}

MatchCollection mc = CapWords.Matches(teststr1);
Console.WriteLine($"Found {mc.Count} matches.");

foreach (Match mtc in mc)
{
    Console.WriteLine($"'{mtc.Value}' found at position {mtc.Index}");
}

// Regular expressions can be used to replace content in strings
string result = CapWords.Replace(teststr1, "***");
Console.WriteLine(teststr1);
Console.WriteLine(result);

// Replacement text can be generated on the fly using MatchEvaluator
// This is a delegate that computes the new value of the replacement
string MakeUpper(Match m)
{
    string s = m.ToString();
    if (m.Index == 0)
    {
        return s;
    }
    return s.ToUpper();
}

string upperStr = CapWords.Replace(teststr1, new MatchEvaluator(MakeUpper));
Console.WriteLine(teststr1);
Console.WriteLine(upperStr);

// Using Timeout settings for RegEx
const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// Use stopwatch to show elapsed time
Stopwatch sw;

// Add a timeout value when executing RegEx
const int MAX_REGEX_TIME = 1000;
TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

// Run the expression and output the result
try
{
    sw = Stopwatch.StartNew();
    Regex rgx = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
    MatchCollection matches = rgx.Matches(thestr);
    sw.Stop();
    Console.WriteLine($"Found {matches.Count} matches in {sw.Elapsed.TotalSeconds} time: ");
    foreach (Match match in matches)
    {
        Console.WriteLine($"'{match.Value}' found at position {match.Index}");
    }
}
catch (RegexMatchTimeoutException e)
{
    Console.WriteLine($"The RegEx took too long to execute: {e.MatchTimeout}");
}