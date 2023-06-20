string dtInput = "";

do
{
    Console.WriteLine("Please enter a date (or 'exit'): ");
    dtInput = Console.ReadLine();

    if (dtInput == "exit")
    {
        break;
    }

    DateTime res;
    if (DateTime.TryParse(dtInput, out res))
    {
        if (res - DateTime.Today == TimeSpan.Zero)
        {
            Console.WriteLine("That date is today!");
        }
        else if (res - DateTime.Today > TimeSpan.Zero)
        {
            Console.WriteLine($"That date will be in {(res - DateTime.Today).Days} days.");
        }
        else
        {
            Console.WriteLine($"That date was {(DateTime.Today - res).Days} days ago.");
        }
    }
    else
    {
        Console.WriteLine("That is not a valid date");
    }
}
while (dtInput != "exit");