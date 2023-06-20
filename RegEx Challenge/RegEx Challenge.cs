using System.Text.RegularExpressions;

string dateInput = "";

do
{
    Console.WriteLine("Date to transform (mm/dd/yyyy): ");
    dateInput = Console.ReadLine();
    DateTime date;

    if (dateInput == "exit")
    {
        break;
    }

    // Check if date is real
    if (DateTime.TryParse(dateInput, out date))
    {
        // Must solve using RegEx
        Regex regex = new Regex(@"\d+");
        MatchCollection matches = regex.Matches(dateInput);

        Console.WriteLine($"{matches[2]}-{matches[0]}-{matches[1]}");
    }
    else
    {
        Console.WriteLine("Invalid date.");
    }
} while (dateInput != "exit");